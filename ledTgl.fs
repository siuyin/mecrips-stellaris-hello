\ ledTgl.fs toggles LED on PA5 when push button on PA6 is pressed.

forgetram
compiletoram

0 variable Tick
0 variable TglCnt
: systickISR ( -- )
    Tick @ 1+ Tick ! \ increment Tick
    TglCnt @ 0 > if \ decrement TglCnt to 0. Reset in toggle task routine
        TglCnt @ 1- TglCnt !
    then
;

$E000E010 CONSTANT STK_CSR	\ SysTick control and status register. R/W reset value = $0000 0004. See PM0215, 4.4.1, pg 86.
$E000E014 CONSTANT STK_RVR	\ SysTick reload value register. R/W reset value = 6000 for the STM32F0
: initSystick ( -- )
    ['] systickISR irq-systick ! \ point vector of systick IRQ to systickISR. The ['] construct is to go into interpreter mode to get the address of systickISR, then return to compile mode.

    \ Setup and run systick timer with 1ms period.
    8000 1- STK_RVR ! \ The systick timer is fed from the 8MHz processor clock. To have a 1ms period, a divider of 8000 - 1 = 7999 is required.
    %111 STK_CSR bis! \ systick: processor clock source, interrupt generated, systick counter enabled. bis is bits (plural) set to the mask 0b111, other positions are unaffected.
;




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



GPIOA $C + constant GPIOA_PUPDR ( GPIO port pull-up/pull-down  register ) 
: initBtn ( -- ) \ initialise button for pull-up on PA6.
    %01 6 2* lshift GPIOA_PUPDR bis! \ 01=pull-up
;

GPIOA $10 + constant GPIOA_IDR ( GPIO port input data register ) 
: btnPshd? ( -- flag )
    1 6 lshift GPIOA_IDR bit@ not
;

0 variable btnSt \ button state
: btnSM ( -- )
    btnSt @ case
        0 of \ button is released
            btnPshd? if
                ledTgl
                1 btnSt !
            then
        endof
        
        1 of \ button is pushed
            btnPshd? if
            else
                2 btnSt !
            then
        endof

        2 of \ button may be released
            btnPshd? if
                1 btnSt !
            else
                0 btnSt !
            then
        endof
    endcase
;

\ Toggle checks button on PA6 and toggles LED on PA5 when button is pushed.
\ Runs every 20ms. Button is debounced.
: Toggle ( -- ) 
    initLED
    initBtn
    initSystick

    begin
        TglCnt @ 0= if
            20 TglCnt !
            btnSM \ button state machine controls the LED
        then
        key?
    until
;

Toggle
compiletoram
