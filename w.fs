\ LED on PA5.

\ compiletoflash
compiletoram

$48000000 constant GPIOA		 
GPIOA $0 + constant GPIOA_MODER
GPIOA $18 + constant GPIOA_BSRR
\ GPIOA $28 + constant GPIOA_BRR


%01  10 lshift GPIOA_MODER bis!		\ PA5 is bit 10 on mode register

: half-second-delay 400000 0 do loop ;

: green-led.on   %1  5 lshift GPIOA_BSRR bis! ;	

: green-led.off  1 21 lshift GPIOA_BSRR bis! ; 
 
: blink		
    do
        green-led.on
        half-second-delay
        green-led.off
        half-second-delay
    loop
;	

#require list.fs
#require 1b.fs

$40021000 constant RCC ( Reset and clock control ) 
RCC $0 + constant RCC_CR ( Clock control register ) 
RCC $4 + constant RCC_CFGR ( Clock configuration register  RCC_CFGR ) 
RCC $8 + constant RCC_CIR ( Clock interrupt register  RCC_CIR ) 
RCC $C + constant RCC_APB2RSTR ( APB2 peripheral reset register  RCC_APB2RSTR ) 
RCC $10 + constant RCC_APB1RSTR ( APB1 peripheral reset register  RCC_APB1RSTR ) 
RCC $14 + constant RCC_AHBENR ( AHB Peripheral Clock enable register  RCC_AHBENR ) 
RCC $18 + constant RCC_APB2ENR ( APB2 peripheral clock enable register  RCC_APB2ENR ) 
RCC $1C + constant RCC_APB1ENR ( APB1 peripheral clock enable register  RCC_APB1ENR ) 
RCC $20 + constant RCC_BDCR ( Backup domain control register  RCC_BDCR ) 
RCC $24 + constant RCC_CSR ( Control/status register  RCC_CSR ) 
RCC $28 + constant RCC_AHBRSTR ( AHB peripheral reset register ) 
RCC $2C + constant RCC_CFGR2 ( Clock configuration register 2 ) 
RCC $30 + constant RCC_CFGR3 ( Clock configuration register 3 ) 
RCC $34 + constant RCC_CR2 ( Clock control register 2 ) 
: RCC_CR. cr ." RCC_CR () $" RCC_CR @ hex. RCC_CR 1b. ;
: RCC_CFGR. cr ." RCC_CFGR () $" RCC_CFGR @ hex. RCC_CFGR 1b. ;
: RCC_CIR. cr ." RCC_CIR () $" RCC_CIR @ hex. RCC_CIR 1b. ;
: RCC_APB2RSTR. cr ." RCC_APB2RSTR (read-write) $" RCC_APB2RSTR @ hex. RCC_APB2RSTR 1b. ;
: RCC_APB1RSTR. cr ." RCC_APB1RSTR (read-write) $" RCC_APB1RSTR @ hex. RCC_APB1RSTR 1b. ;
: RCC_AHBENR. cr ." RCC_AHBENR (read-write) $" RCC_AHBENR @ hex. RCC_AHBENR 1b. ;
: RCC_APB2ENR. cr ." RCC_APB2ENR (read-write) $" RCC_APB2ENR @ hex. RCC_APB2ENR 1b. ;
: RCC_APB1ENR. cr ." RCC_APB1ENR (read-write) $" RCC_APB1ENR @ hex. RCC_APB1ENR 1b. ;
: RCC_BDCR. cr ." RCC_BDCR () $" RCC_BDCR @ hex. RCC_BDCR 1b. ;
: RCC_CSR. cr ." RCC_CSR () $" RCC_CSR @ hex. RCC_CSR 1b. ;
: RCC_AHBRSTR. cr ." RCC_AHBRSTR (read-write) $" RCC_AHBRSTR @ hex. RCC_AHBRSTR 1b. ;
: RCC_CFGR2. cr ." RCC_CFGR2 (read-write) $" RCC_CFGR2 @ hex. RCC_CFGR2 1b. ;
: RCC_CFGR3. cr ." RCC_CFGR3 (read-write) $" RCC_CFGR3 @ hex. RCC_CFGR3 1b. ;
: RCC_CR2. cr ." RCC_CR2 () $" RCC_CR2 @ hex. RCC_CR2 1b. ;
: RCC.
RCC_CR.
RCC_CFGR.
RCC_CIR.
RCC_APB2RSTR.
RCC_APB1RSTR.
RCC_AHBENR.
RCC_APB2ENR.
RCC_APB1ENR.
RCC_BDCR.
RCC_CSR.
RCC_AHBRSTR.
RCC_CFGR2.
RCC_CFGR3.
RCC_CR2.
;

compiletoram
