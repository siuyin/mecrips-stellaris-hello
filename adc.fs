\ adc.fs provides adc related routines.
\ A potentiometer is connected to PA7, pin 13 to feed Analog In channel 7

forgetram
compiletoram


\ ---------------- ADC low level routines ----------------------------


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
ADC $40 + constant ADC_DR ( data register ) 
: adDat ( -- n ) \ output ADC data register
    ADC_DR h@
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
: adOvr?
    1 4 lshift ADC_ISR bit@ \ check if overrun flag is set
;
: adClrOvr
    1 4 lshift ADC_ISR bis! \ reset overrun flag by writing 1 to the bit
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

$40020000 constant DMA ( DMA controller ) 
DMA $8 + constant DMA_CCR1 ( DMA channel configuration register  DMA_CCR ) 
: dmEn1? ( -- ) \ is DMA enabled
    1 DMA_CCR1 bit@ \ is DMA channel 1 enabled?
;
ADC $C + constant ADC_CFGR1 ( configuration register 1 ) 
: dmEn1 ( 1/0 -- ) \ enable/disable DMA channel 1
    0= if
        1 DMA_CCR1 bic!
        1 ADC_CFGR1 bic! \ disable DMA on ADC as well
    else
        1 DMA_CCR1 bis!
        1 ADC_CFGR1 bis! \ enable DMA on ADC as well
    then
;


\ ----------------------------- ADC user level routines ---------------------------------------

\ ADRecal recalibrates the ADC to remove offsets due to Vdd and temperature changes.
: ADRecal ( -- )
    adDis
    0 dmEn1 \ disable DMA channel 1
    adCal
    adWaitCal
    adEn
;

\ ADConv samples and converts ADC channel n
: ADConv ( n -- n )
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
\ AIn7 converts analog input 7 on PA7.
: AIn7 ( -- n ) 
    7 ADConv
;

\ Temp converts the chip-internal temperature sensor.
: Temp ( -- n ) 
    16 ADConv
;

\ VRef converts the chip-internal voltage reference. Approx. 1.22 Vdc.
: VRef ( -- n ) 
    17 ADConv
;


6 buffer: adConvBuf
\ ADConv3 triggers 3 separate conversions which are stored in adConvBuf.
: ADConv3 ( -- )
    AIn7 adConvBuf h!
    Temp adConvBuf 2+ h!
    Vref adConvBuf 4 + h!
;

: adSelect3 ( -- )
    1 7 lshift
    1 16 lshift
    1 17 lshift
    + + adCh \ select AIn7, temperature sensor and internal voltage reference to be sequentially converted.
;
\ ADConvSq triggers a sequential conversion. The results are stored in adConvBuf.
: ADConvSq ( -- ) \ sequential convertion
    adSelect3

    adClrEndConvFlag
    adStart
    3 0 do 
        begin adEndConv? until
        adClrEndConvFlag
        adDat adConvBuf i 2* + h!
    loop
;

: cfgDMA ( -- )
    %01 10 lshift DMA_CCR1 bis! \ transfer 16-bit data to adConvBuf memory
    %01 8 lshift DMA_CCR1 bis! \ get 16-bit data from ADC peripheral
    %1 7 lshift DMA_CCR1 bis! \ increment adConvBuf memory address after each transfer
    \ %1 5 lshift DMA_CCR1 bic! \ do not increment ADC peripheral address after each transfer. reset default

;
DMA $10 + constant DMA_CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA $14 + constant DMA_CMAR1 ( DMA channel 1 memory address  register ) 
DMA $C + constant DMA_CNDTR1 ( DMA channel 1 number of data  register ) 
RCC $14 + constant RCC_AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
: adDMAOneS ( -- )
    1 RCC_AHBENR bis! \ send clock to DMA
    \ 1 1 lshift ADC_CFGR1 bic! \ keep at 0, reset condition for DMA one-shot mode

    0 dmEn1 \ disable DMA channel 1 for configuration
    ADC_DR DMA_CPAR1 ! \ point DMA channel 1 to the ADC

    adConvBuf DMA_CMAR1 ! \ point DMA channel 1 to write to adConvBuf

    3 DMA_CNDTR1 ! \ tell DMA channel 1 there are 3 items to be transferred
    
    cfgDMA
    1 dmEn1 \ configuration done, enable DMA channel 1
;
\ ADConvDMA triggers a sequential conversion. Data is DMA'ed to adConvBuf.
: ADConvDMA ( -- )
    adSelect3
    adDMAOneS
    adStart
;

\ ADDump3 displays adConvBuf.
: ADDump3 ( -- ) \ AIn7, Temp Sensor, VRef
    adConvBuf h@ .
    adConvBuf 2+ h@ . 
    adConvBuf 4 + h@ . cr
;

0 variable p7val
\ AD7Samp64 samples AIn7 64 times and averages the samples.
: AD7Samp64 ( -- ) 
    0 p7val !
    64 0 do AIn7 p7val +! loop
    p7val @ 64 / .
;

: InitADC ( -- )
    adEn? not if \ only initialise if not already enabled

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

\ ************************************************* main ***********************************************

InitADC
ADRecal

\ ADConv3 ADDump3
ADConvSq ADDump3
\ AD7Samp64

ADConvDMA ADDump3

compiletoram

