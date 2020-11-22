forgetram
compiletoram

$40021000 constant RCC ( Reset and clock control ) 
RCC $24 + constant RCC_CSR ( Control/status register  RCC_CSR ) 
: int40En ( -- ) \ enable internal 40kHz low speed oscillator
    1 RCC_CSR bis!
;
IWDG $0 + constant IWDG_KR ( Key register ) 
: wdgStart ( -- ) \ start watchdog and enable access to configuration registers
    $cccc IWDG_KR ! \ start watchdog
    $5555 IWDG_KR ! \ enable access to prescaler and reload registers
;
IWDG $4 + constant IWDG_PR ( Prescaler register ) 
: wdgPsc ( -- ) \ set watchdog prescaler to divide the 40kHz internal clock by 256
    %111 IWDG_PR bis!
;
IWDG $8 + constant IWDG_RLR ( Reload register ) 
: wdgRld ( -- ) \ the watchdog count down from this value
    468 IWDG_RLR ! \ 3 seconds: 40kHz / 256 / 468
;
IWDG $C + constant IWDG_SR ( Status register ) 
: wdgWtUpd ( -- ) \ wait for update
    begin IWDG_SR @ 0= until
;
: wdgRst ( -- ) \ reset watchdog by reloading counter
    $aaaa IWDG_KR !
;
: wdgEn
    int40En
    wdgStart
    wdgPsc
    wdgRld
    wdgWtUpd
    wdgRst
    \ let the watchdog time out, write $aaaa to IWDG_KR to prevent this.
;
\ WdgBlink blinks LED at pin 11 (PA 5) when the independent watchdog expires
: WdgBlink
    wdgEn
;

compiletoram

\ main

WdgBlink
