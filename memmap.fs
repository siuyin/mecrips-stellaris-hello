\ TEMPLATE FILE for STM32F030
\ created by svdcutter for Mecrisp-Stellaris Forth by Matthias Koch
\ sdvcutter  takes a CMSIS-SVD file plus a hand edited config.xml file as input 
\ By Terry Porter "terry@tjporter.com.au", released under the GPL V2 Licence

 compiletoflash

\ available forth template words as selected by config.xml

$40023000 constant CRC ( cyclic redundancy check calculation  unit ) 
CRC $0 + constant CRC_DR ( Data register ) 
CRC $4 + constant CRC_IDR ( Independent data register ) 
CRC $8 + constant CRC_CR ( Control register ) 
CRC $C + constant CRC_INIT ( Initial CRC value ) 
: CRC_DR. cr ." CRC_DR (read-write) $" CRC_DR @ hex. CRC_DR 1b. ;
: CRC_IDR. cr ." CRC_IDR (read-write) $" CRC_IDR @ hex. CRC_IDR 1b. ;
: CRC_CR. cr ." CRC_CR (read-write) $" CRC_CR @ hex. CRC_CR 1b. ;
: CRC_INIT. cr ." CRC_INIT (read-write) $" CRC_INIT @ hex. CRC_INIT 1b. ;
: CRC.
CRC_DR.
CRC_IDR.
CRC_CR.
CRC_INIT.
;

$48001400 constant GPIOF ( General-purpose I/Os ) 
GPIOF $0 + constant GPIOF_MODER ( GPIO port mode register ) 
GPIOF $4 + constant GPIOF_OTYPER ( GPIO port output type register ) 
GPIOF $8 + constant GPIOF_OSPEEDR ( GPIO port output speed  register ) 
GPIOF $C + constant GPIOF_PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOF $10 + constant GPIOF_IDR ( GPIO port input data register ) 
GPIOF $14 + constant GPIOF_ODR ( GPIO port output data register ) 
GPIOF $18 + constant GPIOF_BSRR ( GPIO port bit set/reset  register ) 
GPIOF $1C + constant GPIOF_LCKR ( GPIO port configuration lock  register ) 
GPIOF $20 + constant GPIOF_AFRL ( GPIO alternate function low  register ) 
GPIOF $24 + constant GPIOF_AFRH ( GPIO alternate function high  register ) 
GPIOF $28 + constant GPIOF_BRR ( Port bit reset register ) 
: GPIOF_MODER. cr ." GPIOF_MODER (read-write) $" GPIOF_MODER @ hex. GPIOF_MODER 1b. ;
: GPIOF_OTYPER. cr ." GPIOF_OTYPER (read-write) $" GPIOF_OTYPER @ hex. GPIOF_OTYPER 1b. ;
: GPIOF_OSPEEDR. cr ." GPIOF_OSPEEDR (read-write) $" GPIOF_OSPEEDR @ hex. GPIOF_OSPEEDR 1b. ;
: GPIOF_PUPDR. cr ." GPIOF_PUPDR (read-write) $" GPIOF_PUPDR @ hex. GPIOF_PUPDR 1b. ;
: GPIOF_IDR. cr ." GPIOF_IDR (read-only) $" GPIOF_IDR @ hex. GPIOF_IDR 1b. ;
: GPIOF_ODR. cr ." GPIOF_ODR (read-write) $" GPIOF_ODR @ hex. GPIOF_ODR 1b. ;
: GPIOF_BSRR. cr ." GPIOF_BSRR (write-only) $" GPIOF_BSRR @ hex. GPIOF_BSRR 1b. ;
: GPIOF_LCKR. cr ." GPIOF_LCKR (read-write) $" GPIOF_LCKR @ hex. GPIOF_LCKR 1b. ;
: GPIOF_AFRL. cr ." GPIOF_AFRL (read-write) $" GPIOF_AFRL @ hex. GPIOF_AFRL 1b. ;
: GPIOF_AFRH. cr ." GPIOF_AFRH (read-write) $" GPIOF_AFRH @ hex. GPIOF_AFRH 1b. ;
: GPIOF_BRR. cr ." GPIOF_BRR (write-only) $" GPIOF_BRR @ hex. GPIOF_BRR 1b. ;
: GPIOF.
GPIOF_MODER.
GPIOF_OTYPER.
GPIOF_OSPEEDR.
GPIOF_PUPDR.
GPIOF_IDR.
GPIOF_ODR.
GPIOF_BSRR.
GPIOF_LCKR.
GPIOF_AFRL.
GPIOF_AFRH.
GPIOF_BRR.
;

$48000C00 constant GPIOD ( General-purpose I/Os ) 
GPIOD $0 + constant GPIOD_MODER ( GPIO port mode register ) 
GPIOD $4 + constant GPIOD_OTYPER ( GPIO port output type register ) 
GPIOD $8 + constant GPIOD_OSPEEDR ( GPIO port output speed  register ) 
GPIOD $C + constant GPIOD_PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOD $10 + constant GPIOD_IDR ( GPIO port input data register ) 
GPIOD $14 + constant GPIOD_ODR ( GPIO port output data register ) 
GPIOD $18 + constant GPIOD_BSRR ( GPIO port bit set/reset  register ) 
GPIOD $1C + constant GPIOD_LCKR ( GPIO port configuration lock  register ) 
GPIOD $20 + constant GPIOD_AFRL ( GPIO alternate function low  register ) 
GPIOD $24 + constant GPIOD_AFRH ( GPIO alternate function high  register ) 
GPIOD $28 + constant GPIOD_BRR ( Port bit reset register ) 
: GPIOD_MODER. cr ." GPIOD_MODER (read-write) $" GPIOD_MODER @ hex. GPIOD_MODER 1b. ;
: GPIOD_OTYPER. cr ." GPIOD_OTYPER (read-write) $" GPIOD_OTYPER @ hex. GPIOD_OTYPER 1b. ;
: GPIOD_OSPEEDR. cr ." GPIOD_OSPEEDR (read-write) $" GPIOD_OSPEEDR @ hex. GPIOD_OSPEEDR 1b. ;
: GPIOD_PUPDR. cr ." GPIOD_PUPDR (read-write) $" GPIOD_PUPDR @ hex. GPIOD_PUPDR 1b. ;
: GPIOD_IDR. cr ." GPIOD_IDR (read-only) $" GPIOD_IDR @ hex. GPIOD_IDR 1b. ;
: GPIOD_ODR. cr ." GPIOD_ODR (read-write) $" GPIOD_ODR @ hex. GPIOD_ODR 1b. ;
: GPIOD_BSRR. cr ." GPIOD_BSRR (write-only) $" GPIOD_BSRR @ hex. GPIOD_BSRR 1b. ;
: GPIOD_LCKR. cr ." GPIOD_LCKR (read-write) $" GPIOD_LCKR @ hex. GPIOD_LCKR 1b. ;
: GPIOD_AFRL. cr ." GPIOD_AFRL (read-write) $" GPIOD_AFRL @ hex. GPIOD_AFRL 1b. ;
: GPIOD_AFRH. cr ." GPIOD_AFRH (read-write) $" GPIOD_AFRH @ hex. GPIOD_AFRH 1b. ;
: GPIOD_BRR. cr ." GPIOD_BRR (write-only) $" GPIOD_BRR @ hex. GPIOD_BRR 1b. ;
: GPIOD.
GPIOD_MODER.
GPIOD_OTYPER.
GPIOD_OSPEEDR.
GPIOD_PUPDR.
GPIOD_IDR.
GPIOD_ODR.
GPIOD_BSRR.
GPIOD_LCKR.
GPIOD_AFRL.
GPIOD_AFRH.
GPIOD_BRR.
;

$48000800 constant GPIOC ( General-purpose I/Os ) 
GPIOC $0 + constant GPIOC_MODER ( GPIO port mode register ) 
GPIOC $4 + constant GPIOC_OTYPER ( GPIO port output type register ) 
GPIOC $8 + constant GPIOC_OSPEEDR ( GPIO port output speed  register ) 
GPIOC $C + constant GPIOC_PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOC $10 + constant GPIOC_IDR ( GPIO port input data register ) 
GPIOC $14 + constant GPIOC_ODR ( GPIO port output data register ) 
GPIOC $18 + constant GPIOC_BSRR ( GPIO port bit set/reset  register ) 
GPIOC $1C + constant GPIOC_LCKR ( GPIO port configuration lock  register ) 
GPIOC $20 + constant GPIOC_AFRL ( GPIO alternate function low  register ) 
GPIOC $24 + constant GPIOC_AFRH ( GPIO alternate function high  register ) 
GPIOC $28 + constant GPIOC_BRR ( Port bit reset register ) 
: GPIOC_MODER. cr ." GPIOC_MODER (read-write) $" GPIOC_MODER @ hex. GPIOC_MODER 1b. ;
: GPIOC_OTYPER. cr ." GPIOC_OTYPER (read-write) $" GPIOC_OTYPER @ hex. GPIOC_OTYPER 1b. ;
: GPIOC_OSPEEDR. cr ." GPIOC_OSPEEDR (read-write) $" GPIOC_OSPEEDR @ hex. GPIOC_OSPEEDR 1b. ;
: GPIOC_PUPDR. cr ." GPIOC_PUPDR (read-write) $" GPIOC_PUPDR @ hex. GPIOC_PUPDR 1b. ;
: GPIOC_IDR. cr ." GPIOC_IDR (read-only) $" GPIOC_IDR @ hex. GPIOC_IDR 1b. ;
: GPIOC_ODR. cr ." GPIOC_ODR (read-write) $" GPIOC_ODR @ hex. GPIOC_ODR 1b. ;
: GPIOC_BSRR. cr ." GPIOC_BSRR (write-only) $" GPIOC_BSRR @ hex. GPIOC_BSRR 1b. ;
: GPIOC_LCKR. cr ." GPIOC_LCKR (read-write) $" GPIOC_LCKR @ hex. GPIOC_LCKR 1b. ;
: GPIOC_AFRL. cr ." GPIOC_AFRL (read-write) $" GPIOC_AFRL @ hex. GPIOC_AFRL 1b. ;
: GPIOC_AFRH. cr ." GPIOC_AFRH (read-write) $" GPIOC_AFRH @ hex. GPIOC_AFRH 1b. ;
: GPIOC_BRR. cr ." GPIOC_BRR (write-only) $" GPIOC_BRR @ hex. GPIOC_BRR 1b. ;
: GPIOC.
GPIOC_MODER.
GPIOC_OTYPER.
GPIOC_OSPEEDR.
GPIOC_PUPDR.
GPIOC_IDR.
GPIOC_ODR.
GPIOC_BSRR.
GPIOC_LCKR.
GPIOC_AFRL.
GPIOC_AFRH.
GPIOC_BRR.
;

