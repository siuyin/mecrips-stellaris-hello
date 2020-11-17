\ usonic.fs supports the HC-SR04 ultrasonic ranging module
\ PF0 (pin2) is connected to Echo, PF1 (pin3) connected to Trig.

forgetram
compiletoram

$48001400 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF_MODER ( GPIO port mode register ) 
: ioInit ( -- ) \ initialises PF0 (input) and PF1 (output)
    %01 1 2* lshift GPIOF_MODER bis! \ PF1/Trig output
    \ %11 GPIOF_MODER bic! \ PF0 reset state is input
;

: dly ( n -- )
    0 do
        i drop
    loop
;
: dlyS 1 dly ;
: dlyM 4 dly ; \ about 12.5us
GPIOF $18 + constant GPIOF_BSRR ( GPIO port bit set/reset  register ) 
: trigL ( -- )
    %1 1 16 + lshift GPIOF_BSRR bis! \ reset PF1/Trig
;
: trigH ( -- )
    %1 1 lshift GPIOF_BSRR bis! \ set PF1/Trig
;
: ping ( -- )
    trigL dlyS
    trigH dlyM
    trigL
;

GPIOF $10 + constant GPIOF_IDR ( GPIO port input data register ) 
: echoH?
    1 GPIOF_IDR bit@
;
0 variable cnt
: meas ( -- n ) \ outputs n, the distance in millimeters.
    0 cnt !
    begin echoH? until \ wait until echo goes high
    begin
        cnt @ 1+ cnt !
        echoH? not \ wait for echo to go low again
    until
    cnt @ 1085 * 1000 / \ each count is about 1.085mm
;

compiletoram

ioInit
\ ping meas .

