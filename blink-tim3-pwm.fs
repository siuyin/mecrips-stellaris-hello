\ blink-tim3-pwm.fs blinks an LED on PA6 / TIM3_CH1 using PWM

forgetram
compiletoram


$40000400 constant TIM3 ( General-purpose-timers ) 
TIM3 $18 + constant TIM3_CCMR1_Output ( capture/compare mode register 1 output  mode ) 
: pwmMode1 ( -- )
    %110 4 lshift TIM3_CCMR1_Output bis! \ See RM0360, 14.4.7, pg 348, bits 6:4, OC1M
;
: ocPE ( -- ) \ output compare channel 1, preload enable
    1 3 lshift TIM3_CCMR1_Output bis!
;
TIM3 $0 + constant TIM3_CR1 ( control register 1 ) 
: arpe ( -- ) \ auto-reload/preload enable
    1 7 lshift TIM3_CR1 bis! \ buffer TIM3 auto-reload register
;



TIM3 $28 + constant TIM3_PSC ( prescaler ) 
: tim3Psc ( -- ) \ set prescaler so that timer 3 clocks at 1ms
    8000 1- TIM3_PSC h!
;
TIM3 $2C + constant TIM3_ARR ( auto-reload register ) 
: setPeriod ( -- ) \ set period to 1 second, 1000 clock ticks
    1000 1- TIM3_ARR h!
;
TIM3 $34 + constant TIM3_CCR1 ( capture/compare register 1 ) 
: setDutyCycle ( -- ) \ set duty cycle at 50% or 1000 clock ticks / 2
    1000 2 / TIM3_CCR1 h!
;
TIM3 $14 + constant TIM3_EGR ( event generation register ) 
: tim3Upd ( -- ) \ generate an update event to load registers
    1 TIM3_EGR bis!
;

TIM3 $20 + constant TIM3_CCER ( capture/compare enable  register ) 
: tim3C1OE ( -- ) \ output enable
    1 TIM3_CCER bis! \ enable channel 1 output
;



$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
GPIOA $20 + constant GPIOA_AFRL ( GPIO alternate function low  register ) 
: pa6Tim3 ( -- ) \ set PA6 to timer 3 via alternate function register
    %10 6 2* lshift GPIOA_MODER bis! \ set mode to alternate function
    %0001 6 2* 2* lshift GPIOA_AFRL bis! \ alternate function 1 is TIM3_CH1
;

$40021000 constant RCC ( Reset and clock control ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
: clkTim3 ( -- ) \ enable advanced peripheral bus clock to timer 3
    1 1 lshift RCC_APB1ENR bis!
;
: tim3ClkEn ( -- ) \ enable clock on timer 3 itself
    1 TIM3_CR1 bis!
;
: tim3En ( -- )
    clkTim3 \ route clock to timer 3 from Reset and Clock Control module.
    pa6Tim3 \ set pin PA6 to alternate function TIM3_CH1
;
: cfgOut ( -- )
    pwmMode1 \ The following ocPE and arpe are required for PWM mode.
    ocPE \ output compare preload enable
    arpe \ auto-reload/preload enable 
    tim3C1OE \ timer 3 channel 1 output enable
;
: Blink ( -- ) \ blink LED with timer 3 using PWM
    tim3En

    cfgOut
   
    tim3Psc \ set prescaler
    setPeriod
    setDutyCycle

    tim3Upd \ generate update event to load preload registers

    tim3ClkEn
;

TIM3 $24 + constant TIM3_CNT ( counter ) 

Blink

compiletoram