$48000400 constant GPIOB ( General-purpose I/Os ) 
GPIOB $0 + constant GPIOB_MODER ( GPIO port mode register ) 
GPIOB $4 + constant GPIOB_OTYPER ( GPIO port output type register ) 
GPIOB $8 + constant GPIOB_OSPEEDR ( GPIO port output speed  register ) 
GPIOB $C + constant GPIOB_PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOB $10 + constant GPIOB_IDR ( GPIO port input data register ) 
GPIOB $14 + constant GPIOB_ODR ( GPIO port output data register ) 
GPIOB $18 + constant GPIOB_BSRR ( GPIO port bit set/reset  register ) 
GPIOB $1C + constant GPIOB_LCKR ( GPIO port configuration lock  register ) 
GPIOB $20 + constant GPIOB_AFRL ( GPIO alternate function low  register ) 
GPIOB $24 + constant GPIOB_AFRH ( GPIO alternate function high  register ) 
GPIOB $28 + constant GPIOB_BRR ( Port bit reset register ) 
: GPIOB_MODER. cr ." GPIOB_MODER (read-write) $" GPIOB_MODER @ hex. GPIOB_MODER 1b. ;
: GPIOB_OTYPER. cr ." GPIOB_OTYPER (read-write) $" GPIOB_OTYPER @ hex. GPIOB_OTYPER 1b. ;
: GPIOB_OSPEEDR. cr ." GPIOB_OSPEEDR (read-write) $" GPIOB_OSPEEDR @ hex. GPIOB_OSPEEDR 1b. ;
: GPIOB_PUPDR. cr ." GPIOB_PUPDR (read-write) $" GPIOB_PUPDR @ hex. GPIOB_PUPDR 1b. ;
: GPIOB_IDR. cr ." GPIOB_IDR (read-only) $" GPIOB_IDR @ hex. GPIOB_IDR 1b. ;
: GPIOB_ODR. cr ." GPIOB_ODR (read-write) $" GPIOB_ODR @ hex. GPIOB_ODR 1b. ;
: GPIOB_BSRR. cr ." GPIOB_BSRR (write-only) $" GPIOB_BSRR @ hex. GPIOB_BSRR 1b. ;
: GPIOB_LCKR. cr ." GPIOB_LCKR (read-write) $" GPIOB_LCKR @ hex. GPIOB_LCKR 1b. ;
: GPIOB_AFRL. cr ." GPIOB_AFRL (read-write) $" GPIOB_AFRL @ hex. GPIOB_AFRL 1b. ;
: GPIOB_AFRH. cr ." GPIOB_AFRH (read-write) $" GPIOB_AFRH @ hex. GPIOB_AFRH 1b. ;
: GPIOB_BRR. cr ." GPIOB_BRR (write-only) $" GPIOB_BRR @ hex. GPIOB_BRR 1b. ;
: GPIOB.
GPIOB_MODER.
GPIOB_OTYPER.
GPIOB_OSPEEDR.
GPIOB_PUPDR.
GPIOB_IDR.
GPIOB_ODR.
GPIOB_BSRR.
GPIOB_LCKR.
GPIOB_AFRL.
GPIOB_AFRH.
GPIOB_BRR.
;

$48000000 constant GPIOA ( General-purpose I/Os ) 
GPIOA $0 + constant GPIOA_MODER ( GPIO port mode register ) 
GPIOA $4 + constant GPIOA_OTYPER ( GPIO port output type register ) 
GPIOA $8 + constant GPIOA_OSPEEDR ( GPIO port output speed  register ) 
GPIOA $C + constant GPIOA_PUPDR ( GPIO port pull-up/pull-down  register ) 
GPIOA $10 + constant GPIOA_IDR ( GPIO port input data register ) 
GPIOA $14 + constant GPIOA_ODR ( GPIO port output data register ) 
GPIOA $18 + constant GPIOA_BSRR ( GPIO port bit set/reset  register ) 
GPIOA $1C + constant GPIOA_LCKR ( GPIO port configuration lock  register ) 
GPIOA $20 + constant GPIOA_AFRL ( GPIO alternate function low  register ) 
GPIOA $24 + constant GPIOA_AFRH ( GPIO alternate function high  register ) 
GPIOA $28 + constant GPIOA_BRR ( Port bit reset register ) 
: GPIOA_MODER. cr ." GPIOA_MODER (read-write) $" GPIOA_MODER @ hex. GPIOA_MODER 1b. ;
: GPIOA_OTYPER. cr ." GPIOA_OTYPER (read-write) $" GPIOA_OTYPER @ hex. GPIOA_OTYPER 1b. ;
: GPIOA_OSPEEDR. cr ." GPIOA_OSPEEDR (read-write) $" GPIOA_OSPEEDR @ hex. GPIOA_OSPEEDR 1b. ;
: GPIOA_PUPDR. cr ." GPIOA_PUPDR (read-write) $" GPIOA_PUPDR @ hex. GPIOA_PUPDR 1b. ;
: GPIOA_IDR. cr ." GPIOA_IDR (read-only) $" GPIOA_IDR @ hex. GPIOA_IDR 1b. ;
: GPIOA_ODR. cr ." GPIOA_ODR (read-write) $" GPIOA_ODR @ hex. GPIOA_ODR 1b. ;
: GPIOA_BSRR. cr ." GPIOA_BSRR (write-only) $" GPIOA_BSRR @ hex. GPIOA_BSRR 1b. ;
: GPIOA_LCKR. cr ." GPIOA_LCKR (read-write) $" GPIOA_LCKR @ hex. GPIOA_LCKR 1b. ;
: GPIOA_AFRL. cr ." GPIOA_AFRL (read-write) $" GPIOA_AFRL @ hex. GPIOA_AFRL 1b. ;
: GPIOA_AFRH. cr ." GPIOA_AFRH (read-write) $" GPIOA_AFRH @ hex. GPIOA_AFRH 1b. ;
: GPIOA_BRR. cr ." GPIOA_BRR (write-only) $" GPIOA_BRR @ hex. GPIOA_BRR 1b. ;
: GPIOA.
GPIOA_MODER.
GPIOA_OTYPER.
GPIOA_OSPEEDR.
GPIOA_PUPDR.
GPIOA_IDR.
GPIOA_ODR.
GPIOA_BSRR.
GPIOA_LCKR.
GPIOA_AFRL.
GPIOA_AFRH.
GPIOA_BRR.
;

$40013000 constant SPI1 ( Serial peripheral interface ) 
SPI1 $0 + constant SPI1_CR1 ( control register 1 ) 
SPI1 $4 + constant SPI1_CR2 ( control register 2 ) 
SPI1 $8 + constant SPI1_SR ( status register ) 
SPI1 $C + constant SPI1_DR ( data register ) 
SPI1 $10 + constant SPI1_CRCPR ( CRC polynomial register ) 
SPI1 $14 + constant SPI1_RXCRCR ( RX CRC register ) 
SPI1 $18 + constant SPI1_TXCRCR ( TX CRC register ) 
SPI1 $1C + constant SPI1_I2SCFGR ( I2S configuration register ) 
SPI1 $20 + constant SPI1_I2SPR ( I2S prescaler register ) 
: SPI1_CR1. cr ." SPI1_CR1 (read-write) $" SPI1_CR1 @ hex. SPI1_CR1 1b. ;
: SPI1_CR2. cr ." SPI1_CR2 (read-write) $" SPI1_CR2 @ hex. SPI1_CR2 1b. ;
: SPI1_SR. cr ." SPI1_SR () $" SPI1_SR @ hex. SPI1_SR 1b. ;
: SPI1_DR. cr ." SPI1_DR (read-write) $" SPI1_DR @ hex. SPI1_DR 1b. ;
: SPI1_CRCPR. cr ." SPI1_CRCPR (read-write) $" SPI1_CRCPR @ hex. SPI1_CRCPR 1b. ;
: SPI1_RXCRCR. cr ." SPI1_RXCRCR (read-only) $" SPI1_RXCRCR @ hex. SPI1_RXCRCR 1b. ;
: SPI1_TXCRCR. cr ." SPI1_TXCRCR (read-only) $" SPI1_TXCRCR @ hex. SPI1_TXCRCR 1b. ;
: SPI1_I2SCFGR. cr ." SPI1_I2SCFGR (read-write) $" SPI1_I2SCFGR @ hex. SPI1_I2SCFGR 1b. ;
: SPI1_I2SPR. cr ." SPI1_I2SPR (read-write) $" SPI1_I2SPR @ hex. SPI1_I2SPR 1b. ;
: SPI1.
SPI1_CR1.
SPI1_CR2.
SPI1_SR.
SPI1_DR.
SPI1_CRCPR.
SPI1_RXCRCR.
SPI1_TXCRCR.
SPI1_I2SCFGR.
SPI1_I2SPR.
;

$40003800 constant SPI2 ( Serial peripheral interface ) 
SPI2 $0 + constant SPI2_CR1 ( control register 1 ) 
SPI2 $4 + constant SPI2_CR2 ( control register 2 ) 
SPI2 $8 + constant SPI2_SR ( status register ) 
SPI2 $C + constant SPI2_DR ( data register ) 
SPI2 $10 + constant SPI2_CRCPR ( CRC polynomial register ) 
SPI2 $14 + constant SPI2_RXCRCR ( RX CRC register ) 
SPI2 $18 + constant SPI2_TXCRCR ( TX CRC register ) 
SPI2 $1C + constant SPI2_I2SCFGR ( I2S configuration register ) 
SPI2 $20 + constant SPI2_I2SPR ( I2S prescaler register ) 
: SPI2_CR1. cr ." SPI2_CR1 (read-write) $" SPI2_CR1 @ hex. SPI2_CR1 1b. ;
: SPI2_CR2. cr ." SPI2_CR2 (read-write) $" SPI2_CR2 @ hex. SPI2_CR2 1b. ;
: SPI2_SR. cr ." SPI2_SR () $" SPI2_SR @ hex. SPI2_SR 1b. ;
: SPI2_DR. cr ." SPI2_DR (read-write) $" SPI2_DR @ hex. SPI2_DR 1b. ;
: SPI2_CRCPR. cr ." SPI2_CRCPR (read-write) $" SPI2_CRCPR @ hex. SPI2_CRCPR 1b. ;
: SPI2_RXCRCR. cr ." SPI2_RXCRCR (read-only) $" SPI2_RXCRCR @ hex. SPI2_RXCRCR 1b. ;
: SPI2_TXCRCR. cr ." SPI2_TXCRCR (read-only) $" SPI2_TXCRCR @ hex. SPI2_TXCRCR 1b. ;
: SPI2_I2SCFGR. cr ." SPI2_I2SCFGR (read-write) $" SPI2_I2SCFGR @ hex. SPI2_I2SCFGR 1b. ;
: SPI2_I2SPR. cr ." SPI2_I2SPR (read-write) $" SPI2_I2SPR @ hex. SPI2_I2SPR 1b. ;
: SPI2.
SPI2_CR1.
SPI2_CR2.
SPI2_SR.
SPI2_DR.
SPI2_CRCPR.
SPI2_RXCRCR.
SPI2_TXCRCR.
SPI2_I2SCFGR.
SPI2_I2SPR.
;

$40007000 constant PWR ( Power control ) 
PWR $0 + constant PWR_CR ( power control register ) 
PWR $4 + constant PWR_CSR ( power control/status register ) 
: PWR_CR. cr ." PWR_CR (read-write) $" PWR_CR @ hex. PWR_CR 1b. ;
: PWR_CSR. cr ." PWR_CSR () $" PWR_CSR @ hex. PWR_CSR 1b. ;
: PWR.
PWR_CR.
PWR_CSR.
;

