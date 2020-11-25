\ spi.fs demonstrates use of SPI on STM32F030F4 to control a MCP4141 digital potentiometer.
\ SPI configured in master transmit only mode.
\ Pins used on F030: PA4,10,SPI1_NSS; PA5,11,SPI1_SCK; PA7,13,SPI1_MOSI;
\ Pins used on MCP4141: nCS,1;          SCK,2;         SDI/SDO,3(to MOSI via protection resistor);

forgetram
compiletoram

$40021000 constant RCC ( Reset and clock control ) 
RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
: rsSPEn ( -- ) \ enable clock to SPI from RSS
    1 12 lshift RCC_APB2ENR bis!
;
$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
: gpAF ( -- ) \ configure slave select and alternate function on GPIO pins.
    %01 4 2* lshift \ slave select (active low) on PA4, GPIO output, push-pull
    %10 5 2* lshift or \ SPI1_SCK
    %10 6 2* lshift or \ SPI1_MISO
    %10 7 2* lshift or \ SPI1_MOSI
    GPIOA_MODER bis!
;
$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1_CR1 ( control register 1 ) 
: spBR ( n -- ) \ sets SPI baud rate: n=0,BR=PClk/2 ... n=7,BR=PClk/256. Divisor is 2^(n+1)
    3 lshift SPI1_CR1 bis!
;
: spMode ( n -- ) \ sets SPI mode 0: 0,0 ; 3: 1,1
    SPI1_CR1 bis!
;
: spBiDi ( -- )  \ SPI bidirectional mode
    1 15 lshift SPI1_CR1 bis!
;
: spDir ( 0/1 ) \ 0 = input, 1 = output. This applies to the relevant 'output' pin MOSI for Master and MISO for Slave.
    0= if
        1 14 lshift SPI1_CR1 bic! \ input
    else
        1 14 lshift SPI1_CR1 bis! \ output
    then
;
: spMst ( -- ) \ configure SPI as master
    1 2 lshift SPI1_CR1 bis!
;
SPI1 $4 + constant SPI1_CR2 ( control register 2 ) 
: spBit ( b -- ) \ set data transfer size to b bits
    8 lshift SPI1_CR2 bis! \ %1111 = 16-bit %0111=8-bit
;
: spHwSS ( -- ) \ SPI hardware control of nSS pin
    1 2 lshift SPI1_CR2 bis!
;
: spSSPls ( -- ) \ pulse nSS between transmissions
    1 3 lshift SPI1_CR2 bis!
;
: spFiTh ( -- ) \ set SPI receive FIFO threshold for 8-bit data transfers
    1 12 lshift SPI1_CR2 bis!
;
GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
: cs ( 0/1 -- ) \ chip select (active low)
    0= if
        1 4 lshift GPIOA_BSRR bis! \ bring line inactive (high)
    else
        1 4 16 + lshift GPIOA_BSRR bis! \ bring line active (low)
    then
;
: spEn ( 0/1 -- ) \ disable/enable SPI
    0= if
        1 6 lshift SPI1_CR1 bic!
    else
        1 6 lshift SPI1_CR1 bis!
    then
;
\ SPIInit 
: SPIInit ( -- )
    rsSPEn \ enable clock to SPI from RSS
    gpAF \ configure alternate function on GPIO pins
    \ 0 spBR \ BR at 4MHz
    \ 1 spBR \ BR at 2MHz
    \ %010 spBR \ set 1 MHz baud rate
    \ 4 spBR \ BR at 250kHz
    5 spBR \ BR at 125kHz
    0 spMode \ set SPI to mode 0,0. This is the reset condition.
    \ 3 spMode \ set SPI to mode 1,1
    \ spBiDi \ SPI bidirectional mode
    \ spLSB \ set to MSB first. This is the reset condition.
    spMst \ configure SPI as master
    %0111 spBit \ set data transfer size to 8 bits %0111, (16-bit, %1111)
    spHwSS \ SPI hardware control of nSS pin
    \ spSSPls \ pulse nSS between transmissions
    spFiTh \ set SPI receive FIFO threshold for 8-bit data transfers
    0 cs \ chip select inactive
    1 spEn \ SPI enable
;

SPI1 $8 + constant SPI1_SR ( status register ) 
: txE? ( -- flag ) \ SPI transmit buffer empty?
    1 1 lshift SPI1_SR bit@
;
: rxNE? ( -- flag ) \ SPI receive buffer NOT empty?
    1 SPI1_SR bit@
;
SPI1 $C + constant SPI1_DR ( data register ) 
: wr ( b -- r )
    begin txE? until \ wait till tx buffer is empty
    SPI1_DR c!
    begin rxNE? until
    SPI1_DR c@
;
SPI1 $8 + constant SPI1_SR ( status register ) 
: bsy? ( -- flag )
    1 7 lshift SPI1_SR bit@
;
\ PWr writes potentiometer register
: PWr ( b1 b2 --  ) \ write 16-bit command
    swap
    1 cs
    2 0 do
        wr drop
    loop
    begin bsy? not until
    10000 0 do i drop loop \ wait for non-volatile write to complete
    0 cs
;

\ PRd reads potentiometer register
: PRd ( b -- r1 r2 )
    4 lshift
    $f or \ make $0b to $bf

    1 cs
    wr

    $ff wr
    begin bsy? not until
    0 cs
;
: Stat ( -- StatusBits )
    binary
    5 PRd . drop
    decimal
;
: Set ( n -- ) \ set volatile wiper
    0 swap
    PWr
;
: NVSet ( n -- ) \ set non-volatile wiper
    2 swap
    PWr
;
compiletoram

\ main
SPIInit
\ 63 PWr \ set wiper to position 63'rd of 128 steps 
\ PRd .
