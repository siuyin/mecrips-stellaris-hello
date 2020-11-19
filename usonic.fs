\ usonic.fs supports the HC-SR04 ultrasonic ranging module
\ PF0 (pin2) is connected to Echo, PF1 (pin3) connected to Trig.

forgetram
compiletoram

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
$48001400 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF_MODER ( GPIO port mode register ) 
: ioInit ( -- ) \ initialises PF0 (input) and PF1 (output)
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
: ping ( -- )
    trigL dlyS
    trigH dlyM
    trigL
;


GPIOF $10 + constant GPIOF_IDR ( GPIO port input data register ) 
: echoH?
    1 GPIOF_IDR bit@
;
0 variable cnt
: meas ( -- n ) \ outputs n, the distance in millimeters.
    0 cnt !
    begin echoH? until \ wait until echo goes high
    begin
        cnt @ 1+ cnt !
        echoH? not \ wait for echo to go low again
    until
    \ cnt @
    cnt @ 1082 * 1000 / \ each count is about 1.08mm
;

$40021000 constant RCC ( Reset and clock control ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
$40000400 constant TIM3 ( General-purpose-timers ) 
TIM3 $28 + constant TIM3_PSC ( prescaler ) 
TIM3 $0 + constant TIM3_CR1 ( control register 1 ) 
TIM3 $24 + constant TIM3_CNT ( counter ) 
: tim3En ( -- )
    %1 1 lshift RCC_APB1ENR bis! \ enable clock to timer 3
    8 TIM3_PSC ! \ CPU is clocked at 8MHz with a prescaler of 8, one timer 3 period is 1us.
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
: tim3IntrEn ( -- ) \ timer 3 interrupt enable
    ['] tim3ISR irq-exti0_1 !
    1 RCC_APB2ENR bis! \ enable system config clock
    %0101 SYSCFG_EXTICR1 bis! \ select PF0/Echo for ExtI0
    1 EXTI_RTSR bis! \ interrupt on line 0 rising edge
    1 EXTI_FTSR bis! \ interrupt on line 0 falling edge
    1 EXTI_IMR bis! \ unmask interrupt on line 0
    1 5 lshift NVIC_ISER bis! \ enable line 0 position 5 on NVIC, see RM0360, Table 31, EXTI0_1.
    tim3En
;

compiletoram

ioInit
tim3IntrEn
\ ping meas .

