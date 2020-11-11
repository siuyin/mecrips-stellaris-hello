\ clockspeed.fs controls clock speed on a STM32F030 running on its internal high speed oscillator.
\ set48MHz and set8MHz words defined.

compiletoflash

$40021000 constant RCC ( Reset and clock control ) 
RCC $4 + constant RCC_CFGR ( Clock configuration register  RCC_CFGR ) 
: 48MHzPLLMul ( -- ) \ set PLL multiplier to 12 for 8/2 * 12 = 48 MHz
    %1010 18 lshift RCC_CFGR bis! \ RM0360, 7.4.2, p103, PLLMUL
;

RCC $0 + constant RCC_CR ( Clock control register ) 
: pllOn ( -- ) \ turn on PLL
    1 24 lshift RCC_CR bis!
;
: pllOff ( -- ) \ turn OFF PLL
    1 24 lshift RCC_CR bic!
;

: usePLL ( -- ) \ switch clock source to PLL
    %10 RCC_CFGR bis! \ RM0360, 7.4.2, p105, SW
;
: useHSI ( -- ) \ switch clock source to 8MHz high speed internal oscillator
    %11 RCC_CFGR bic! \ RM0360, 7.4.2, p105, SW
;



$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $C + constant USART1_BRR ( Baud rate register ) 
: br8-115200 ( -- ) \ 115200 baud rate at 8MHz
    70 USART1_BRR ! \ 8e6/115200 = 70 approx.
;
: br48-115200 ( -- ) \ 115200 baud rate at 48MHz
    417 USART1_BRR ! \ 48e6/115200 = 417 approx.
;



: set48MHz ( -- ) \ set 48MHz for high speed, 23mA current consumption.
    48MHzPLLMul
    usePLL
    pllOn
    br48-115200
;

: set8MHz ( -- ) \ set 8MHz for optimized power consumption, 4.5mA.
    useHSI
    pllOff
    br8-115200
;

compiletoram
