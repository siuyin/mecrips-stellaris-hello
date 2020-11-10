\ LED on PA5.

forgetram
compiletoram

\ register defines
$48000000 constant GPIOA		 
GPIOA $0 + constant GPIOA_MODER
GPIOA $14 + constant GPIOA_ODR ( GPIO port output data register ) 
GPIOA $18 + constant GPIOA_BSRR


: initLED %01  10 lshift GPIOA_MODER bis! ;		\ PA5 is bit 10 on mode register

: half-second-delay 400000 0 do loop ;

: led.on   %1  5 lshift GPIOA_BSRR bis! ;	

: led.off  1 21 lshift GPIOA_BSRR bis! ; 

: ledTgl ( -- )
    1 5 lshift GPIOA_ODR bit@ if
        led.off
    else
        led.on
    then
;
 
: blink		
    initLED
    begin
        ledTgl
        half-second-delay
        key? 
    until
;	

: init 
    cr ." Running blink. Press <enter> to stop." cr
    blink
;

compiletoram