$40005400 constant I2C1 ( Inter-integrated circuit ) 
I2C1 $0 + constant I2C1_CR1 ( Control register 1 ) 
I2C1 $4 + constant I2C1_CR2 ( Control register 2 ) 
I2C1 $8 + constant I2C1_OAR1 ( Own address register 1 ) 
I2C1 $C + constant I2C1_OAR2 ( Own address register 2 ) 
I2C1 $10 + constant I2C1_TIMINGR ( Timing register ) 
I2C1 $14 + constant I2C1_TIMEOUTR ( Status register 1 ) 
I2C1 $18 + constant I2C1_ISR ( Interrupt and Status register ) 
I2C1 $1C + constant I2C1_ICR ( Interrupt clear register ) 
I2C1 $20 + constant I2C1_PECR ( PEC register ) 
I2C1 $24 + constant I2C1_RXDR ( Receive data register ) 
I2C1 $28 + constant I2C1_TXDR ( Transmit data register ) 
: I2C1_CR1. cr ." I2C1_CR1 () $" I2C1_CR1 @ hex. I2C1_CR1 1b. ;
: I2C1_CR2. cr ." I2C1_CR2 (read-write) $" I2C1_CR2 @ hex. I2C1_CR2 1b. ;
: I2C1_OAR1. cr ." I2C1_OAR1 (read-write) $" I2C1_OAR1 @ hex. I2C1_OAR1 1b. ;
: I2C1_OAR2. cr ." I2C1_OAR2 (read-write) $" I2C1_OAR2 @ hex. I2C1_OAR2 1b. ;
: I2C1_TIMINGR. cr ." I2C1_TIMINGR (read-write) $" I2C1_TIMINGR @ hex. I2C1_TIMINGR 1b. ;
: I2C1_TIMEOUTR. cr ." I2C1_TIMEOUTR (read-write) $" I2C1_TIMEOUTR @ hex. I2C1_TIMEOUTR 1b. ;
: I2C1_ISR. cr ." I2C1_ISR () $" I2C1_ISR @ hex. I2C1_ISR 1b. ;
: I2C1_ICR. cr ." I2C1_ICR (write-only) $" I2C1_ICR @ hex. I2C1_ICR 1b. ;
: I2C1_PECR. cr ." I2C1_PECR (read-only) $" I2C1_PECR @ hex. I2C1_PECR 1b. ;
: I2C1_RXDR. cr ." I2C1_RXDR (read-only) $" I2C1_RXDR @ hex. I2C1_RXDR 1b. ;
: I2C1_TXDR. cr ." I2C1_TXDR (read-write) $" I2C1_TXDR @ hex. I2C1_TXDR 1b. ;
: I2C1.
I2C1_CR1.
I2C1_CR2.
I2C1_OAR1.
I2C1_OAR2.
I2C1_TIMINGR.
I2C1_TIMEOUTR.
I2C1_ISR.
I2C1_ICR.
I2C1_PECR.
I2C1_RXDR.
I2C1_TXDR.
;

$40005800 constant I2C2 ( Inter-integrated circuit ) 
I2C2 $0 + constant I2C2_CR1 ( Control register 1 ) 
I2C2 $4 + constant I2C2_CR2 ( Control register 2 ) 
I2C2 $8 + constant I2C2_OAR1 ( Own address register 1 ) 
I2C2 $C + constant I2C2_OAR2 ( Own address register 2 ) 
I2C2 $10 + constant I2C2_TIMINGR ( Timing register ) 
I2C2 $14 + constant I2C2_TIMEOUTR ( Status register 1 ) 
I2C2 $18 + constant I2C2_ISR ( Interrupt and Status register ) 
I2C2 $1C + constant I2C2_ICR ( Interrupt clear register ) 
I2C2 $20 + constant I2C2_PECR ( PEC register ) 
I2C2 $24 + constant I2C2_RXDR ( Receive data register ) 
I2C2 $28 + constant I2C2_TXDR ( Transmit data register ) 
: I2C2_CR1. cr ." I2C2_CR1 () $" I2C2_CR1 @ hex. I2C2_CR1 1b. ;
: I2C2_CR2. cr ." I2C2_CR2 (read-write) $" I2C2_CR2 @ hex. I2C2_CR2 1b. ;
: I2C2_OAR1. cr ." I2C2_OAR1 (read-write) $" I2C2_OAR1 @ hex. I2C2_OAR1 1b. ;
: I2C2_OAR2. cr ." I2C2_OAR2 (read-write) $" I2C2_OAR2 @ hex. I2C2_OAR2 1b. ;
: I2C2_TIMINGR. cr ." I2C2_TIMINGR (read-write) $" I2C2_TIMINGR @ hex. I2C2_TIMINGR 1b. ;
: I2C2_TIMEOUTR. cr ." I2C2_TIMEOUTR (read-write) $" I2C2_TIMEOUTR @ hex. I2C2_TIMEOUTR 1b. ;
: I2C2_ISR. cr ." I2C2_ISR () $" I2C2_ISR @ hex. I2C2_ISR 1b. ;
: I2C2_ICR. cr ." I2C2_ICR (write-only) $" I2C2_ICR @ hex. I2C2_ICR 1b. ;
: I2C2_PECR. cr ." I2C2_PECR (read-only) $" I2C2_PECR @ hex. I2C2_PECR 1b. ;
: I2C2_RXDR. cr ." I2C2_RXDR (read-only) $" I2C2_RXDR @ hex. I2C2_RXDR 1b. ;
: I2C2_TXDR. cr ." I2C2_TXDR (read-write) $" I2C2_TXDR @ hex. I2C2_TXDR 1b. ;
: I2C2.
I2C2_CR1.
I2C2_CR2.
I2C2_OAR1.
I2C2_OAR2.
I2C2_TIMINGR.
I2C2_TIMEOUTR.
I2C2_ISR.
I2C2_ICR.
I2C2_PECR.
I2C2_RXDR.
I2C2_TXDR.
;

$40003000 constant IWDG ( Independent watchdog ) 
IWDG $0 + constant IWDG_KR ( Key register ) 
IWDG $4 + constant IWDG_PR ( Prescaler register ) 
IWDG $8 + constant IWDG_RLR ( Reload register ) 
IWDG $C + constant IWDG_SR ( Status register ) 
IWDG $10 + constant IWDG_WINR ( Window register ) 
: IWDG_KR. cr ." IWDG_KR (write-only) $" IWDG_KR @ hex. IWDG_KR 1b. ;
: IWDG_PR. cr ." IWDG_PR (read-write) $" IWDG_PR @ hex. IWDG_PR 1b. ;
: IWDG_RLR. cr ." IWDG_RLR (read-write) $" IWDG_RLR @ hex. IWDG_RLR 1b. ;
: IWDG_SR. cr ." IWDG_SR (read-only) $" IWDG_SR @ hex. IWDG_SR 1b. ;
: IWDG_WINR. cr ." IWDG_WINR (read-write) $" IWDG_WINR @ hex. IWDG_WINR 1b. ;
: IWDG.
IWDG_KR.
IWDG_PR.
IWDG_RLR.
IWDG_SR.
IWDG_WINR.
;

$40002C00 constant WWDG ( Window watchdog ) 
WWDG $0 + constant WWDG_CR ( Control register ) 
WWDG $4 + constant WWDG_CFR ( Configuration register ) 
WWDG $8 + constant WWDG_SR ( Status register ) 
: WWDG_CR. cr ." WWDG_CR (read-write) $" WWDG_CR @ hex. WWDG_CR 1b. ;
: WWDG_CFR. cr ." WWDG_CFR (read-write) $" WWDG_CFR @ hex. WWDG_CFR 1b. ;
: WWDG_SR. cr ." WWDG_SR (read-write) $" WWDG_SR @ hex. WWDG_SR 1b. ;
: WWDG.
WWDG_CR.
WWDG_CFR.
WWDG_SR.
;

$40012C00 constant TIM1 ( Advanced-timers ) 
TIM1 $0 + constant TIM1_CR1 ( control register 1 ) 
TIM1 $4 + constant TIM1_CR2 ( control register 2 ) 
TIM1 $8 + constant TIM1_SMCR ( slave mode control register ) 
TIM1 $C + constant TIM1_DIER ( DMA/Interrupt enable register ) 
TIM1 $10 + constant TIM1_SR ( status register ) 
TIM1 $14 + constant TIM1_EGR ( event generation register ) 
TIM1 $18 + constant TIM1_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM1 $18 + constant TIM1_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM1 $1C + constant TIM1_CCMR2_Output ( capture/compare mode register output  mode ) 
TIM1 $1C + constant TIM1_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM1 $20 + constant TIM1_CCER ( capture/compare enable  register ) 
TIM1 $24 + constant TIM1_CNT ( counter ) 
TIM1 $28 + constant TIM1_PSC ( prescaler ) 
TIM1 $2C + constant TIM1_ARR ( auto-reload register ) 
TIM1 $30 + constant TIM1_RCR ( repetition counter register ) 
TIM1 $34 + constant TIM1_CCR1 ( capture/compare register 1 ) 
TIM1 $38 + constant TIM1_CCR2 ( capture/compare register 2 ) 
TIM1 $3C + constant TIM1_CCR3 ( capture/compare register 3 ) 
TIM1 $40 + constant TIM1_CCR4 ( capture/compare register 4 ) 
TIM1 $44 + constant TIM1_BDTR ( break and dead-time register ) 
TIM1 $48 + constant TIM1_DCR ( DMA control register ) 
TIM1 $4C + constant TIM1_DMAR ( DMA address for full transfer ) 
: TIM1_CR1. cr ." TIM1_CR1 (read-write) $" TIM1_CR1 @ hex. TIM1_CR1 1b. ;
: TIM1_CR2. cr ." TIM1_CR2 (read-write) $" TIM1_CR2 @ hex. TIM1_CR2 1b. ;
: TIM1_SMCR. cr ." TIM1_SMCR (read-write) $" TIM1_SMCR @ hex. TIM1_SMCR 1b. ;
: TIM1_DIER. cr ." TIM1_DIER (read-write) $" TIM1_DIER @ hex. TIM1_DIER 1b. ;
: TIM1_SR. cr ." TIM1_SR (read-write) $" TIM1_SR @ hex. TIM1_SR 1b. ;
: TIM1_EGR. cr ." TIM1_EGR (write-only) $" TIM1_EGR @ hex. TIM1_EGR 1b. ;
: TIM1_CCMR1_Output. cr ." TIM1_CCMR1_Output (read-write) $" TIM1_CCMR1_Output @ hex. TIM1_CCMR1_Output 1b. ;
: TIM1_CCMR1_Input. cr ." TIM1_CCMR1_Input (read-write) $" TIM1_CCMR1_Input @ hex. TIM1_CCMR1_Input 1b. ;
: TIM1_CCMR2_Output. cr ." TIM1_CCMR2_Output (read-write) $" TIM1_CCMR2_Output @ hex. TIM1_CCMR2_Output 1b. ;
: TIM1_CCMR2_Input. cr ." TIM1_CCMR2_Input (read-write) $" TIM1_CCMR2_Input @ hex. TIM1_CCMR2_Input 1b. ;
: TIM1_CCER. cr ." TIM1_CCER (read-write) $" TIM1_CCER @ hex. TIM1_CCER 1b. ;
: TIM1_CNT. cr ." TIM1_CNT (read-write) $" TIM1_CNT @ hex. TIM1_CNT 1b. ;
: TIM1_PSC. cr ." TIM1_PSC (read-write) $" TIM1_PSC @ hex. TIM1_PSC 1b. ;
: TIM1_ARR. cr ." TIM1_ARR (read-write) $" TIM1_ARR @ hex. TIM1_ARR 1b. ;
: TIM1_RCR. cr ." TIM1_RCR (read-write) $" TIM1_RCR @ hex. TIM1_RCR 1b. ;
: TIM1_CCR1. cr ." TIM1_CCR1 (read-write) $" TIM1_CCR1 @ hex. TIM1_CCR1 1b. ;
: TIM1_CCR2. cr ." TIM1_CCR2 (read-write) $" TIM1_CCR2 @ hex. TIM1_CCR2 1b. ;
: TIM1_CCR3. cr ." TIM1_CCR3 (read-write) $" TIM1_CCR3 @ hex. TIM1_CCR3 1b. ;
: TIM1_CCR4. cr ." TIM1_CCR4 (read-write) $" TIM1_CCR4 @ hex. TIM1_CCR4 1b. ;
: TIM1_BDTR. cr ." TIM1_BDTR (read-write) $" TIM1_BDTR @ hex. TIM1_BDTR 1b. ;
: TIM1_DCR. cr ." TIM1_DCR (read-write) $" TIM1_DCR @ hex. TIM1_DCR 1b. ;
: TIM1_DMAR. cr ." TIM1_DMAR (read-write) $" TIM1_DMAR @ hex. TIM1_DMAR 1b. ;
: TIM1.
TIM1_CR1.
TIM1_CR2.
TIM1_SMCR.
TIM1_DIER.
TIM1_SR.
TIM1_EGR.
TIM1_CCMR1_Output.
TIM1_CCMR1_Input.
TIM1_CCMR2_Output.
TIM1_CCMR2_Input.
TIM1_CCER.
TIM1_CNT.
TIM1_PSC.
TIM1_ARR.
TIM1_RCR.
TIM1_CCR1.
TIM1_CCR2.
TIM1_CCR3.
TIM1_CCR4.
TIM1_BDTR.
TIM1_DCR.
TIM1_DMAR.
;

