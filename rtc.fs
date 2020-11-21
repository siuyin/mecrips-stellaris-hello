\ rtc.fs provides real-time clock routines.
\ AlarmA, RTC_TAMP1 and RTC_TAMP2 are available on STM32F030F4.

forgetram
compiletoram
$40021000 constant RCC ( Reset and clock control ) 
RCC $24 + constant RCC_CSR ( Control/status register  RCC_CSR ) 
RCC $20 + constant RCC_BDCR ( Backup domain control register  RCC_BDCR ) 
RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR_CR ( power control register ) 
: rccEnRTC ( -- )
    1 RCC_CSR bis! \ LSIOn -- enable low speed internal oscillator
    1 28 lshift RCC_APB1ENR bis! \ enable power config component
    1 8 lshift PWR_CR bis! \ enable access to RTC registers
    1 15 lshift RCC_BDCR bis! \ enable RTC
    %10 8 lshift RCC_BDCR bis! \ select low speed internal oscillator
;
$40002800 constant RTC ( Real-time clock ) 
RTC $24 + constant RTC_WPR ( write protection register ) 
RTC $C + constant RTC_ISR ( initialization and status  register ) 
: rtcInitF? ( -- flag )
    1 6 lshift RTC_ISR bit@
;
: rtcUnlock ( -- )
    $ca RTC_WPR !  \ enter passwords to enable access
    $53 RTC_WPR !

    1 7 lshift RTC_ISR bis! \ enter RTC initialisation mode
    begin rtcInitF? until \ wait for init flag to be raised
;
: rtcLock ( -- )
    1 7 lshift RTC_ISR bic! \ exit init mode
    $fe RTC_WPR ! \ lock access
    $64 RTC_WPR !
;
RTC $10 + constant RTC_PRER ( prescaler register ) 
: pscCfg ( -- ) \ LSI is 40kHz / 125 / 320 = 1Hz
    125 1- 16 lshift RTC_PRER bis! \ set prescaler 1 to 124 for a divisor of 125
    320 1-  RTC_PRER bis! \ set prescaler2 for a divisor of 320
;
RTC $0 + constant RTC_TR ( time register ) 
: timeSet ( n -- ) \ sets time
   RTC_TR !
;
: RTCInit ( -- )
    rccEnRTC \ enable clocking the RTC in RCC
    rtcUnlock \ unlock access to RTC registers
    pscCfg \ configure prescalers
    0 timeSet \ set time to 00:00:00 for demo purposes
    rtcLock
;

: Time ( -- n ) \ outputs seconds elapsed since start.
    hex
    RTC_TR 3 + C@ . 
    RTC_TR 2+ C@ . space

    RTC_TR 1+ C@ . 
    RTC_TR C@ .
    decimal
;

compiletoram

\ main
RTCInit
