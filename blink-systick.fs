\ blink-systick.fs -- uses the systick timer to blink LED on PA5.
\ IMPORTANT: A dangling systick instruppt vector results if a different program is subsequently loaded.
\  The symptom being "unhandled interupt 003!". Recover by resetting the MCU and reloading.

forgetram
compiletoram

\ -------------------- SysTick ISR installation ------------------------------------

0 variable Tick
0 variable blinkCnt
: systickISR ( -- )
    Tick @ 1+ Tick ! \ increment Tick
    blinkCnt @ 0 > if \ decrement blinkCnt to 0. Reset in Blink routine
        blinkCnt @ 1- blinkCnt !
    then
;

#include 1msSystick.fs


\ --------------------------------- LED routines ------------------------------------------------

\ LED on PA5 is active high.
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
    ledOn? if \ we could also have used XOR on the Output Data Register
        ledOff
    else
        ledOn
    then
;

\ ---------------------------- User level routines --------------------------

\ Blink blink the LED connected to PA5.
: Blink ( -- )
    cr ." Press <enter> key to exit"
    initLED
    initSystick
    begin
        blinkCnt @ 0= if
            ledTgl
            500 blinkCnt ! \ reload blink count to n milliseconds
        then
        key?
    until
;

\ -------------------------------- main ----------------------------------

Blink

compiletoram