$40000400 constant TIM3 ( General-purpose-timers ) 
TIM3 $0 + constant TIM3_CR1 ( control register 1 ) 
TIM3 $4 + constant TIM3_CR2 ( control register 2 ) 
TIM3 $8 + constant TIM3_SMCR ( slave mode control register ) 
TIM3 $C + constant TIM3_DIER ( DMA/Interrupt enable register ) 
TIM3 $10 + constant TIM3_SR ( status register ) 
TIM3 $14 + constant TIM3_EGR ( event generation register ) 
TIM3 $18 + constant TIM3_CCMR1_Output ( capture/compare mode register 1 output  mode ) 
TIM3 $18 + constant TIM3_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM3 $1C + constant TIM3_CCMR2_Output ( capture/compare mode register 2 output  mode ) 
TIM3 $1C + constant TIM3_CCMR2_Input ( capture/compare mode register 2 input  mode ) 
TIM3 $20 + constant TIM3_CCER ( capture/compare enable  register ) 
TIM3 $24 + constant TIM3_CNT ( counter ) 
TIM3 $28 + constant TIM3_PSC ( prescaler ) 
TIM3 $2C + constant TIM3_ARR ( auto-reload register ) 
TIM3 $34 + constant TIM3_CCR1 ( capture/compare register 1 ) 
TIM3 $38 + constant TIM3_CCR2 ( capture/compare register 2 ) 
TIM3 $3C + constant TIM3_CCR3 ( capture/compare register 3 ) 
TIM3 $40 + constant TIM3_CCR4 ( capture/compare register 4 ) 
TIM3 $48 + constant TIM3_DCR ( DMA control register ) 
TIM3 $4C + constant TIM3_DMAR ( DMA address for full transfer ) 
: TIM3_CR1. cr ." TIM3_CR1 (read-write) $" TIM3_CR1 @ hex. TIM3_CR1 1b. ;
: TIM3_CR2. cr ." TIM3_CR2 (read-write) $" TIM3_CR2 @ hex. TIM3_CR2 1b. ;
: TIM3_SMCR. cr ." TIM3_SMCR (read-write) $" TIM3_SMCR @ hex. TIM3_SMCR 1b. ;
: TIM3_DIER. cr ." TIM3_DIER (read-write) $" TIM3_DIER @ hex. TIM3_DIER 1b. ;
: TIM3_SR. cr ." TIM3_SR (read-write) $" TIM3_SR @ hex. TIM3_SR 1b. ;
: TIM3_EGR. cr ." TIM3_EGR (write-only) $" TIM3_EGR @ hex. TIM3_EGR 1b. ;
: TIM3_CCMR1_Output. cr ." TIM3_CCMR1_Output (read-write) $" TIM3_CCMR1_Output @ hex. TIM3_CCMR1_Output 1b. ;
: TIM3_CCMR1_Input. cr ." TIM3_CCMR1_Input (read-write) $" TIM3_CCMR1_Input @ hex. TIM3_CCMR1_Input 1b. ;
: TIM3_CCMR2_Output. cr ." TIM3_CCMR2_Output (read-write) $" TIM3_CCMR2_Output @ hex. TIM3_CCMR2_Output 1b. ;
: TIM3_CCMR2_Input. cr ." TIM3_CCMR2_Input (read-write) $" TIM3_CCMR2_Input @ hex. TIM3_CCMR2_Input 1b. ;
: TIM3_CCER. cr ." TIM3_CCER (read-write) $" TIM3_CCER @ hex. TIM3_CCER 1b. ;
: TIM3_CNT. cr ." TIM3_CNT (read-write) $" TIM3_CNT @ hex. TIM3_CNT 1b. ;
: TIM3_PSC. cr ." TIM3_PSC (read-write) $" TIM3_PSC @ hex. TIM3_PSC 1b. ;
: TIM3_ARR. cr ." TIM3_ARR (read-write) $" TIM3_ARR @ hex. TIM3_ARR 1b. ;
: TIM3_CCR1. cr ." TIM3_CCR1 (read-write) $" TIM3_CCR1 @ hex. TIM3_CCR1 1b. ;
: TIM3_CCR2. cr ." TIM3_CCR2 (read-write) $" TIM3_CCR2 @ hex. TIM3_CCR2 1b. ;
: TIM3_CCR3. cr ." TIM3_CCR3 (read-write) $" TIM3_CCR3 @ hex. TIM3_CCR3 1b. ;
: TIM3_CCR4. cr ." TIM3_CCR4 (read-write) $" TIM3_CCR4 @ hex. TIM3_CCR4 1b. ;
: TIM3_DCR. cr ." TIM3_DCR (read-write) $" TIM3_DCR @ hex. TIM3_DCR 1b. ;
: TIM3_DMAR. cr ." TIM3_DMAR (read-write) $" TIM3_DMAR @ hex. TIM3_DMAR 1b. ;
: TIM3.
TIM3_CR1.
TIM3_CR2.
TIM3_SMCR.
TIM3_DIER.
TIM3_SR.
TIM3_EGR.
TIM3_CCMR1_Output.
TIM3_CCMR1_Input.
TIM3_CCMR2_Output.
TIM3_CCMR2_Input.
TIM3_CCER.
TIM3_CNT.
TIM3_PSC.
TIM3_ARR.
TIM3_CCR1.
TIM3_CCR2.
TIM3_CCR3.
TIM3_CCR4.
TIM3_DCR.
TIM3_DMAR.
;

$40002000 constant TIM14 ( General-purpose-timers ) 
TIM14 $0 + constant TIM14_CR1 ( control register 1 ) 
TIM14 $C + constant TIM14_DIER ( DMA/Interrupt enable register ) 
TIM14 $10 + constant TIM14_SR ( status register ) 
TIM14 $14 + constant TIM14_EGR ( event generation register ) 
TIM14 $18 + constant TIM14_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM14 $18 + constant TIM14_CCMR1_Input ( capture/compare mode register input  mode ) 
TIM14 $20 + constant TIM14_CCER ( capture/compare enable  register ) 
TIM14 $24 + constant TIM14_CNT ( counter ) 
TIM14 $28 + constant TIM14_PSC ( prescaler ) 
TIM14 $2C + constant TIM14_ARR ( auto-reload register ) 
TIM14 $34 + constant TIM14_CCR1 ( capture/compare register 1 ) 
TIM14 $50 + constant TIM14_OR ( option register ) 
: TIM14_CR1. cr ." TIM14_CR1 (read-write) $" TIM14_CR1 @ hex. TIM14_CR1 1b. ;
: TIM14_DIER. cr ." TIM14_DIER (read-write) $" TIM14_DIER @ hex. TIM14_DIER 1b. ;
: TIM14_SR. cr ." TIM14_SR (read-write) $" TIM14_SR @ hex. TIM14_SR 1b. ;
: TIM14_EGR. cr ." TIM14_EGR (write-only) $" TIM14_EGR @ hex. TIM14_EGR 1b. ;
: TIM14_CCMR1_Output. cr ." TIM14_CCMR1_Output (read-write) $" TIM14_CCMR1_Output @ hex. TIM14_CCMR1_Output 1b. ;
: TIM14_CCMR1_Input. cr ." TIM14_CCMR1_Input (read-write) $" TIM14_CCMR1_Input @ hex. TIM14_CCMR1_Input 1b. ;
: TIM14_CCER. cr ." TIM14_CCER (read-write) $" TIM14_CCER @ hex. TIM14_CCER 1b. ;
: TIM14_CNT. cr ." TIM14_CNT (read-write) $" TIM14_CNT @ hex. TIM14_CNT 1b. ;
: TIM14_PSC. cr ." TIM14_PSC (read-write) $" TIM14_PSC @ hex. TIM14_PSC 1b. ;
: TIM14_ARR. cr ." TIM14_ARR (read-write) $" TIM14_ARR @ hex. TIM14_ARR 1b. ;
: TIM14_CCR1. cr ." TIM14_CCR1 (read-write) $" TIM14_CCR1 @ hex. TIM14_CCR1 1b. ;
: TIM14_OR. cr ." TIM14_OR (read-write) $" TIM14_OR @ hex. TIM14_OR 1b. ;
: TIM14.
TIM14_CR1.
TIM14_DIER.
TIM14_SR.
TIM14_EGR.
TIM14_CCMR1_Output.
TIM14_CCMR1_Input.
TIM14_CCER.
TIM14_CNT.
TIM14_PSC.
TIM14_ARR.
TIM14_CCR1.
TIM14_OR.
;

