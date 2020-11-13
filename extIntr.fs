\ extI.fs shows usage of external interrupts
\ LED connected on PA5 (pin 11) active high.
\ Button connected to PA6 (pin 12) low when pushed.

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
: btnPshd? ( -- flag )
    1 6 lshift GPIOA_IDR bit@ not
;
: ledOff ( -- )
    1 5 16 + lshift GPIOA_BSRR bis!
;
: ledOn ( -- )
    1 5 lshift GPIOA_BSRR bis!
;


\ install interrupt service routine here

$40010400 constant EXTI ( External interrupt/event  controller ) 
EXTI $14 + constant EXTI_PR ( Pending register EXTI_PR ) 
: pa6ISR ( -- )
    1 6 lshift EXTI_PR bis! \ clear pending interrupt
    ledOn

;


$E000E100 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $0 + constant NVIC_ISER ( Interrupt Set Enable Register ) 
: nvPA6En ( -- )
    1 7 lshift NVIC_ISER bis! \ enable EXTI6 for PA6 button
;


EXTI $C + constant EXTI_FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $0 + constant EXTI_IMR ( Interrupt mask register  EXTI_IMR ) 
: exPA6En ( -- )
    1 6 lshift EXTI_FTSR bis! \ trigger when button on PA6 is pushed -- falling edge trigger
    1 6 lshift EXTI_IMR bis! \ allow PA6 to interrupt
;


: initPA6Intr ( -- )
    ['] pa6ISR irq-exti4_15 ! \ install IRQ
    nvPA6En \ enable PA6 in NVIC
    exPA6En \ enable PA6 in EXTI

    initBtnLED \ initialise button and LED
;

initPA6Intr \ install the PA6 vector

compiletoram

