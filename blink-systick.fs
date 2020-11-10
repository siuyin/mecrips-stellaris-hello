\ blink-systick.fs -- uses the systick timer to blink LED on PA5.

forgetram
compiletoram

0 variable Tick
0 variable BlinkCnt
: systickISR ( -- )
    Tick @ 1+ Tick ! \ increment Tick
    BlinkCnt @ 0 > if \ decrement BlinkCnt to 0. Reset in Blink routine
        BlinkCnt @ 1- BlinkCnt !
    then
;

$E000E010 CONSTANT STK_CSR	\ SysTick control and status register. R/W reset value = $0000 0004. See PM0215, 4.4.1, pg 86.
$E000E014 CONSTANT STK_RVR	\ SysTick reload value register. R/W reset value = 6000 for the STM32F0
: initSystick ( -- )
    ['] systickISR irq-systick ! \ point vector of systick IRQ to systickISR.

    \ Setup and run systick timer with 1ms period.
    8000 1- STK_RVR ! \ The systick timer is fed from the 8MHz processor clock. To have a 1ms period a divider of 8000 - 1 = 7999 is required.
    %111 STK_CSR bis! \ systick: processor clock source, interrupt generated, systick counter enabled.
;


\ LED on PA5 active high.
$48000000 constant GPIOA		 
GPIOA $0 + constant GPIOA_MODER
: initLED ( -- )
    %01 5 2* lshift GPIOA_MODER bis! \ LED (PA5) is bit 10 on mode register, 01=output mode
;

GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
: ledOff ( -- )
    1 5 16 + lshift GPIOA_BSRR bis!
    \ $200000 GPIOA_BSRR bis! \ no difference in memory used, good compiler optimisation!
;
: ledOn ( -- )
    1 5 lshift GPIOA_BSRR bis!
;

GPIOA $14 + constant GPIOA_ODR ( GPIO port output data register ) 
: ledOn? ( -- flag )
    1 5 lshift GPIOA_ODR bit@
;
: ledTgl ( -- ) \ toggle LED
    ledOn? if
        ledOff
    else
        ledOn
    then
;
: Blink ( -- )
    initLED
    initSystick
    begin
        BlinkCnt @ 0= if
            ledTgl
            500 BlinkCnt ! \ reload blink count to n milliseconds
        then
        key?
    until
;


Blink
compiletoram