$40001000 constant TIM6 ( Basic-timers ) 
TIM6 $0 + constant TIM6_CR1 ( control register 1 ) 
TIM6 $4 + constant TIM6_CR2 ( control register 2 ) 
TIM6 $C + constant TIM6_DIER ( DMA/Interrupt enable register ) 
TIM6 $10 + constant TIM6_SR ( status register ) 
TIM6 $14 + constant TIM6_EGR ( event generation register ) 
TIM6 $24 + constant TIM6_CNT ( counter ) 
TIM6 $28 + constant TIM6_PSC ( prescaler ) 
TIM6 $2C + constant TIM6_ARR ( auto-reload register ) 
: TIM6_CR1. cr ." TIM6_CR1 (read-write) $" TIM6_CR1 @ hex. TIM6_CR1 1b. ;
: TIM6_CR2. cr ." TIM6_CR2 (read-write) $" TIM6_CR2 @ hex. TIM6_CR2 1b. ;
: TIM6_DIER. cr ." TIM6_DIER (read-write) $" TIM6_DIER @ hex. TIM6_DIER 1b. ;
: TIM6_SR. cr ." TIM6_SR (read-write) $" TIM6_SR @ hex. TIM6_SR 1b. ;
: TIM6_EGR. cr ." TIM6_EGR (write-only) $" TIM6_EGR @ hex. TIM6_EGR 1b. ;
: TIM6_CNT. cr ." TIM6_CNT (read-write) $" TIM6_CNT @ hex. TIM6_CNT 1b. ;
: TIM6_PSC. cr ." TIM6_PSC (read-write) $" TIM6_PSC @ hex. TIM6_PSC 1b. ;
: TIM6_ARR. cr ." TIM6_ARR (read-write) $" TIM6_ARR @ hex. TIM6_ARR 1b. ;
: TIM6.
TIM6_CR1.
TIM6_CR2.
TIM6_DIER.
TIM6_SR.
TIM6_EGR.
TIM6_CNT.
TIM6_PSC.
TIM6_ARR.
;

$40010400 constant EXTI ( External interrupt/event  controller ) 
EXTI $0 + constant EXTI_IMR ( Interrupt mask register  EXTI_IMR ) 
EXTI $4 + constant EXTI_EMR ( Event mask register EXTI_EMR ) 
EXTI $8 + constant EXTI_RTSR ( Rising Trigger selection register  EXTI_RTSR ) 
EXTI $C + constant EXTI_FTSR ( Falling Trigger selection register  EXTI_FTSR ) 
EXTI $10 + constant EXTI_SWIER ( Software interrupt event register  EXTI_SWIER ) 
EXTI $14 + constant EXTI_PR ( Pending register EXTI_PR ) 
: EXTI_IMR. cr ." EXTI_IMR (read-write) $" EXTI_IMR @ hex. EXTI_IMR 1b. ;
: EXTI_EMR. cr ." EXTI_EMR (read-write) $" EXTI_EMR @ hex. EXTI_EMR 1b. ;
: EXTI_RTSR. cr ." EXTI_RTSR (read-write) $" EXTI_RTSR @ hex. EXTI_RTSR 1b. ;
: EXTI_FTSR. cr ." EXTI_FTSR (read-write) $" EXTI_FTSR @ hex. EXTI_FTSR 1b. ;
: EXTI_SWIER. cr ." EXTI_SWIER (read-write) $" EXTI_SWIER @ hex. EXTI_SWIER 1b. ;
: EXTI_PR. cr ." EXTI_PR (read-write) $" EXTI_PR @ hex. EXTI_PR 1b. ;
: EXTI.
EXTI_IMR.
EXTI_EMR.
EXTI_RTSR.
EXTI_FTSR.
EXTI_SWIER.
EXTI_PR.
;

$E000E100 constant NVIC ( Nested Vectored Interrupt  Controller ) 
NVIC $0 + constant NVIC_ISER ( Interrupt Set Enable Register ) 
NVIC $80 + constant NVIC_ICER ( Interrupt Clear Enable  Register ) 
NVIC $100 + constant NVIC_ISPR ( Interrupt Set-Pending Register ) 
NVIC $180 + constant NVIC_ICPR ( Interrupt Clear-Pending  Register ) 
NVIC $300 + constant NVIC_IPR0 ( Interrupt Priority Register 0 ) 
NVIC $304 + constant NVIC_IPR1 ( Interrupt Priority Register 1 ) 
NVIC $308 + constant NVIC_IPR2 ( Interrupt Priority Register 2 ) 
NVIC $30C + constant NVIC_IPR3 ( Interrupt Priority Register 3 ) 
NVIC $310 + constant NVIC_IPR4 ( Interrupt Priority Register 4 ) 
NVIC $314 + constant NVIC_IPR5 ( Interrupt Priority Register 5 ) 
NVIC $318 + constant NVIC_IPR6 ( Interrupt Priority Register 6 ) 
NVIC $31C + constant NVIC_IPR7 ( Interrupt Priority Register 7 ) 
: NVIC_ISER. cr ." NVIC_ISER (read-write) $" NVIC_ISER @ hex. NVIC_ISER 1b. ;
: NVIC_ICER. cr ." NVIC_ICER (read-write) $" NVIC_ICER @ hex. NVIC_ICER 1b. ;
: NVIC_ISPR. cr ." NVIC_ISPR (read-write) $" NVIC_ISPR @ hex. NVIC_ISPR 1b. ;
: NVIC_ICPR. cr ." NVIC_ICPR (read-write) $" NVIC_ICPR @ hex. NVIC_ICPR 1b. ;
: NVIC_IPR0. cr ." NVIC_IPR0 (read-write) $" NVIC_IPR0 @ hex. NVIC_IPR0 1b. ;
: NVIC_IPR1. cr ." NVIC_IPR1 (read-write) $" NVIC_IPR1 @ hex. NVIC_IPR1 1b. ;
: NVIC_IPR2. cr ." NVIC_IPR2 (read-write) $" NVIC_IPR2 @ hex. NVIC_IPR2 1b. ;
: NVIC_IPR3. cr ." NVIC_IPR3 (read-write) $" NVIC_IPR3 @ hex. NVIC_IPR3 1b. ;
: NVIC_IPR4. cr ." NVIC_IPR4 (read-write) $" NVIC_IPR4 @ hex. NVIC_IPR4 1b. ;
: NVIC_IPR5. cr ." NVIC_IPR5 (read-write) $" NVIC_IPR5 @ hex. NVIC_IPR5 1b. ;
: NVIC_IPR6. cr ." NVIC_IPR6 (read-write) $" NVIC_IPR6 @ hex. NVIC_IPR6 1b. ;
: NVIC_IPR7. cr ." NVIC_IPR7 (read-write) $" NVIC_IPR7 @ hex. NVIC_IPR7 1b. ;
: NVIC.
NVIC_ISER.
NVIC_ICER.
NVIC_ISPR.
NVIC_ICPR.
NVIC_IPR0.
NVIC_IPR1.
NVIC_IPR2.
NVIC_IPR3.
NVIC_IPR4.
NVIC_IPR5.
NVIC_IPR6.
NVIC_IPR7.
;

$40020000 constant DMA ( DMA controller ) 
DMA $0 + constant DMA_ISR ( DMA interrupt status register  DMA_ISR ) 
DMA $4 + constant DMA_IFCR ( DMA interrupt flag clear register  DMA_IFCR ) 
DMA $8 + constant DMA_CCR1 ( DMA channel configuration register  DMA_CCR ) 
DMA $C + constant DMA_CNDTR1 ( DMA channel 1 number of data  register ) 
DMA $10 + constant DMA_CPAR1 ( DMA channel 1 peripheral address  register ) 
DMA $14 + constant DMA_CMAR1 ( DMA channel 1 memory address  register ) 
DMA $1C + constant DMA_CCR2 ( DMA channel configuration register  DMA_CCR ) 
DMA $20 + constant DMA_CNDTR2 ( DMA channel 2 number of data  register ) 
DMA $24 + constant DMA_CPAR2 ( DMA channel 2 peripheral address  register ) 
DMA $28 + constant DMA_CMAR2 ( DMA channel 2 memory address  register ) 
DMA $30 + constant DMA_CCR3 ( DMA channel configuration register  DMA_CCR ) 
DMA $34 + constant DMA_CNDTR3 ( DMA channel 3 number of data  register ) 
DMA $38 + constant DMA_CPAR3 ( DMA channel 3 peripheral address  register ) 
DMA $3C + constant DMA_CMAR3 ( DMA channel 3 memory address  register ) 
DMA $44 + constant DMA_CCR4 ( DMA channel configuration register  DMA_CCR ) 
DMA $48 + constant DMA_CNDTR4 ( DMA channel 4 number of data  register ) 
DMA $4C + constant DMA_CPAR4 ( DMA channel 4 peripheral address  register ) 
DMA $50 + constant DMA_CMAR4 ( DMA channel 4 memory address  register ) 
DMA $58 + constant DMA_CCR5 ( DMA channel configuration register  DMA_CCR ) 
DMA $5C + constant DMA_CNDTR5 ( DMA channel 5 number of data  register ) 
DMA $60 + constant DMA_CPAR5 ( DMA channel 5 peripheral address  register ) 
DMA $64 + constant DMA_CMAR5 ( DMA channel 5 memory address  register ) 
DMA $6C + constant DMA_CCR6 ( DMA channel configuration register  DMA_CCR ) 
DMA $70 + constant DMA_CNDTR6 ( DMA channel 6 number of data  register ) 
DMA $74 + constant DMA_CPAR6 ( DMA channel 6 peripheral address  register ) 
DMA $78 + constant DMA_CMAR6 ( DMA channel 6 memory address  register ) 
DMA $80 + constant DMA_CCR7 ( DMA channel configuration register  DMA_CCR ) 
DMA $84 + constant DMA_CNDTR7 ( DMA channel 7 number of data  register ) 
DMA $88 + constant DMA_CPAR7 ( DMA channel 7 peripheral address  register ) 
DMA $8C + constant DMA_CMAR7 ( DMA channel 7 memory address  register ) 
: DMA_ISR. cr ." DMA_ISR (read-only) $" DMA_ISR @ hex. DMA_ISR 1b. ;
: DMA_IFCR. cr ." DMA_IFCR (write-only) $" DMA_IFCR @ hex. DMA_IFCR 1b. ;
: DMA_CCR1. cr ." DMA_CCR1 (read-write) $" DMA_CCR1 @ hex. DMA_CCR1 1b. ;
: DMA_CNDTR1. cr ." DMA_CNDTR1 (read-write) $" DMA_CNDTR1 @ hex. DMA_CNDTR1 1b. ;
: DMA_CPAR1. cr ." DMA_CPAR1 (read-write) $" DMA_CPAR1 @ hex. DMA_CPAR1 1b. ;
: DMA_CMAR1. cr ." DMA_CMAR1 (read-write) $" DMA_CMAR1 @ hex. DMA_CMAR1 1b. ;
: DMA_CCR2. cr ." DMA_CCR2 (read-write) $" DMA_CCR2 @ hex. DMA_CCR2 1b. ;
: DMA_CNDTR2. cr ." DMA_CNDTR2 (read-write) $" DMA_CNDTR2 @ hex. DMA_CNDTR2 1b. ;
: DMA_CPAR2. cr ." DMA_CPAR2 (read-write) $" DMA_CPAR2 @ hex. DMA_CPAR2 1b. ;
: DMA_CMAR2. cr ." DMA_CMAR2 (read-write) $" DMA_CMAR2 @ hex. DMA_CMAR2 1b. ;
: DMA_CCR3. cr ." DMA_CCR3 (read-write) $" DMA_CCR3 @ hex. DMA_CCR3 1b. ;
: DMA_CNDTR3. cr ." DMA_CNDTR3 (read-write) $" DMA_CNDTR3 @ hex. DMA_CNDTR3 1b. ;
: DMA_CPAR3. cr ." DMA_CPAR3 (read-write) $" DMA_CPAR3 @ hex. DMA_CPAR3 1b. ;
: DMA_CMAR3. cr ." DMA_CMAR3 (read-write) $" DMA_CMAR3 @ hex. DMA_CMAR3 1b. ;
: DMA_CCR4. cr ." DMA_CCR4 (read-write) $" DMA_CCR4 @ hex. DMA_CCR4 1b. ;
: DMA_CNDTR4. cr ." DMA_CNDTR4 (read-write) $" DMA_CNDTR4 @ hex. DMA_CNDTR4 1b. ;
: DMA_CPAR4. cr ." DMA_CPAR4 (read-write) $" DMA_CPAR4 @ hex. DMA_CPAR4 1b. ;
: DMA_CMAR4. cr ." DMA_CMAR4 (read-write) $" DMA_CMAR4 @ hex. DMA_CMAR4 1b. ;
: DMA_CCR5. cr ." DMA_CCR5 (read-write) $" DMA_CCR5 @ hex. DMA_CCR5 1b. ;
: DMA_CNDTR5. cr ." DMA_CNDTR5 (read-write) $" DMA_CNDTR5 @ hex. DMA_CNDTR5 1b. ;
: DMA_CPAR5. cr ." DMA_CPAR5 (read-write) $" DMA_CPAR5 @ hex. DMA_CPAR5 1b. ;
: DMA_CMAR5. cr ." DMA_CMAR5 (read-write) $" DMA_CMAR5 @ hex. DMA_CMAR5 1b. ;
: DMA_CCR6. cr ." DMA_CCR6 (read-write) $" DMA_CCR6 @ hex. DMA_CCR6 1b. ;
: DMA_CNDTR6. cr ." DMA_CNDTR6 (read-write) $" DMA_CNDTR6 @ hex. DMA_CNDTR6 1b. ;
: DMA_CPAR6. cr ." DMA_CPAR6 (read-write) $" DMA_CPAR6 @ hex. DMA_CPAR6 1b. ;
: DMA_CMAR6. cr ." DMA_CMAR6 (read-write) $" DMA_CMAR6 @ hex. DMA_CMAR6 1b. ;
: DMA_CCR7. cr ." DMA_CCR7 (read-write) $" DMA_CCR7 @ hex. DMA_CCR7 1b. ;
: DMA_CNDTR7. cr ." DMA_CNDTR7 (read-write) $" DMA_CNDTR7 @ hex. DMA_CNDTR7 1b. ;
: DMA_CPAR7. cr ." DMA_CPAR7 (read-write) $" DMA_CPAR7 @ hex. DMA_CPAR7 1b. ;
: DMA_CMAR7. cr ." DMA_CMAR7 (read-write) $" DMA_CMAR7 @ hex. DMA_CMAR7 1b. ;
: DMA.
DMA_ISR.
DMA_IFCR.
DMA_CCR1.
DMA_CNDTR1.
DMA_CPAR1.
DMA_CMAR1.
DMA_CCR2.
DMA_CNDTR2.
DMA_CPAR2.
DMA_CMAR2.
DMA_CCR3.
DMA_CNDTR3.
DMA_CPAR3.
DMA_CMAR3.
DMA_CCR4.
DMA_CNDTR4.
DMA_CPAR4.
DMA_CMAR4.
DMA_CCR5.
DMA_CNDTR5.
DMA_CPAR5.
DMA_CMAR5.
DMA_CCR6.
DMA_CNDTR6.
DMA_CPAR6.
DMA_CMAR6.
DMA_CCR7.
DMA_CNDTR7.
DMA_CPAR7.
DMA_CMAR7.
;

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

