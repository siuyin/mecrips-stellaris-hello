\ Program Name: f0-disco-48mhz.fs
\ This program is standalone, no other files are needed
\ Date: Sat Apr 28 08:56:40 AEST 2018
\ Copyright 2018  t.porter <terry@tjporter.com.au>, licensed under the GPL
\ For Mecrisp-Stellaris by Matthias Koch.
\ https://sourceforge.net/projects/mecrisp/
\ Chip: STM32F051, Board: STM32F0 Discovery Board
\ All register names are CMSIS-SVD compliant
\ This Program : Increases the System Clock to 48 MHz using the Xtal controlled oscillator from the
\ F0 Discovery Board SWD subsystem. Can be easily be changed to HSI, see RCC_CFGR_PLLSRC below
\ ---------------------------------------------------------------------------\

 \ compiletoflash   
 compiletoram

  $4001380C constant USART1_BRR ( Baud rate register ) 

 : FLASH_ACR_LATENCY ( %XXX -- )  0  lshift $40022000 ;	 ( LATENCY )
 : FLASH_ACR_PRFTBE %1  4  lshift $40022000 ;		 ( PRFTBE Prefetch buffer enable )
 : RCC_CR_HSEON %1  16  lshift $40021000 ;		 ( External High Speed clock  enable )
 : RCC_CR_HSERDY? %1  17  lshift $40021000 bit@ ;	 ( External High Speed clock ready  flag )
 : RCC_CFGR_PLLMUL ( %XXXX -- )  18  lshift $40021004 ;	 ( PLL Multiplication Factor )
 : RCC_CFGR_PLLSRC ( %XX -- )  15  lshift $40021004 ;	 ( PLL clock source: %10: HSE/PREDIV, 01: HSI/PREDIV  )
 : RCC_CR_PLLON %1  24  lshift $40021000 ;		 ( PLL enable )
 : RCC_CR_PLLRDY? %1  25  lshift $40021000 bit@ ;	 ( PLL clock ready flag )
 : RCC_CFGR_SW ( %XX -- )  0  lshift $40021004 ;	 ( System clock Switch: $10: PLL selected as system clock)
 : RCC_CFGR_PPRE ( %XXX -- )  8  lshift $40021004  ;	 ( APB Low speed prescaler  APB1 )
 : RCC_CFGR_HPRE ( %XXXX -- )  4  lshift $40021004 ;	 ( AHB prescaler )

 : f0-disco-48mhz
 \ Set flash wait states to 1, turn on prefetch bit. One wait state, if 24 MHz < SYSCLK  48 MHz
 %001  FLASH_ACR_LATENCY bis! \ LATENCY --> max = 1 for the stm32f0, note more latency uses less power 
 FLASH_ACR_PRFTBE bis!
 
 \ Enable HSE oscillator  
 RCC_CR_HSEON bis!
 BEGIN  RCC_CR_HSERDY? UNTIL  \ Is HSE ready ?
  
 \ Set PLL multiplication factor to 6, clock is 8Mhz system clock
 %0100 RCC_CFGR_PLLMUL bis!   \ %0100: PLL input clock x 6
 %10 RCC_CFGR_PLLSRC bis!     \ %10: HSE/PREDIV, 01: HSI/PREDIV

 \ Enable PLL
 RCC_CR_PLLON bis!
 BEGIN RCC_CR_PLLRDY? UNTIL   \ Is PLL ready ?

 \ Switch to PLL, set ABP and AHB Prescalers
 %10 RCC_CFGR_SW bis!	      \ System clock Switch: %10 PLL selected as system clock
 %100  RCC_CFGR_PPRE bis!     \ APB Low speed prescaler APB1 (pclock): %100: HCLK divided by 2
 %0000 RCC_CFGR_HPRE bis!     \ AHB prescaler: 0xxx: SYSCLK not divided

 \ Update the Baud Rate Register so the serial comms is still 460800 Baud.
 \ ((pll_multiplier * clock)/Baud rate)/2 = ((6* 8000000)/460800)/2 = 52
 52 USART1_BRR !  \ for 115200 Baud change to 208
 ;

 f0-disco-48mhz

 compiletoram
