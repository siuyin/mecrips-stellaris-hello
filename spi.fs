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
: gpAF ( -- ) \ configure alternate function on GPIO pins. PA 4,5 and 7 to alternate function mode
    %10 4 2* lshift GPIOA_MODER bis!
    %10 5 2* lshift GPIOA_MODER bis!
    %10 7 2* lshift GPIOA_MODER bis!
;
$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1_CR1 ( control register 1 ) 
: spBR ( n -- ) \ sets SPI baud rate: n=0,BR=PClk/2 ... n=7,BR=PClk/256. Divisor is 2^(n+1)
    3 lshift SPI1_CR1 bis!
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
: sp8bit ( -- ) \ set data transfer size to 8 bits
    %0111 8 lshift SPI1_CR2 bis!
;
: spHwSS ( -- ) \ SPI hardware control of nSS pin
    1 2 lshift SPI1_CR2 bis!
;
: spFiTh ( -- ) \ set SPI receive FIFO threshold for 8-bit data transfers
    1 12 lshift SPI1_CR2 bis!
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
    %010 spBR \ set baud rate
    \ spMode \ set SPI to mode 0,0. This is the reset condition.
    \ spBiDi \ SPI bidirectional mode
    \ spLSB \ set to MSB first. This is the reset condition.
    spMst \ configure SPI as master
    sp8bit \ set data transfer size to 8 bits
    spHwSS \ SPI hardware control of nSS pin
    spFiTh \ set SPI receive FIFO threshold for 8-bit data transfers
    1 spEn
;

SPI1 $8 + constant SPI1_SR ( status register ) 
: txE? ( -- flag ) \ SPI transmit buffer empty?
    1 1 lshift SPI1_SR bit@
;
: rxNE? ( -- flag ) \ SPI receive buffer NOT empty?
    1 SPI1_SR bit@
;

SPI1 $C + constant SPI1_DR ( data register ) 
\ WpSet sets wiper to position n
: WpSet ( h -- ) \ write 16-bit command
    begin txE? until \ wait till tx buffer is empty
    $ff and 8 lshift
    SPI1_DR h!
;
compiletoram

\ main
SPIInit
63 WpSet \ set wiper to position 63'rd of 128 steps 