$40010000 constant SYSCFG ( System configuration controller ) 
SYSCFG $0 + constant SYSCFG_CFGR1 ( configuration register 1 ) 
SYSCFG $8 + constant SYSCFG_EXTICR1 ( external interrupt configuration register  1 ) 
SYSCFG $C + constant SYSCFG_EXTICR2 ( external interrupt configuration register  2 ) 
SYSCFG $10 + constant SYSCFG_EXTICR3 ( external interrupt configuration register  3 ) 
SYSCFG $14 + constant SYSCFG_EXTICR4 ( external interrupt configuration register  4 ) 
SYSCFG $18 + constant SYSCFG_CFGR2 ( configuration register 2 ) 
: SYSCFG_CFGR1. cr ." SYSCFG_CFGR1 (read-write) $" SYSCFG_CFGR1 @ hex. SYSCFG_CFGR1 1b. ;
: SYSCFG_EXTICR1. cr ." SYSCFG_EXTICR1 (read-write) $" SYSCFG_EXTICR1 @ hex. SYSCFG_EXTICR1 1b. ;
: SYSCFG_EXTICR2. cr ." SYSCFG_EXTICR2 (read-write) $" SYSCFG_EXTICR2 @ hex. SYSCFG_EXTICR2 1b. ;
: SYSCFG_EXTICR3. cr ." SYSCFG_EXTICR3 (read-write) $" SYSCFG_EXTICR3 @ hex. SYSCFG_EXTICR3 1b. ;
: SYSCFG_EXTICR4. cr ." SYSCFG_EXTICR4 (read-write) $" SYSCFG_EXTICR4 @ hex. SYSCFG_EXTICR4 1b. ;
: SYSCFG_CFGR2. cr ." SYSCFG_CFGR2 (read-write) $" SYSCFG_CFGR2 @ hex. SYSCFG_CFGR2 1b. ;
: SYSCFG.
SYSCFG_CFGR1.
SYSCFG_EXTICR1.
SYSCFG_EXTICR2.
SYSCFG_EXTICR3.
SYSCFG_EXTICR4.
SYSCFG_CFGR2.
;

$40012400 constant ADC ( Analog-to-digital converter ) 
ADC $0 + constant ADC_ISR ( interrupt and status register ) 
ADC $4 + constant ADC_IER ( interrupt enable register ) 
ADC $8 + constant ADC_CR ( control register ) 
ADC $C + constant ADC_CFGR1 ( configuration register 1 ) 
ADC $10 + constant ADC_CFGR2 ( configuration register 2 ) 
ADC $14 + constant ADC_SMPR ( sampling time register ) 
ADC $20 + constant ADC_TR ( watchdog threshold register ) 
ADC $28 + constant ADC_CHSELR ( channel selection register ) 
ADC $40 + constant ADC_DR ( data register ) 
ADC $308 + constant ADC_CCR ( common configuration register ) 
: ADC_ISR. cr ." ADC_ISR (read-write) $" ADC_ISR @ hex. ADC_ISR 1b. ;
: ADC_IER. cr ." ADC_IER (read-write) $" ADC_IER @ hex. ADC_IER 1b. ;
: ADC_CR. cr ." ADC_CR (read-write) $" ADC_CR @ hex. ADC_CR 1b. ;
: ADC_CFGR1. cr ." ADC_CFGR1 (read-write) $" ADC_CFGR1 @ hex. ADC_CFGR1 1b. ;
: ADC_CFGR2. cr ." ADC_CFGR2 (read-write) $" ADC_CFGR2 @ hex. ADC_CFGR2 1b. ;
: ADC_SMPR. cr ." ADC_SMPR (read-write) $" ADC_SMPR @ hex. ADC_SMPR 1b. ;
: ADC_TR. cr ." ADC_TR (read-write) $" ADC_TR @ hex. ADC_TR 1b. ;
: ADC_CHSELR. cr ." ADC_CHSELR (read-write) $" ADC_CHSELR @ hex. ADC_CHSELR 1b. ;
: ADC_DR. cr ." ADC_DR (read-only) $" ADC_DR @ hex. ADC_DR 1b. ;
: ADC_CCR. cr ." ADC_CCR (read-write) $" ADC_CCR @ hex. ADC_CCR 1b. ;
: ADC.
ADC_ISR.
ADC_IER.
ADC_CR.
ADC_CFGR1.
ADC_CFGR2.
ADC_SMPR.
ADC_TR.
ADC_CHSELR.
ADC_DR.
ADC_CCR.
;

$40013800 constant USART1 ( Universal synchronous asynchronous receiver  transmitter ) 
USART1 $0 + constant USART1_CR1 ( Control register 1 ) 
USART1 $4 + constant USART1_CR2 ( Control register 2 ) 
USART1 $8 + constant USART1_CR3 ( Control register 3 ) 
USART1 $C + constant USART1_BRR ( Baud rate register ) 
USART1 $10 + constant USART1_GTPR ( Guard time and prescaler  register ) 
USART1 $14 + constant USART1_RTOR ( Receiver timeout register ) 
USART1 $18 + constant USART1_RQR ( Request register ) 
USART1 $1C + constant USART1_ISR ( Interrupt & status  register ) 
USART1 $20 + constant USART1_ICR ( Interrupt flag clear register ) 
USART1 $24 + constant USART1_RDR ( Receive data register ) 
USART1 $28 + constant USART1_TDR ( Transmit data register ) 
: USART1_CR1. cr ." USART1_CR1 (read-write) $" USART1_CR1 @ hex. USART1_CR1 1b. ;
: USART1_CR2. cr ." USART1_CR2 (read-write) $" USART1_CR2 @ hex. USART1_CR2 1b. ;
: USART1_CR3. cr ." USART1_CR3 (read-write) $" USART1_CR3 @ hex. USART1_CR3 1b. ;
: USART1_BRR. cr ." USART1_BRR (read-write) $" USART1_BRR @ hex. USART1_BRR 1b. ;
: USART1_GTPR. cr ." USART1_GTPR (read-write) $" USART1_GTPR @ hex. USART1_GTPR 1b. ;
: USART1_RTOR. cr ." USART1_RTOR (read-write) $" USART1_RTOR @ hex. USART1_RTOR 1b. ;
: USART1_RQR. cr ." USART1_RQR (read-write) $" USART1_RQR @ hex. USART1_RQR 1b. ;
: USART1_ISR. cr ." USART1_ISR (read-only) $" USART1_ISR @ hex. USART1_ISR 1b. ;
: USART1_ICR. cr ." USART1_ICR (read-write) $" USART1_ICR @ hex. USART1_ICR 1b. ;
: USART1_RDR. cr ." USART1_RDR (read-only) $" USART1_RDR @ hex. USART1_RDR 1b. ;
: USART1_TDR. cr ." USART1_TDR (read-write) $" USART1_TDR @ hex. USART1_TDR 1b. ;
: USART1.
USART1_CR1.
USART1_CR2.
USART1_CR3.
USART1_BRR.
USART1_GTPR.
USART1_RTOR.
USART1_RQR.
USART1_ISR.
USART1_ICR.
USART1_RDR.
USART1_TDR.
;

