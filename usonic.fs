\ usonic.fs supports the HC-SR04 ultrasonic ranging module
\ PF0 (pin2) is connected to Echo, PF1 (pin3) connected to Trig.

forgetram
compiletoram

\ --------- IOInit initialises GPIOs -----------

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
$48001400 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF_MODER ( GPIO port mode register ) 
: IOInit ( -- ) \ initialises PF0 (input) and PF1 (output)
    %01 1 2* lshift GPIOF_MODER bis! \ PF1/Trig output
    \ %11 GPIOF_MODER bic! \ PF0 reset state is input
    %01 GPIOA_MODER bis! \ PA0 is debug output
;
GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
: dbH ( -- ) \ debug high
    1 GPIOA_BSRR bis! \ pulse high
;
: dbL ( -- )
    1 16 lshift GPIOA_BSRR bis! \ pulse low
;

\ ------------- Ping routines -------------------------

: dly ( n -- )
    0 do
        i drop
    loop
;
: dlyS 1 dly ;
: dlyM 4 dly ; \ about 12.5us
GPIOF $18 + constant GPIOF_BSRR ( GPIO port bit set/reset  register ) 
: trigL ( -- )
    %1 1 16 + lshift GPIOF_BSRR bis! \ reset PF1/Trig
;
: trigH ( -- )
    %1 1 lshift GPIOF_BSRR bis! \ set PF1/Trig
;
: Ping ( -- )
    trigL dlyS
    trigH dlyM
    trigL
;

\ --------------- Meas measures with busy loop counter -------------------------------

GPIOF $10 + constant GPIOF_IDR ( GPIO port input data register ) 
: echoH?
    1 GPIOF_IDR bit@
;
0 variable cnt
: Meas ( -- n ) \ outputs n, the distance in millimeters.
    0 cnt !
    begin echoH? until \ wait until echo goes high
    begin
        cnt @ 1+ cnt !
        echoH? not \ wait for echo to go low again
    until
    \ cnt @
    cnt @ 1082 * 1000 / \ each count is about 1.08mm
;


\ --------------- IntrMeas measures with timer 3 and interrupts -------------------------

$40021000 constant RCC ( Reset and clock control ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
$40000400 constant TIM3 ( General-purpose-timers ) 
TIM3 $28 + constant TIM3_PSC ( prescaler ) 
TIM3 $0 + constant TIM3_CR1 ( control register 1 ) 
TIM3 $24 + constant TIM3_CNT ( counter ) 
: tim3En ( -- )
    %1 1 lshift RCC_APB1ENR bis! \ enable clock to timer 3
    7 TIM3_PSC ! \ When PSC is set to 0 the divider is 1. When set to 7 the divider is 8. CPU is clocked at 8MHz with a divider of 8, one timer 3 period is 1us.
    1 TIM3_CR1 ! \ enable clocking on timer 3 to start it counting
;

$40010400 constant EXTI ( External interrupt/event  controller ) 
EXTI $14 + constant EXTI_PR ( Pending register EXTI_PR ) 
0 variable cntStart
0 variable pulseDur
: tim3ISR ( -- )
    1 EXTI_PR bit@ if
        1 EXTI_PR bis! \ clear pending interrupt on line 0
        echoH? if
            TIM3_CNT @ cntStart !
        else
            TIM3_CNT @ cntStart @ -
            pulseDur !
        then
    then
;

$40010000 constant SYSCFG ( System configuration controller ) 
SYSCFG $8 + constant SYSCFG_EXTICR1 ( external interrupt configuration register  1 ) 
RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
EXTI $0 + constant EXTI_IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $8 + constant EXTI_RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI_FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
$E000E100 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $0 + constant NVIC_ISER ( Interrupt Set Enable Register ) 
: IntrMeas ( -- ) \ measure with timer 3 and interrupts 
    ['] tim3ISR irq-exti0_1 !
    1 RCC_APB2ENR bis! \ enable system config clock
    %0101 SYSCFG_EXTICR1 bis! \ select PF0/Echo for ExtI0
    1 EXTI_RTSR bis! \ interrupt on line 0 rising edge
    1 EXTI_FTSR bis! \ interrupt on line 0 falling edge
    1 EXTI_IMR bis! \ unmask interrupt on line 0
    1 5 lshift NVIC_ISER bis! \ enable line 0 position 5 on NVIC, see RM0360, Table 31, EXTI0_1.
    tim3En
;


\ TmrMeasInit initialises timer3 to measure echo pulse duration

GPIOA $20 + constant GPIOA_AFRL ( GPIO alternate function low  register ) 
: pa6Tim3Input ( -- ) \ configure PA6, pin 12 as TIM3 channel 1 
    %10 6 2* lshift GPIOA_MODER bis! \ set PA6 to alternate function mode
    %0001 6 4 * lshift GPIOA_AFRL bis! \ select alternate function 1 (timer 3, channel 1) for PA6
;

TIM3 $18 + constant TIM3_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $20 + constant TIM3_CCER ( capture/compare enable  register ) 
TIM3 $8 + constant TIM3_SMCR ( slave mode control register ) 
: TmrMeasInit ( -- ) \ measurement left in TIM3_CNT
    pa6Tim3Input

    %1 1 lshift RCC_APB1ENR bis! \ enable clock to timer 3

    %01 TIM3_CCMR1_Input bis! \ CC1 channel is configured as input, IC1 is mapped on TI1

    1 1 lshift TIM3_CCER bis! \ trigger on rising edge
    1 3 lshift TIM3_CCER bis! \ trigger on falling edge

    7 TIM3_PSC h! \ set up timer 3 prescaler for 1us clock period. 8MHz / (7+1)

    %101 4 lshift TIM3_SMCR bis! \ use timer 1 filtered input as trigger source
    %100  TIM3_SMCR bis! \ set up timer 3 to reset counter on trigger

    1 TIM3_CCER bis! \ enable capture input

    1 TIM3_CR1 bis! \ enable clock to timer 3
;

\ TmrMeas measures pulse duration and outputs distance estimate in millimeters

TIM3 $10 + constant TIM3_SR ( status register ) 
: clrCapFlg ( -- )
    1 1 lshift TIM3_SR bic! \ clear capture 1 flag
;
: capFlg? ( -- flag ) \ has an input capture occured ?
    1 1 lshift TIM3_SR hbit@
;
TIM3 $34 + constant TIM3_CCR1 ( capture/compare register 1 ) 
: TmrMeas ( -- n )
    clrCapFlg
    Ping
    begin capFlg? until \ wait for rising edge
    clrCapFlg \ discard the reset (zeroed) counter value
    begin capFlg? until \ wait for falling edge
    TIM3_CCR1 h@ \ read this value captured after the falling edge
    10 58 */ \ convert microseconds to distance estimate in millimeters
;
compiletoram

\ --------- main -----------------

IOInit
\ IntrMeas
\ Ping Meas .

TmrMeasInit
TmrMeas .
