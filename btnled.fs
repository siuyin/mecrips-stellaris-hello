\ btnled.fs -- button and led example.

forgetram

compiletoram

\ LED (PA5)  and Button (PA6)
$48000000 constant GPIOA		 
GPIOA $0 + constant GPIOA_MODER
GPIOA $C + constant GPIOA_PUPDR ( GPIO port pull-up/pull-down  register ) 
: initBtnLED ( -- )
    %01 5 2* lshift GPIOA_MODER bis! \ LED (PA5) is bit 10 on mode register, 01=output mode

    \ %00 6 2* lshift GPIOA_MODER bic! \ Btn (PA6) is bit 12, 00=inputmode. This is the reset value.
    %01 6 2* lshift GPIOA_PUPDR bis! \ 01=pull-up
;

GPIOA $10 + constant GPIOA_IDR ( GPIO port input data register ) 
GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
: btnUp? ( -- flag )
    1 6 lshift GPIOA_IDR bit@
;
: ledOff ( -- )
    1 5 16 + lshift GPIOA_BSRR bis!
    \ $200000 GPIOA_BSRR bis! \ no difference in memory used, good compiler optimisation!
;
: ledOn ( -- )
    1 5 lshift GPIOA_BSRR bis!
;
: Slv ( -- ) \ Slave LED to Btn state, LED is on when Btn is pushed.
    initBtnLED
    begin
        btnUp? if \ Btn released? -- high
            ledOff
        else
            ledOn
        then
        key?
    until
;

compiletoram

Slv