$40004400 constant USART2 ( Universal synchronous asynchronous receiver  transmitter ) 
USART2 $0 + constant USART2_CR1 ( Control register 1 ) 
USART2 $4 + constant USART2_CR2 ( Control register 2 ) 
USART2 $8 + constant USART2_CR3 ( Control register 3 ) 
USART2 $C + constant USART2_BRR ( Baud rate register ) 
USART2 $10 + constant USART2_GTPR ( Guard time and prescaler  register ) 
USART2 $14 + constant USART2_RTOR ( Receiver timeout register ) 
USART2 $18 + constant USART2_RQR ( Request register ) 
USART2 $1C + constant USART2_ISR ( Interrupt & status  register ) 
USART2 $20 + constant USART2_ICR ( Interrupt flag clear register ) 
USART2 $24 + constant USART2_RDR ( Receive data register ) 
USART2 $28 + constant USART2_TDR ( Transmit data register ) 
: USART2_CR1. cr ." USART2_CR1 (read-write) $" USART2_CR1 @ hex. USART2_CR1 1b. ;
: USART2_CR2. cr ." USART2_CR2 (read-write) $" USART2_CR2 @ hex. USART2_CR2 1b. ;
: USART2_CR3. cr ." USART2_CR3 (read-write) $" USART2_CR3 @ hex. USART2_CR3 1b. ;
: USART2_BRR. cr ." USART2_BRR (read-write) $" USART2_BRR @ hex. USART2_BRR 1b. ;
: USART2_GTPR. cr ." USART2_GTPR (read-write) $" USART2_GTPR @ hex. USART2_GTPR 1b. ;
: USART2_RTOR. cr ." USART2_RTOR (read-write) $" USART2_RTOR @ hex. USART2_RTOR 1b. ;
: USART2_RQR. cr ." USART2_RQR (read-write) $" USART2_RQR @ hex. USART2_RQR 1b. ;
: USART2_ISR. cr ." USART2_ISR (read-only) $" USART2_ISR @ hex. USART2_ISR 1b. ;
: USART2_ICR. cr ." USART2_ICR (read-write) $" USART2_ICR @ hex. USART2_ICR 1b. ;
: USART2_RDR. cr ." USART2_RDR (read-only) $" USART2_RDR @ hex. USART2_RDR 1b. ;
: USART2_TDR. cr ." USART2_TDR (read-write) $" USART2_TDR @ hex. USART2_TDR 1b. ;
: USART2.
USART2_CR1.
USART2_CR2.
USART2_CR3.
USART2_BRR.
USART2_GTPR.
USART2_RTOR.
USART2_RQR.
USART2_ISR.
USART2_ICR.
USART2_RDR.
USART2_TDR.
;

$40002800 constant RTC ( Real-time clock ) 
RTC $0 + constant RTC_TR ( time register ) 
RTC $4 + constant RTC_DR ( date register ) 
RTC $8 + constant RTC_CR ( control register ) 
RTC $C + constant RTC_ISR ( initialization and status  register ) 
RTC $10 + constant RTC_PRER ( prescaler register ) 
RTC $1C + constant RTC_ALRMAR ( alarm A register ) 
RTC $24 + constant RTC_WPR ( write protection register ) 
RTC $28 + constant RTC_SSR ( sub second register ) 
RTC $2C + constant RTC_SHIFTR ( shift control register ) 
RTC $30 + constant RTC_TSTR ( timestamp time register ) 
RTC $34 + constant RTC_TSDR ( timestamp date register ) 
RTC $38 + constant RTC_TSSSR ( time-stamp sub second register ) 
RTC $3C + constant RTC_CALR ( calibration register ) 
RTC $40 + constant RTC_TAFCR ( tamper and alternate function configuration  register ) 
RTC $44 + constant RTC_ALRMASSR ( alarm A sub second register ) 
RTC $50 + constant RTC_BKP0R ( backup register ) 
RTC $54 + constant RTC_BKP1R ( backup register ) 
RTC $58 + constant RTC_BKP2R ( backup register ) 
RTC $5C + constant RTC_BKP3R ( backup register ) 
RTC $60 + constant RTC_BKP4R ( backup register ) 
: RTC_TR. cr ." RTC_TR (read-write) $" RTC_TR @ hex. RTC_TR 1b. ;
: RTC_DR. cr ." RTC_DR (read-write) $" RTC_DR @ hex. RTC_DR 1b. ;
: RTC_CR. cr ." RTC_CR () $" RTC_CR @ hex. RTC_CR 1b. ;
: RTC_ISR. cr ." RTC_ISR () $" RTC_ISR @ hex. RTC_ISR 1b. ;
: RTC_PRER. cr ." RTC_PRER (read-write) $" RTC_PRER @ hex. RTC_PRER 1b. ;
: RTC_ALRMAR. cr ." RTC_ALRMAR (read-write) $" RTC_ALRMAR @ hex. RTC_ALRMAR 1b. ;
: RTC_WPR. cr ." RTC_WPR (write-only) $" RTC_WPR @ hex. RTC_WPR 1b. ;
: RTC_SSR. cr ." RTC_SSR (read-only) $" RTC_SSR @ hex. RTC_SSR 1b. ;
: RTC_SHIFTR. cr ." RTC_SHIFTR (write-only) $" RTC_SHIFTR @ hex. RTC_SHIFTR 1b. ;
: RTC_TSTR. cr ." RTC_TSTR (read-only) $" RTC_TSTR @ hex. RTC_TSTR 1b. ;
: RTC_TSDR. cr ." RTC_TSDR (read-only) $" RTC_TSDR @ hex. RTC_TSDR 1b. ;
: RTC_TSSSR. cr ." RTC_TSSSR (read-only) $" RTC_TSSSR @ hex. RTC_TSSSR 1b. ;
: RTC_CALR. cr ." RTC_CALR (read-write) $" RTC_CALR @ hex. RTC_CALR 1b. ;
: RTC_TAFCR. cr ." RTC_TAFCR (read-write) $" RTC_TAFCR @ hex. RTC_TAFCR 1b. ;
: RTC_ALRMASSR. cr ." RTC_ALRMASSR (read-write) $" RTC_ALRMASSR @ hex. RTC_ALRMASSR 1b. ;
: RTC_BKP0R. cr ." RTC_BKP0R (read-write) $" RTC_BKP0R @ hex. RTC_BKP0R 1b. ;
: RTC_BKP1R. cr ." RTC_BKP1R (read-write) $" RTC_BKP1R @ hex. RTC_BKP1R 1b. ;
: RTC_BKP2R. cr ." RTC_BKP2R (read-write) $" RTC_BKP2R @ hex. RTC_BKP2R 1b. ;
: RTC_BKP3R. cr ." RTC_BKP3R (read-write) $" RTC_BKP3R @ hex. RTC_BKP3R 1b. ;
: RTC_BKP4R. cr ." RTC_BKP4R (read-write) $" RTC_BKP4R @ hex. RTC_BKP4R 1b. ;
: RTC.
RTC_TR.
RTC_DR.
RTC_CR.
RTC_ISR.
RTC_PRER.
RTC_ALRMAR.
RTC_WPR.
RTC_SSR.
RTC_SHIFTR.
RTC_TSTR.
RTC_TSDR.
RTC_TSSSR.
RTC_CALR.
RTC_TAFCR.
RTC_ALRMASSR.
RTC_BKP0R.
RTC_BKP1R.
RTC_BKP2R.
RTC_BKP3R.
RTC_BKP4R.
;

$40014000 constant TIM15 ( General-purpose-timers ) 
TIM15 $0 + constant TIM15_CR1 ( control register 1 ) 
TIM15 $4 + constant TIM15_CR2 ( control register 2 ) 
TIM15 $8 + constant TIM15_SMCR ( slave mode control register ) 
TIM15 $C + constant TIM15_DIER ( DMA/Interrupt enable register ) 
TIM15 $10 + constant TIM15_SR ( status register ) 
TIM15 $14 + constant TIM15_EGR ( event generation register ) 
TIM15 $18 + constant TIM15_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM15 $18 + constant TIM15_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM15 $20 + constant TIM15_CCER ( capture/compare enable  register ) 
TIM15 $24 + constant TIM15_CNT ( counter ) 
TIM15 $28 + constant TIM15_PSC ( prescaler ) 
TIM15 $2C + constant TIM15_ARR ( auto-reload register ) 
TIM15 $30 + constant TIM15_RCR ( repetition counter register ) 
TIM15 $34 + constant TIM15_CCR1 ( capture/compare register 1 ) 
TIM15 $38 + constant TIM15_CCR2 ( capture/compare register 2 ) 
TIM15 $44 + constant TIM15_BDTR ( break and dead-time register ) 
TIM15 $48 + constant TIM15_DCR ( DMA control register ) 
TIM15 $4C + constant TIM15_DMAR ( DMA address for full transfer ) 
: TIM15_CR1. cr ." TIM15_CR1 (read-write) $" TIM15_CR1 @ hex. TIM15_CR1 1b. ;
: TIM15_CR2. cr ." TIM15_CR2 (read-write) $" TIM15_CR2 @ hex. TIM15_CR2 1b. ;
: TIM15_SMCR. cr ." TIM15_SMCR (read-write) $" TIM15_SMCR @ hex. TIM15_SMCR 1b. ;
: TIM15_DIER. cr ." TIM15_DIER (read-write) $" TIM15_DIER @ hex. TIM15_DIER 1b. ;
: TIM15_SR. cr ." TIM15_SR (read-write) $" TIM15_SR @ hex. TIM15_SR 1b. ;
: TIM15_EGR. cr ." TIM15_EGR (write-only) $" TIM15_EGR @ hex. TIM15_EGR 1b. ;
: TIM15_CCMR1_Output. cr ." TIM15_CCMR1_Output (read-write) $" TIM15_CCMR1_Output @ hex. TIM15_CCMR1_Output 1b. ;
: TIM15_CCMR1_Input. cr ." TIM15_CCMR1_Input (read-write) $" TIM15_CCMR1_Input @ hex. TIM15_CCMR1_Input 1b. ;
: TIM15_CCER. cr ." TIM15_CCER (read-write) $" TIM15_CCER @ hex. TIM15_CCER 1b. ;
: TIM15_CNT. cr ." TIM15_CNT (read-write) $" TIM15_CNT @ hex. TIM15_CNT 1b. ;
: TIM15_PSC. cr ." TIM15_PSC (read-write) $" TIM15_PSC @ hex. TIM15_PSC 1b. ;
: TIM15_ARR. cr ." TIM15_ARR (read-write) $" TIM15_ARR @ hex. TIM15_ARR 1b. ;
: TIM15_RCR. cr ." TIM15_RCR (read-write) $" TIM15_RCR @ hex. TIM15_RCR 1b. ;
: TIM15_CCR1. cr ." TIM15_CCR1 (read-write) $" TIM15_CCR1 @ hex. TIM15_CCR1 1b. ;
: TIM15_CCR2. cr ." TIM15_CCR2 (read-write) $" TIM15_CCR2 @ hex. TIM15_CCR2 1b. ;
: TIM15_BDTR. cr ." TIM15_BDTR (read-write) $" TIM15_BDTR @ hex. TIM15_BDTR 1b. ;
: TIM15_DCR. cr ." TIM15_DCR (read-write) $" TIM15_DCR @ hex. TIM15_DCR 1b. ;
: TIM15_DMAR. cr ." TIM15_DMAR (read-write) $" TIM15_DMAR @ hex. TIM15_DMAR 1b. ;
: TIM15.
TIM15_CR1.
TIM15_CR2.
TIM15_SMCR.
TIM15_DIER.
TIM15_SR.
TIM15_EGR.
TIM15_CCMR1_Output.
TIM15_CCMR1_Input.
TIM15_CCER.
TIM15_CNT.
TIM15_PSC.
TIM15_ARR.
TIM15_RCR.
TIM15_CCR1.
TIM15_CCR2.
TIM15_BDTR.
TIM15_DCR.
TIM15_DMAR.
;

