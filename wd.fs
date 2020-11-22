\ wd.fs demonstrates use of watchdog timer with low power
\ features of the STM32F030F4.

compiletoflash

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $C + constant IWDG_SR ( Status register ) 

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
: ledInit ( -- ) \ set PA5 to output
    %01 5 2* lshift GPIOA_MODER bis!
;
GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
: ledBlink ( -- )
    1 5 lshift GPIOA_BSRR bis! \ turn on LED
    1000 0 do i drop loop \ busy loop for a while
    1 5 16 + lshift GPIOA_BSRR bis! \ turn off LED
;

compiletoram
