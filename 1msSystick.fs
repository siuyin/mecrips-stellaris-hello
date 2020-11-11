\ 1msSystick provides an initSystick word for 1ms systick
\ The systick interrupt service routine must be loaded before this file and MUST be named systickISR.

$E000E010 CONSTANT STK_CSR	\ SysTick control and status register. R/W reset value = $0000 0004. See PM0215, 4.4.1, pg 86.
$E000E014 CONSTANT STK_RVR	\ SysTick reload value register. R/W reset value = unknown
$E000E018 CONSTANT STK_CVR	\ SysTick current value register. R/W reset value = unknown
: initSystick ( -- )
    ['] systickISR irq-systick ! \ point vector of systick IRQ to systickISR. The ['] construct is to go into interpreter mode to get the address of systickISR, then return to compile mode.

    \ Setup and run systick timer with 1ms period.
    8000 1- STK_RVR ! \ The systick timer is fed from the 8MHz processor clock. To have a 1ms period, a divider of 8000 - 1 = 7999 is required.
    8000 1- STK_CVR ! \ initialise current value
    %111 STK_CSR bis! \ systick: processor clock source, interrupt generated, systick counter enabled. bis is bits (plural) set to the mask 0b111, other positions are unaffected.
;