$40014400 constant TIM16 ( General-purpose-timers ) 
TIM16 $0 + constant TIM16_CR1 ( control register 1 ) 
TIM16 $4 + constant TIM16_CR2 ( control register 2 ) 
TIM16 $C + constant TIM16_DIER ( DMA/Interrupt enable register ) 
TIM16 $10 + constant TIM16_SR ( status register ) 
TIM16 $14 + constant TIM16_EGR ( event generation register ) 
TIM16 $18 + constant TIM16_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM16 $18 + constant TIM16_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM16 $20 + constant TIM16_CCER ( capture/compare enable  register ) 
TIM16 $24 + constant TIM16_CNT ( counter ) 
TIM16 $28 + constant TIM16_PSC ( prescaler ) 
TIM16 $2C + constant TIM16_ARR ( auto-reload register ) 
TIM16 $30 + constant TIM16_RCR ( repetition counter register ) 
TIM16 $34 + constant TIM16_CCR1 ( capture/compare register 1 ) 
TIM16 $44 + constant TIM16_BDTR ( break and dead-time register ) 
TIM16 $48 + constant TIM16_DCR ( DMA control register ) 
TIM16 $4C + constant TIM16_DMAR ( DMA address for full transfer ) 
: TIM16_CR1. cr ." TIM16_CR1 (read-write) $" TIM16_CR1 @ hex. TIM16_CR1 1b. ;
: TIM16_CR2. cr ." TIM16_CR2 (read-write) $" TIM16_CR2 @ hex. TIM16_CR2 1b. ;
: TIM16_DIER. cr ." TIM16_DIER (read-write) $" TIM16_DIER @ hex. TIM16_DIER 1b. ;
: TIM16_SR. cr ." TIM16_SR (read-write) $" TIM16_SR @ hex. TIM16_SR 1b. ;
: TIM16_EGR. cr ." TIM16_EGR (write-only) $" TIM16_EGR @ hex. TIM16_EGR 1b. ;
: TIM16_CCMR1_Output. cr ." TIM16_CCMR1_Output (read-write) $" TIM16_CCMR1_Output @ hex. TIM16_CCMR1_Output 1b. ;
: TIM16_CCMR1_Input. cr ." TIM16_CCMR1_Input (read-write) $" TIM16_CCMR1_Input @ hex. TIM16_CCMR1_Input 1b. ;
: TIM16_CCER. cr ." TIM16_CCER (read-write) $" TIM16_CCER @ hex. TIM16_CCER 1b. ;
: TIM16_CNT. cr ." TIM16_CNT (read-write) $" TIM16_CNT @ hex. TIM16_CNT 1b. ;
: TIM16_PSC. cr ." TIM16_PSC (read-write) $" TIM16_PSC @ hex. TIM16_PSC 1b. ;
: TIM16_ARR. cr ." TIM16_ARR (read-write) $" TIM16_ARR @ hex. TIM16_ARR 1b. ;
: TIM16_RCR. cr ." TIM16_RCR (read-write) $" TIM16_RCR @ hex. TIM16_RCR 1b. ;
: TIM16_CCR1. cr ." TIM16_CCR1 (read-write) $" TIM16_CCR1 @ hex. TIM16_CCR1 1b. ;
: TIM16_BDTR. cr ." TIM16_BDTR (read-write) $" TIM16_BDTR @ hex. TIM16_BDTR 1b. ;
: TIM16_DCR. cr ." TIM16_DCR (read-write) $" TIM16_DCR @ hex. TIM16_DCR 1b. ;
: TIM16_DMAR. cr ." TIM16_DMAR (read-write) $" TIM16_DMAR @ hex. TIM16_DMAR 1b. ;
: TIM16.
TIM16_CR1.
TIM16_CR2.
TIM16_DIER.
TIM16_SR.
TIM16_EGR.
TIM16_CCMR1_Output.
TIM16_CCMR1_Input.
TIM16_CCER.
TIM16_CNT.
TIM16_PSC.
TIM16_ARR.
TIM16_RCR.
TIM16_CCR1.
TIM16_BDTR.
TIM16_DCR.
TIM16_DMAR.
;

$40014800 constant TIM17 ( General-purpose-timers ) 
TIM17 $0 + constant TIM17_CR1 ( control register 1 ) 
TIM17 $4 + constant TIM17_CR2 ( control register 2 ) 
TIM17 $C + constant TIM17_DIER ( DMA/Interrupt enable register ) 
TIM17 $10 + constant TIM17_SR ( status register ) 
TIM17 $14 + constant TIM17_EGR ( event generation register ) 
TIM17 $18 + constant TIM17_CCMR1_Output ( capture/compare mode register output  mode ) 
TIM17 $18 + constant TIM17_CCMR1_Input ( capture/compare mode register 1 input  mode ) 
TIM17 $20 + constant TIM17_CCER ( capture/compare enable  register ) 
TIM17 $24 + constant TIM17_CNT ( counter ) 
TIM17 $28 + constant TIM17_PSC ( prescaler ) 
TIM17 $2C + constant TIM17_ARR ( auto-reload register ) 
TIM17 $30 + constant TIM17_RCR ( repetition counter register ) 
TIM17 $34 + constant TIM17_CCR1 ( capture/compare register 1 ) 
TIM17 $44 + constant TIM17_BDTR ( break and dead-time register ) 
TIM17 $48 + constant TIM17_DCR ( DMA control register ) 
TIM17 $4C + constant TIM17_DMAR ( DMA address for full transfer ) 
: TIM17_CR1. cr ." TIM17_CR1 (read-write) $" TIM17_CR1 @ hex. TIM17_CR1 1b. ;
: TIM17_CR2. cr ." TIM17_CR2 (read-write) $" TIM17_CR2 @ hex. TIM17_CR2 1b. ;
: TIM17_DIER. cr ." TIM17_DIER (read-write) $" TIM17_DIER @ hex. TIM17_DIER 1b. ;
: TIM17_SR. cr ." TIM17_SR (read-write) $" TIM17_SR @ hex. TIM17_SR 1b. ;
: TIM17_EGR. cr ." TIM17_EGR (write-only) $" TIM17_EGR @ hex. TIM17_EGR 1b. ;
: TIM17_CCMR1_Output. cr ." TIM17_CCMR1_Output (read-write) $" TIM17_CCMR1_Output @ hex. TIM17_CCMR1_Output 1b. ;
: TIM17_CCMR1_Input. cr ." TIM17_CCMR1_Input (read-write) $" TIM17_CCMR1_Input @ hex. TIM17_CCMR1_Input 1b. ;
: TIM17_CCER. cr ." TIM17_CCER (read-write) $" TIM17_CCER @ hex. TIM17_CCER 1b. ;
: TIM17_CNT. cr ." TIM17_CNT (read-write) $" TIM17_CNT @ hex. TIM17_CNT 1b. ;
: TIM17_PSC. cr ." TIM17_PSC (read-write) $" TIM17_PSC @ hex. TIM17_PSC 1b. ;
: TIM17_ARR. cr ." TIM17_ARR (read-write) $" TIM17_ARR @ hex. TIM17_ARR 1b. ;
: TIM17_RCR. cr ." TIM17_RCR (read-write) $" TIM17_RCR @ hex. TIM17_RCR 1b. ;
: TIM17_CCR1. cr ." TIM17_CCR1 (read-write) $" TIM17_CCR1 @ hex. TIM17_CCR1 1b. ;
: TIM17_BDTR. cr ." TIM17_BDTR (read-write) $" TIM17_BDTR @ hex. TIM17_BDTR 1b. ;
: TIM17_DCR. cr ." TIM17_DCR (read-write) $" TIM17_DCR @ hex. TIM17_DCR 1b. ;
: TIM17_DMAR. cr ." TIM17_DMAR (read-write) $" TIM17_DMAR @ hex. TIM17_DMAR 1b. ;
: TIM17.
TIM17_CR1.
TIM17_CR2.
TIM17_DIER.
TIM17_SR.
TIM17_EGR.
TIM17_CCMR1_Output.
TIM17_CCMR1_Input.
TIM17_CCER.
TIM17_CNT.
TIM17_PSC.
TIM17_ARR.
TIM17_RCR.
TIM17_CCR1.
TIM17_BDTR.
TIM17_DCR.
TIM17_DMAR.
;

$40022000 constant Flash ( Flash ) 
Flash $0 + constant Flash_ACR ( Flash access control register ) 
Flash $4 + constant Flash_KEYR ( Flash key register ) 
Flash $8 + constant Flash_OPTKEYR ( Flash option key register ) 
Flash $C + constant Flash_SR ( Flash status register ) 
Flash $10 + constant Flash_CR ( Flash control register ) 
Flash $14 + constant Flash_AR ( Flash address register ) 
Flash $1C + constant Flash_OBR ( Option byte register ) 
Flash $20 + constant Flash_WRPR ( Write protection register ) 
: Flash_ACR. cr ." Flash_ACR () $" Flash_ACR @ hex. Flash_ACR 1b. ;
: Flash_KEYR. cr ." Flash_KEYR (write-only) $" Flash_KEYR @ hex. Flash_KEYR 1b. ;
: Flash_OPTKEYR. cr ." Flash_OPTKEYR (write-only) $" Flash_OPTKEYR @ hex. Flash_OPTKEYR 1b. ;
: Flash_SR. cr ." Flash_SR () $" Flash_SR @ hex. Flash_SR 1b. ;
: Flash_CR. cr ." Flash_CR (read-write) $" Flash_CR @ hex. Flash_CR 1b. ;
: Flash_AR. cr ." Flash_AR (write-only) $" Flash_AR @ hex. Flash_AR 1b. ;
: Flash_OBR. cr ." Flash_OBR (read-only) $" Flash_OBR @ hex. Flash_OBR 1b. ;
: Flash_WRPR. cr ." Flash_WRPR (read-only) $" Flash_WRPR @ hex. Flash_WRPR 1b. ;
: Flash.
Flash_ACR.
Flash_KEYR.
Flash_OPTKEYR.
Flash_SR.
Flash_CR.
Flash_AR.
Flash_OBR.
Flash_WRPR.
;

$40015800 constant DBGMCU ( Debug support ) 
DBGMCU $0 + constant DBGMCU_IDCODE ( MCU Device ID Code Register ) 
DBGMCU $4 + constant DBGMCU_CR ( Debug MCU Configuration  Register ) 
DBGMCU $8 + constant DBGMCU_APBLFZ ( APB Low Freeze Register ) 
DBGMCU $C + constant DBGMCU_APBHFZ ( APB High Freeze Register ) 
: DBGMCU_IDCODE. cr ." DBGMCU_IDCODE (read-only) $" DBGMCU_IDCODE @ hex. DBGMCU_IDCODE 1b. ;
: DBGMCU_CR. cr ." DBGMCU_CR (read-write) $" DBGMCU_CR @ hex. DBGMCU_CR 1b. ;
: DBGMCU_APBLFZ. cr ." DBGMCU_APBLFZ (read-write) $" DBGMCU_APBLFZ @ hex. DBGMCU_APBLFZ 1b. ;
: DBGMCU_APBHFZ. cr ." DBGMCU_APBHFZ (read-write) $" DBGMCU_APBHFZ @ hex. DBGMCU_APBHFZ 1b. ;
: DBGMCU.
DBGMCU_IDCODE.
DBGMCU_CR.
DBGMCU_APBLFZ.
DBGMCU_APBHFZ.
;


compiletoram
