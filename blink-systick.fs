\ blink-systick.fs -- uses the systick timer to blink LED on PA5.
\ IMPORTANT: A dangling systick instruppt vector results if a different program is subsequently loaded.
\  The symptom being "unhandled interupt 003!". Recover by resetting the MCU and reloading.

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

#include 1msSystick.fs



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
