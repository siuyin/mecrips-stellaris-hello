\ adc.fs provides adc related routines.
\ A potentiometer is connected to PA7, pin 13 to feed Analog In channel 7

forgetram
compiletoram

$40012400 constant ADC ( Analog-to-digital converter ) 
$40021000 constant RCC ( Reset and clock control ) 

RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $34 + constant RCC_CR2 ( Clock control register 2 ) 
: rcAdEn ( -- ) \ enable clock to ADC
    1 9 lshift RCC_APB2ENR bis!
    1 RCC_CR2 bis! \ turn on high speed internal 14MHz ADC clock
;
ADC $8 + constant ADC_CR ( control register ) 
: adEn ( -- ) \ enable ADC
    ADC_CR @ 0= if \ Software is allowed to set ADEN only when all bits of ADC_CR registers are 0 (ADCAL=0, ADSTP=0, ADSTART=0, ADDIS=0 and ADEN=0)
        1 ADC_CR bis!
    then
;
: adEn? ( -- flag )
    1 ADC_CR bit@
;
ADC $308 + constant ADC_CCR ( common configuration register ) 
: adTempSnEn ( -- )
    1 23 lshift ADC_CCR bis!
;
: adVRefEn ( -- )
    1 22 lshift ADC_CCR bis!
;
ADC $0 + constant ADC_ISR ( interrupt and status register ) 
: adDis ( -- ) \ disable ADC
    adEn? if \ only disable if ADC is enabled in the first place
        1 4 lshift ADC_CR bis! \ stop any ongoing conversion
        1 1 lshift ADC_CR bis! \ disable ADC
        1 ADC_ISR bic! \ reset adc ready flag by writing a 1 to bit 0 of ADC_ISR
    then
;

: adCal ( -- ) \ calibrate ADC
    adEn? if        
        ." cannot calibrate: ADC enabled"
    else
        1 31 lshift ADC_CR bis! \ set ADC calibration bit
    then
;

: adWaitCal ( -- ) \ wait for calibration to be completed
    adEn? if        
        ." ADC enabled, did not wait for calibration"
    else
        begin
            31 ADC_CR bit@ not \ wait this bit is reset by hardware
        until
    then
;

ADC $40 + constant ADC_DR ( data register ) 
: adCalFactor ( -- n) \ 7-bit calibration factor
    ADC_DR @ $7f and \ the calibration factor is in bits [6:0]
;

: adRdy? ( -- flag ) \ is the ADC ready?
    1 ADC_ISR bit@
;
: adWaitRdy ( -- )
    begin
        adRdy?
    until
;
: adStart ( -- ) \ start ADC conversion for the channels configured in adCh
    1 2 lshift ADC_CR bis!
;
: adStart? ( -- flag) \ is ADC conversion underway?
    1 2 lshift ADC_CR bit@
;
: adEnIdle? ( -- flag ) \ ADC enabled and no conversion is underway?
    adEn? adStart? not and \ adEn? and not adStart
;
: adClrEndConvFlag ( -- ) \ clear end of conversion flag
    1 2 lshift ADC_ISR bis!
;
: adEndConv? ( -- flag )
    1 2 lshift ADC_ISR bit@
;

ADC $28 + constant ADC_CHSELR ( channel selection register ) 
: adCh ( n -- ) \ ADC channel(s) select, n is a bit-map  [0:17] of selected channels
    adStart? not if
        $3fffff and ADC_CHSELR !
    else
        ." channel not selected, conversion in progress (adStart == 1)"
    then
;

ADC $14 + constant ADC_SMPR ( sampling time register ) 
: adSampT ( n -- ) \ set ADC sampling time, n is 3 bits. See RM060, 12.11.6, p216 SMP[2:0]
    adStart? not if
        %111 and ADC_SMPR !
    then
;

ADC $40 + constant ADC_DR ( data register ) 
: adDat ( -- n ) \ output ADC data register
    ADC_DR h@
;
: adConv ( n -- n ) \ samples and convert ADC channel n
    1 swap lshift adCh \ set channel
    adClrEndConvFlag
    adStart
    begin adEndConv? until
    adDat
;

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
: gp7An ( -- ) \ set port PA7 for analog function
    %11 7 2* lshift GPIOA_MODER bis!
;

: InitADC ( -- )
    adEn? not if \ only initialise if not already enabled
        adCal
        adWaitCal

        rcAdEn
        adEn
        adWaitRdy

        adTempSnEn
        adVRefEn
        gp7An
        7 adSampT \ set sampling time

        ." ADC Initialised"
    else
        ." ADC enabled, disable first with adDis before re-initialising"
    then
;



: Temp ( -- n ) 
    16 adConv
;
: VRef ( -- n ) 
    17 adConv
;
: AIn7 ( -- n ) 
    7 adConv
;



InitADC

compiletoram
