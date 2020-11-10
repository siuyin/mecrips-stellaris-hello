\ STM32F030 Register Bitfield Definitions for Mecrisp-Stellaris Forth by Matthias Koch. 
\ bitfield.xsl takes STM32Fxx.svd, config.xml and produces bitfield.fs
\ Written by Terry Porter "terry@tjporter.com.au" 2016 - 2018 and released under the GPL V2.
\ Replace 'bis!' (set bit) with 'bic!' to CLEAR bit, 'bit@' to test bit etc.


\ CRC_DR (read-write)
: CRC_DR_DR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC_DR bis! ;  \ CRC_DR_DR    Data register bits

\ CRC_IDR (read-write)
: CRC_IDR_IDR   ( %XXXXXXXX -- ) 0 lshift CRC_IDR bis! ;  \ CRC_IDR_IDR    General-purpose 8-bit data register  bits

\ CRC_CR (read-write)
: CRC_CR_RESET   %1 0 lshift CRC_CR bis! ;  \ CRC_CR_RESET    reset bit
: CRC_CR_REV_IN   ( %XX -- ) 5 lshift CRC_CR bis! ;  \ CRC_CR_REV_IN    Reverse input data
: CRC_CR_REV_OUT   %1 7 lshift CRC_CR bis! ;  \ CRC_CR_REV_OUT    Reverse output data

\ CRC_INIT (read-write)
: CRC_INIT_INIT   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift CRC_INIT bis! ;  \ CRC_INIT_INIT    Programmable initial CRC  value

\ GPIOF_MODER (read-write)
: GPIOF_MODER_MODER15   ( %XX -- ) 30 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER15    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER14   ( %XX -- ) 28 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER14    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER13   ( %XX -- ) 26 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER13    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER12   ( %XX -- ) 24 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER12    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER11   ( %XX -- ) 22 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER11    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER10   ( %XX -- ) 20 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER10    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER9   ( %XX -- ) 18 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER9    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER8   ( %XX -- ) 16 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER8    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER7   ( %XX -- ) 14 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER7    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER6   ( %XX -- ) 12 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER6    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER5   ( %XX -- ) 10 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER5    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER4   ( %XX -- ) 8 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER4    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER3   ( %XX -- ) 6 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER3    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER2   ( %XX -- ) 4 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER2    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER1   ( %XX -- ) 2 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER1    Port x configuration bits y =  0..15
: GPIOF_MODER_MODER0   ( %XX -- ) 0 lshift GPIOF_MODER bis! ;  \ GPIOF_MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOF_OTYPER (read-write)
: GPIOF_OTYPER_OT15   %1 15 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT15    Port x configuration bit  15
: GPIOF_OTYPER_OT14   %1 14 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT14    Port x configuration bit  14
: GPIOF_OTYPER_OT13   %1 13 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT13    Port x configuration bit  13
: GPIOF_OTYPER_OT12   %1 12 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT12    Port x configuration bit  12
: GPIOF_OTYPER_OT11   %1 11 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT11    Port x configuration bit  11
: GPIOF_OTYPER_OT10   %1 10 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT10    Port x configuration bit  10
: GPIOF_OTYPER_OT9   %1 9 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT9    Port x configuration bit 9
: GPIOF_OTYPER_OT8   %1 8 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT8    Port x configuration bit 8
: GPIOF_OTYPER_OT7   %1 7 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT7    Port x configuration bit 7
: GPIOF_OTYPER_OT6   %1 6 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT6    Port x configuration bit 6
: GPIOF_OTYPER_OT5   %1 5 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT5    Port x configuration bit 5
: GPIOF_OTYPER_OT4   %1 4 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT4    Port x configuration bit 4
: GPIOF_OTYPER_OT3   %1 3 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT3    Port x configuration bit 3
: GPIOF_OTYPER_OT2   %1 2 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT2    Port x configuration bit 2
: GPIOF_OTYPER_OT1   %1 1 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT1    Port x configuration bit 1
: GPIOF_OTYPER_OT0   %1 0 lshift GPIOF_OTYPER bis! ;  \ GPIOF_OTYPER_OT0    Port x configuration bit 0

\ GPIOF_OSPEEDR (read-write)
: GPIOF_OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR15    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR14    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR13    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR12    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR11    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR10    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR9    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR8    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR7    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR6    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR5    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR4    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR3    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR2    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR1    Port x configuration bits y =  0..15
: GPIOF_OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOF_OSPEEDR bis! ;  \ GPIOF_OSPEEDR_OSPEEDR0    Port x configuration bits y =  0..15

\ GPIOF_PUPDR (read-write)
: GPIOF_PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOF_PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOF_PUPDR bis! ;  \ GPIOF_PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOF_IDR (read-only)
: GPIOF_IDR_IDR15   %1 15 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR15    Port input data y =  0..15
: GPIOF_IDR_IDR14   %1 14 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR14    Port input data y =  0..15
: GPIOF_IDR_IDR13   %1 13 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR13    Port input data y =  0..15
: GPIOF_IDR_IDR12   %1 12 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR12    Port input data y =  0..15
: GPIOF_IDR_IDR11   %1 11 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR11    Port input data y =  0..15
: GPIOF_IDR_IDR10   %1 10 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR10    Port input data y =  0..15
: GPIOF_IDR_IDR9   %1 9 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR9    Port input data y =  0..15
: GPIOF_IDR_IDR8   %1 8 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR8    Port input data y =  0..15
: GPIOF_IDR_IDR7   %1 7 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR7    Port input data y =  0..15
: GPIOF_IDR_IDR6   %1 6 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR6    Port input data y =  0..15
: GPIOF_IDR_IDR5   %1 5 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR5    Port input data y =  0..15
: GPIOF_IDR_IDR4   %1 4 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR4    Port input data y =  0..15
: GPIOF_IDR_IDR3   %1 3 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR3    Port input data y =  0..15
: GPIOF_IDR_IDR2   %1 2 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR2    Port input data y =  0..15
: GPIOF_IDR_IDR1   %1 1 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR1    Port input data y =  0..15
: GPIOF_IDR_IDR0   %1 0 lshift GPIOF_IDR bis! ;  \ GPIOF_IDR_IDR0    Port input data y =  0..15

\ GPIOF_ODR (read-write)
: GPIOF_ODR_ODR15   %1 15 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR15    Port output data y =  0..15
: GPIOF_ODR_ODR14   %1 14 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR14    Port output data y =  0..15
: GPIOF_ODR_ODR13   %1 13 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR13    Port output data y =  0..15
: GPIOF_ODR_ODR12   %1 12 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR12    Port output data y =  0..15
: GPIOF_ODR_ODR11   %1 11 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR11    Port output data y =  0..15
: GPIOF_ODR_ODR10   %1 10 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR10    Port output data y =  0..15
: GPIOF_ODR_ODR9   %1 9 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR9    Port output data y =  0..15
: GPIOF_ODR_ODR8   %1 8 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR8    Port output data y =  0..15
: GPIOF_ODR_ODR7   %1 7 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR7    Port output data y =  0..15
: GPIOF_ODR_ODR6   %1 6 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR6    Port output data y =  0..15
: GPIOF_ODR_ODR5   %1 5 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR5    Port output data y =  0..15
: GPIOF_ODR_ODR4   %1 4 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR4    Port output data y =  0..15
: GPIOF_ODR_ODR3   %1 3 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR3    Port output data y =  0..15
: GPIOF_ODR_ODR2   %1 2 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR2    Port output data y =  0..15
: GPIOF_ODR_ODR1   %1 1 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR1    Port output data y =  0..15
: GPIOF_ODR_ODR0   %1 0 lshift GPIOF_ODR bis! ;  \ GPIOF_ODR_ODR0    Port output data y =  0..15

\ GPIOF_BSRR (write-only)
: GPIOF_BSRR_BR15   %1 31 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR15    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR14   %1 30 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR14    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR13   %1 29 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR13    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR12   %1 28 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR12    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR11   %1 27 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR11    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR10   %1 26 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR10    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR9   %1 25 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR9    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR8   %1 24 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR8    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR7   %1 23 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR7    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR6   %1 22 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR6    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR5   %1 21 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR5    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR4   %1 20 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR4    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR3   %1 19 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR3    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR2   %1 18 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR2    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR1   %1 17 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR1    Port x reset bit y y =  0..15
: GPIOF_BSRR_BR0   %1 16 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BR0    Port x set bit y y=  0..15
: GPIOF_BSRR_BS15   %1 15 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS15    Port x set bit y y=  0..15
: GPIOF_BSRR_BS14   %1 14 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS14    Port x set bit y y=  0..15
: GPIOF_BSRR_BS13   %1 13 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS13    Port x set bit y y=  0..15
: GPIOF_BSRR_BS12   %1 12 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS12    Port x set bit y y=  0..15
: GPIOF_BSRR_BS11   %1 11 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS11    Port x set bit y y=  0..15
: GPIOF_BSRR_BS10   %1 10 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS10    Port x set bit y y=  0..15
: GPIOF_BSRR_BS9   %1 9 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS9    Port x set bit y y=  0..15
: GPIOF_BSRR_BS8   %1 8 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS8    Port x set bit y y=  0..15
: GPIOF_BSRR_BS7   %1 7 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS7    Port x set bit y y=  0..15
: GPIOF_BSRR_BS6   %1 6 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS6    Port x set bit y y=  0..15
: GPIOF_BSRR_BS5   %1 5 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS5    Port x set bit y y=  0..15
: GPIOF_BSRR_BS4   %1 4 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS4    Port x set bit y y=  0..15
: GPIOF_BSRR_BS3   %1 3 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS3    Port x set bit y y=  0..15
: GPIOF_BSRR_BS2   %1 2 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS2    Port x set bit y y=  0..15
: GPIOF_BSRR_BS1   %1 1 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS1    Port x set bit y y=  0..15
: GPIOF_BSRR_BS0   %1 0 lshift GPIOF_BSRR bis! ;  \ GPIOF_BSRR_BS0    Port x set bit y y=  0..15

\ GPIOF_LCKR (read-write)
: GPIOF_LCKR_LCKK   %1 16 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCKK    Port x lock bit y
: GPIOF_LCKR_LCK15   %1 15 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK14   %1 14 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK13   %1 13 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK12   %1 12 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK11   %1 11 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK10   %1 10 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK9   %1 9 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK8   %1 8 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK7   %1 7 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK6   %1 6 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK5   %1 5 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK4   %1 4 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK3   %1 3 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK2   %1 2 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK1   %1 1 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOF_LCKR_LCK0   %1 0 lshift GPIOF_LCKR bis! ;  \ GPIOF_LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOF_AFRL (read-write)
: GPIOF_AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOF_AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOF_AFRL bis! ;  \ GPIOF_AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOF_AFRH (read-write)
: GPIOF_AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOF_AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOF_AFRH bis! ;  \ GPIOF_AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOF_BRR (write-only)
: GPIOF_BRR_BR0   %1 0 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR0    Port x Reset bit y
: GPIOF_BRR_BR1   %1 1 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR1    Port x Reset bit y
: GPIOF_BRR_BR2   %1 2 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR2    Port x Reset bit y
: GPIOF_BRR_BR3   %1 3 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR3    Port x Reset bit y
: GPIOF_BRR_BR4   %1 4 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR4    Port x Reset bit y
: GPIOF_BRR_BR5   %1 5 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR5    Port x Reset bit y
: GPIOF_BRR_BR6   %1 6 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR6    Port x Reset bit y
: GPIOF_BRR_BR7   %1 7 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR7    Port x Reset bit y
: GPIOF_BRR_BR8   %1 8 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR8    Port x Reset bit y
: GPIOF_BRR_BR9   %1 9 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR9    Port x Reset bit y
: GPIOF_BRR_BR10   %1 10 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR10    Port x Reset bit y
: GPIOF_BRR_BR11   %1 11 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR11    Port x Reset bit y
: GPIOF_BRR_BR12   %1 12 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR12    Port x Reset bit y
: GPIOF_BRR_BR13   %1 13 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR13    Port x Reset bit y
: GPIOF_BRR_BR14   %1 14 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR14    Port x Reset bit y
: GPIOF_BRR_BR15   %1 15 lshift GPIOF_BRR bis! ;  \ GPIOF_BRR_BR15    Port x Reset bit y

\ GPIOD_MODER (read-write)
: GPIOD_MODER_MODER15   ( %XX -- ) 30 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER15    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER14   ( %XX -- ) 28 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER14    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER13   ( %XX -- ) 26 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER13    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER12   ( %XX -- ) 24 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER12    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER11   ( %XX -- ) 22 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER11    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER10   ( %XX -- ) 20 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER10    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER9   ( %XX -- ) 18 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER9    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER8   ( %XX -- ) 16 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER8    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER7   ( %XX -- ) 14 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER7    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER6   ( %XX -- ) 12 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER6    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER5   ( %XX -- ) 10 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER5    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER4   ( %XX -- ) 8 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER4    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER3   ( %XX -- ) 6 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER3    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER2   ( %XX -- ) 4 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER2    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER1   ( %XX -- ) 2 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER1    Port x configuration bits y =  0..15
: GPIOD_MODER_MODER0   ( %XX -- ) 0 lshift GPIOD_MODER bis! ;  \ GPIOD_MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOD_OTYPER (read-write)
: GPIOD_OTYPER_OT15   %1 15 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT15    Port x configuration bit  15
: GPIOD_OTYPER_OT14   %1 14 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT14    Port x configuration bit  14
: GPIOD_OTYPER_OT13   %1 13 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT13    Port x configuration bit  13
: GPIOD_OTYPER_OT12   %1 12 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT12    Port x configuration bit  12
: GPIOD_OTYPER_OT11   %1 11 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT11    Port x configuration bit  11
: GPIOD_OTYPER_OT10   %1 10 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT10    Port x configuration bit  10
: GPIOD_OTYPER_OT9   %1 9 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT9    Port x configuration bit 9
: GPIOD_OTYPER_OT8   %1 8 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT8    Port x configuration bit 8
: GPIOD_OTYPER_OT7   %1 7 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT7    Port x configuration bit 7
: GPIOD_OTYPER_OT6   %1 6 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT6    Port x configuration bit 6
: GPIOD_OTYPER_OT5   %1 5 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT5    Port x configuration bit 5
: GPIOD_OTYPER_OT4   %1 4 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT4    Port x configuration bit 4
: GPIOD_OTYPER_OT3   %1 3 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT3    Port x configuration bit 3
: GPIOD_OTYPER_OT2   %1 2 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT2    Port x configuration bit 2
: GPIOD_OTYPER_OT1   %1 1 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT1    Port x configuration bit 1
: GPIOD_OTYPER_OT0   %1 0 lshift GPIOD_OTYPER bis! ;  \ GPIOD_OTYPER_OT0    Port x configuration bit 0

\ GPIOD_OSPEEDR (read-write)
: GPIOD_OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR15    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR14    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR13    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR12    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR11    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR10    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR9    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR8    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR7    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR6    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR5    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR4    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR3    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR2    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR1    Port x configuration bits y =  0..15
: GPIOD_OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOD_OSPEEDR bis! ;  \ GPIOD_OSPEEDR_OSPEEDR0    Port x configuration bits y =  0..15

\ GPIOD_PUPDR (read-write)
: GPIOD_PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOD_PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOD_PUPDR bis! ;  \ GPIOD_PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOD_IDR (read-only)
: GPIOD_IDR_IDR15   %1 15 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR15    Port input data y =  0..15
: GPIOD_IDR_IDR14   %1 14 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR14    Port input data y =  0..15
: GPIOD_IDR_IDR13   %1 13 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR13    Port input data y =  0..15
: GPIOD_IDR_IDR12   %1 12 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR12    Port input data y =  0..15
: GPIOD_IDR_IDR11   %1 11 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR11    Port input data y =  0..15
: GPIOD_IDR_IDR10   %1 10 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR10    Port input data y =  0..15
: GPIOD_IDR_IDR9   %1 9 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR9    Port input data y =  0..15
: GPIOD_IDR_IDR8   %1 8 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR8    Port input data y =  0..15
: GPIOD_IDR_IDR7   %1 7 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR7    Port input data y =  0..15
: GPIOD_IDR_IDR6   %1 6 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR6    Port input data y =  0..15
: GPIOD_IDR_IDR5   %1 5 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR5    Port input data y =  0..15
: GPIOD_IDR_IDR4   %1 4 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR4    Port input data y =  0..15
: GPIOD_IDR_IDR3   %1 3 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR3    Port input data y =  0..15
: GPIOD_IDR_IDR2   %1 2 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR2    Port input data y =  0..15
: GPIOD_IDR_IDR1   %1 1 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR1    Port input data y =  0..15
: GPIOD_IDR_IDR0   %1 0 lshift GPIOD_IDR bis! ;  \ GPIOD_IDR_IDR0    Port input data y =  0..15

\ GPIOD_ODR (read-write)
: GPIOD_ODR_ODR15   %1 15 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR15    Port output data y =  0..15
: GPIOD_ODR_ODR14   %1 14 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR14    Port output data y =  0..15
: GPIOD_ODR_ODR13   %1 13 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR13    Port output data y =  0..15
: GPIOD_ODR_ODR12   %1 12 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR12    Port output data y =  0..15
: GPIOD_ODR_ODR11   %1 11 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR11    Port output data y =  0..15
: GPIOD_ODR_ODR10   %1 10 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR10    Port output data y =  0..15
: GPIOD_ODR_ODR9   %1 9 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR9    Port output data y =  0..15
: GPIOD_ODR_ODR8   %1 8 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR8    Port output data y =  0..15
: GPIOD_ODR_ODR7   %1 7 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR7    Port output data y =  0..15
: GPIOD_ODR_ODR6   %1 6 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR6    Port output data y =  0..15
: GPIOD_ODR_ODR5   %1 5 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR5    Port output data y =  0..15
: GPIOD_ODR_ODR4   %1 4 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR4    Port output data y =  0..15
: GPIOD_ODR_ODR3   %1 3 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR3    Port output data y =  0..15
: GPIOD_ODR_ODR2   %1 2 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR2    Port output data y =  0..15
: GPIOD_ODR_ODR1   %1 1 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR1    Port output data y =  0..15
: GPIOD_ODR_ODR0   %1 0 lshift GPIOD_ODR bis! ;  \ GPIOD_ODR_ODR0    Port output data y =  0..15

\ GPIOD_BSRR (write-only)
: GPIOD_BSRR_BR15   %1 31 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR15    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR14   %1 30 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR14    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR13   %1 29 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR13    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR12   %1 28 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR12    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR11   %1 27 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR11    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR10   %1 26 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR10    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR9   %1 25 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR9    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR8   %1 24 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR8    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR7   %1 23 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR7    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR6   %1 22 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR6    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR5   %1 21 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR5    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR4   %1 20 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR4    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR3   %1 19 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR3    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR2   %1 18 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR2    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR1   %1 17 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR1    Port x reset bit y y =  0..15
: GPIOD_BSRR_BR0   %1 16 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BR0    Port x set bit y y=  0..15
: GPIOD_BSRR_BS15   %1 15 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS15    Port x set bit y y=  0..15
: GPIOD_BSRR_BS14   %1 14 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS14    Port x set bit y y=  0..15
: GPIOD_BSRR_BS13   %1 13 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS13    Port x set bit y y=  0..15
: GPIOD_BSRR_BS12   %1 12 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS12    Port x set bit y y=  0..15
: GPIOD_BSRR_BS11   %1 11 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS11    Port x set bit y y=  0..15
: GPIOD_BSRR_BS10   %1 10 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS10    Port x set bit y y=  0..15
: GPIOD_BSRR_BS9   %1 9 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS9    Port x set bit y y=  0..15
: GPIOD_BSRR_BS8   %1 8 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS8    Port x set bit y y=  0..15
: GPIOD_BSRR_BS7   %1 7 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS7    Port x set bit y y=  0..15
: GPIOD_BSRR_BS6   %1 6 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS6    Port x set bit y y=  0..15
: GPIOD_BSRR_BS5   %1 5 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS5    Port x set bit y y=  0..15
: GPIOD_BSRR_BS4   %1 4 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS4    Port x set bit y y=  0..15
: GPIOD_BSRR_BS3   %1 3 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS3    Port x set bit y y=  0..15
: GPIOD_BSRR_BS2   %1 2 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS2    Port x set bit y y=  0..15
: GPIOD_BSRR_BS1   %1 1 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS1    Port x set bit y y=  0..15
: GPIOD_BSRR_BS0   %1 0 lshift GPIOD_BSRR bis! ;  \ GPIOD_BSRR_BS0    Port x set bit y y=  0..15

\ GPIOD_LCKR (read-write)
: GPIOD_LCKR_LCKK   %1 16 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCKK    Port x lock bit y
: GPIOD_LCKR_LCK15   %1 15 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK14   %1 14 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK13   %1 13 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK12   %1 12 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK11   %1 11 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK10   %1 10 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK9   %1 9 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK8   %1 8 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK7   %1 7 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK6   %1 6 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK5   %1 5 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK4   %1 4 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK3   %1 3 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK2   %1 2 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK1   %1 1 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOD_LCKR_LCK0   %1 0 lshift GPIOD_LCKR bis! ;  \ GPIOD_LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOD_AFRL (read-write)
: GPIOD_AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOD_AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOD_AFRL bis! ;  \ GPIOD_AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOD_AFRH (read-write)
: GPIOD_AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOD_AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOD_AFRH bis! ;  \ GPIOD_AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOD_BRR (write-only)
: GPIOD_BRR_BR0   %1 0 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR0    Port x Reset bit y
: GPIOD_BRR_BR1   %1 1 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR1    Port x Reset bit y
: GPIOD_BRR_BR2   %1 2 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR2    Port x Reset bit y
: GPIOD_BRR_BR3   %1 3 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR3    Port x Reset bit y
: GPIOD_BRR_BR4   %1 4 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR4    Port x Reset bit y
: GPIOD_BRR_BR5   %1 5 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR5    Port x Reset bit y
: GPIOD_BRR_BR6   %1 6 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR6    Port x Reset bit y
: GPIOD_BRR_BR7   %1 7 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR7    Port x Reset bit y
: GPIOD_BRR_BR8   %1 8 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR8    Port x Reset bit y
: GPIOD_BRR_BR9   %1 9 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR9    Port x Reset bit y
: GPIOD_BRR_BR10   %1 10 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR10    Port x Reset bit y
: GPIOD_BRR_BR11   %1 11 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR11    Port x Reset bit y
: GPIOD_BRR_BR12   %1 12 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR12    Port x Reset bit y
: GPIOD_BRR_BR13   %1 13 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR13    Port x Reset bit y
: GPIOD_BRR_BR14   %1 14 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR14    Port x Reset bit y
: GPIOD_BRR_BR15   %1 15 lshift GPIOD_BRR bis! ;  \ GPIOD_BRR_BR15    Port x Reset bit y

\ GPIOC_MODER (read-write)
: GPIOC_MODER_MODER15   ( %XX -- ) 30 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER15    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER14   ( %XX -- ) 28 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER14    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER13   ( %XX -- ) 26 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER13    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER12   ( %XX -- ) 24 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER12    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER11   ( %XX -- ) 22 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER11    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER10   ( %XX -- ) 20 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER10    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER9   ( %XX -- ) 18 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER9    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER8   ( %XX -- ) 16 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER8    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER7   ( %XX -- ) 14 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER7    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER6   ( %XX -- ) 12 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER6    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER5   ( %XX -- ) 10 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER5    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER4   ( %XX -- ) 8 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER4    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER3   ( %XX -- ) 6 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER3    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER2   ( %XX -- ) 4 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER2    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER1   ( %XX -- ) 2 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER1    Port x configuration bits y =  0..15
: GPIOC_MODER_MODER0   ( %XX -- ) 0 lshift GPIOC_MODER bis! ;  \ GPIOC_MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOC_OTYPER (read-write)
: GPIOC_OTYPER_OT15   %1 15 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT15    Port x configuration bit  15
: GPIOC_OTYPER_OT14   %1 14 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT14    Port x configuration bit  14
: GPIOC_OTYPER_OT13   %1 13 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT13    Port x configuration bit  13
: GPIOC_OTYPER_OT12   %1 12 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT12    Port x configuration bit  12
: GPIOC_OTYPER_OT11   %1 11 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT11    Port x configuration bit  11
: GPIOC_OTYPER_OT10   %1 10 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT10    Port x configuration bit  10
: GPIOC_OTYPER_OT9   %1 9 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT9    Port x configuration bit 9
: GPIOC_OTYPER_OT8   %1 8 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT8    Port x configuration bit 8
: GPIOC_OTYPER_OT7   %1 7 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT7    Port x configuration bit 7
: GPIOC_OTYPER_OT6   %1 6 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT6    Port x configuration bit 6
: GPIOC_OTYPER_OT5   %1 5 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT5    Port x configuration bit 5
: GPIOC_OTYPER_OT4   %1 4 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT4    Port x configuration bit 4
: GPIOC_OTYPER_OT3   %1 3 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT3    Port x configuration bit 3
: GPIOC_OTYPER_OT2   %1 2 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT2    Port x configuration bit 2
: GPIOC_OTYPER_OT1   %1 1 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT1    Port x configuration bit 1
: GPIOC_OTYPER_OT0   %1 0 lshift GPIOC_OTYPER bis! ;  \ GPIOC_OTYPER_OT0    Port x configuration bit 0

\ GPIOC_OSPEEDR (read-write)
: GPIOC_OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR15    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR14    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR13    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR12    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR11    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR10    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR9    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR8    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR7    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR6    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR5    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR4    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR3    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR2    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR1    Port x configuration bits y =  0..15
: GPIOC_OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOC_OSPEEDR bis! ;  \ GPIOC_OSPEEDR_OSPEEDR0    Port x configuration bits y =  0..15

\ GPIOC_PUPDR (read-write)
: GPIOC_PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOC_PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOC_PUPDR bis! ;  \ GPIOC_PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOC_IDR (read-only)
: GPIOC_IDR_IDR15   %1 15 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR15    Port input data y =  0..15
: GPIOC_IDR_IDR14   %1 14 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR14    Port input data y =  0..15
: GPIOC_IDR_IDR13   %1 13 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR13    Port input data y =  0..15
: GPIOC_IDR_IDR12   %1 12 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR12    Port input data y =  0..15
: GPIOC_IDR_IDR11   %1 11 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR11    Port input data y =  0..15
: GPIOC_IDR_IDR10   %1 10 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR10    Port input data y =  0..15
: GPIOC_IDR_IDR9   %1 9 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR9    Port input data y =  0..15
: GPIOC_IDR_IDR8   %1 8 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR8    Port input data y =  0..15
: GPIOC_IDR_IDR7   %1 7 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR7    Port input data y =  0..15
: GPIOC_IDR_IDR6   %1 6 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR6    Port input data y =  0..15
: GPIOC_IDR_IDR5   %1 5 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR5    Port input data y =  0..15
: GPIOC_IDR_IDR4   %1 4 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR4    Port input data y =  0..15
: GPIOC_IDR_IDR3   %1 3 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR3    Port input data y =  0..15
: GPIOC_IDR_IDR2   %1 2 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR2    Port input data y =  0..15
: GPIOC_IDR_IDR1   %1 1 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR1    Port input data y =  0..15
: GPIOC_IDR_IDR0   %1 0 lshift GPIOC_IDR bis! ;  \ GPIOC_IDR_IDR0    Port input data y =  0..15

\ GPIOC_ODR (read-write)
: GPIOC_ODR_ODR15   %1 15 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR15    Port output data y =  0..15
: GPIOC_ODR_ODR14   %1 14 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR14    Port output data y =  0..15
: GPIOC_ODR_ODR13   %1 13 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR13    Port output data y =  0..15
: GPIOC_ODR_ODR12   %1 12 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR12    Port output data y =  0..15
: GPIOC_ODR_ODR11   %1 11 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR11    Port output data y =  0..15
: GPIOC_ODR_ODR10   %1 10 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR10    Port output data y =  0..15
: GPIOC_ODR_ODR9   %1 9 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR9    Port output data y =  0..15
: GPIOC_ODR_ODR8   %1 8 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR8    Port output data y =  0..15
: GPIOC_ODR_ODR7   %1 7 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR7    Port output data y =  0..15
: GPIOC_ODR_ODR6   %1 6 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR6    Port output data y =  0..15
: GPIOC_ODR_ODR5   %1 5 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR5    Port output data y =  0..15
: GPIOC_ODR_ODR4   %1 4 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR4    Port output data y =  0..15
: GPIOC_ODR_ODR3   %1 3 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR3    Port output data y =  0..15
: GPIOC_ODR_ODR2   %1 2 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR2    Port output data y =  0..15
: GPIOC_ODR_ODR1   %1 1 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR1    Port output data y =  0..15
: GPIOC_ODR_ODR0   %1 0 lshift GPIOC_ODR bis! ;  \ GPIOC_ODR_ODR0    Port output data y =  0..15

\ GPIOC_BSRR (write-only)
: GPIOC_BSRR_BR15   %1 31 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR15    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR14   %1 30 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR14    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR13   %1 29 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR13    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR12   %1 28 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR12    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR11   %1 27 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR11    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR10   %1 26 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR10    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR9   %1 25 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR9    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR8   %1 24 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR8    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR7   %1 23 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR7    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR6   %1 22 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR6    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR5   %1 21 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR5    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR4   %1 20 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR4    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR3   %1 19 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR3    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR2   %1 18 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR2    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR1   %1 17 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR1    Port x reset bit y y =  0..15
: GPIOC_BSRR_BR0   %1 16 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BR0    Port x set bit y y=  0..15
: GPIOC_BSRR_BS15   %1 15 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS15    Port x set bit y y=  0..15
: GPIOC_BSRR_BS14   %1 14 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS14    Port x set bit y y=  0..15
: GPIOC_BSRR_BS13   %1 13 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS13    Port x set bit y y=  0..15
: GPIOC_BSRR_BS12   %1 12 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS12    Port x set bit y y=  0..15
: GPIOC_BSRR_BS11   %1 11 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS11    Port x set bit y y=  0..15
: GPIOC_BSRR_BS10   %1 10 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS10    Port x set bit y y=  0..15
: GPIOC_BSRR_BS9   %1 9 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS9    Port x set bit y y=  0..15
: GPIOC_BSRR_BS8   %1 8 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS8    Port x set bit y y=  0..15
: GPIOC_BSRR_BS7   %1 7 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS7    Port x set bit y y=  0..15
: GPIOC_BSRR_BS6   %1 6 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS6    Port x set bit y y=  0..15
: GPIOC_BSRR_BS5   %1 5 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS5    Port x set bit y y=  0..15
: GPIOC_BSRR_BS4   %1 4 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS4    Port x set bit y y=  0..15
: GPIOC_BSRR_BS3   %1 3 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS3    Port x set bit y y=  0..15
: GPIOC_BSRR_BS2   %1 2 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS2    Port x set bit y y=  0..15
: GPIOC_BSRR_BS1   %1 1 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS1    Port x set bit y y=  0..15
: GPIOC_BSRR_BS0   %1 0 lshift GPIOC_BSRR bis! ;  \ GPIOC_BSRR_BS0    Port x set bit y y=  0..15

\ GPIOC_LCKR (read-write)
: GPIOC_LCKR_LCKK   %1 16 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCKK    Port x lock bit y
: GPIOC_LCKR_LCK15   %1 15 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK14   %1 14 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK13   %1 13 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK12   %1 12 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK11   %1 11 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK10   %1 10 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK9   %1 9 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK8   %1 8 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK7   %1 7 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK6   %1 6 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK5   %1 5 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK4   %1 4 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK3   %1 3 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK2   %1 2 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK1   %1 1 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOC_LCKR_LCK0   %1 0 lshift GPIOC_LCKR bis! ;  \ GPIOC_LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOC_AFRL (read-write)
: GPIOC_AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOC_AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOC_AFRL bis! ;  \ GPIOC_AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOC_AFRH (read-write)
: GPIOC_AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOC_AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOC_AFRH bis! ;  \ GPIOC_AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOC_BRR (write-only)
: GPIOC_BRR_BR0   %1 0 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR0    Port x Reset bit y
: GPIOC_BRR_BR1   %1 1 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR1    Port x Reset bit y
: GPIOC_BRR_BR2   %1 2 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR2    Port x Reset bit y
: GPIOC_BRR_BR3   %1 3 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR3    Port x Reset bit y
: GPIOC_BRR_BR4   %1 4 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR4    Port x Reset bit y
: GPIOC_BRR_BR5   %1 5 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR5    Port x Reset bit y
: GPIOC_BRR_BR6   %1 6 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR6    Port x Reset bit y
: GPIOC_BRR_BR7   %1 7 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR7    Port x Reset bit y
: GPIOC_BRR_BR8   %1 8 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR8    Port x Reset bit y
: GPIOC_BRR_BR9   %1 9 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR9    Port x Reset bit y
: GPIOC_BRR_BR10   %1 10 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR10    Port x Reset bit y
: GPIOC_BRR_BR11   %1 11 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR11    Port x Reset bit y
: GPIOC_BRR_BR12   %1 12 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR12    Port x Reset bit y
: GPIOC_BRR_BR13   %1 13 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR13    Port x Reset bit y
: GPIOC_BRR_BR14   %1 14 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR14    Port x Reset bit y
: GPIOC_BRR_BR15   %1 15 lshift GPIOC_BRR bis! ;  \ GPIOC_BRR_BR15    Port x Reset bit y

\ GPIOB_MODER (read-write)
: GPIOB_MODER_MODER15   ( %XX -- ) 30 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER15    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER14   ( %XX -- ) 28 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER14    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER13   ( %XX -- ) 26 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER13    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER12   ( %XX -- ) 24 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER12    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER11   ( %XX -- ) 22 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER11    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER10   ( %XX -- ) 20 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER10    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER9   ( %XX -- ) 18 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER9    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER8   ( %XX -- ) 16 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER8    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER7   ( %XX -- ) 14 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER7    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER6   ( %XX -- ) 12 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER6    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER5   ( %XX -- ) 10 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER5    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER4   ( %XX -- ) 8 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER4    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER3   ( %XX -- ) 6 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER3    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER2   ( %XX -- ) 4 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER2    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER1   ( %XX -- ) 2 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER1    Port x configuration bits y =  0..15
: GPIOB_MODER_MODER0   ( %XX -- ) 0 lshift GPIOB_MODER bis! ;  \ GPIOB_MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOB_OTYPER (read-write)
: GPIOB_OTYPER_OT15   %1 15 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT15    Port x configuration bit  15
: GPIOB_OTYPER_OT14   %1 14 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT14    Port x configuration bit  14
: GPIOB_OTYPER_OT13   %1 13 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT13    Port x configuration bit  13
: GPIOB_OTYPER_OT12   %1 12 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT12    Port x configuration bit  12
: GPIOB_OTYPER_OT11   %1 11 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT11    Port x configuration bit  11
: GPIOB_OTYPER_OT10   %1 10 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT10    Port x configuration bit  10
: GPIOB_OTYPER_OT9   %1 9 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT9    Port x configuration bit 9
: GPIOB_OTYPER_OT8   %1 8 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT8    Port x configuration bit 8
: GPIOB_OTYPER_OT7   %1 7 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT7    Port x configuration bit 7
: GPIOB_OTYPER_OT6   %1 6 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT6    Port x configuration bit 6
: GPIOB_OTYPER_OT5   %1 5 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT5    Port x configuration bit 5
: GPIOB_OTYPER_OT4   %1 4 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT4    Port x configuration bit 4
: GPIOB_OTYPER_OT3   %1 3 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT3    Port x configuration bit 3
: GPIOB_OTYPER_OT2   %1 2 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT2    Port x configuration bit 2
: GPIOB_OTYPER_OT1   %1 1 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT1    Port x configuration bit 1
: GPIOB_OTYPER_OT0   %1 0 lshift GPIOB_OTYPER bis! ;  \ GPIOB_OTYPER_OT0    Port x configuration bit 0

\ GPIOB_OSPEEDR (read-write)
: GPIOB_OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR15    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR14    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR13    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR12    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR11    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR10    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR9    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR8    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR7    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR6    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR5    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR4    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR3    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR2    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR1    Port x configuration bits y =  0..15
: GPIOB_OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOB_OSPEEDR bis! ;  \ GPIOB_OSPEEDR_OSPEEDR0    Port x configuration bits y =  0..15

\ GPIOB_PUPDR (read-write)
: GPIOB_PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOB_PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOB_PUPDR bis! ;  \ GPIOB_PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOB_IDR (read-only)
: GPIOB_IDR_IDR15   %1 15 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR15    Port input data y =  0..15
: GPIOB_IDR_IDR14   %1 14 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR14    Port input data y =  0..15
: GPIOB_IDR_IDR13   %1 13 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR13    Port input data y =  0..15
: GPIOB_IDR_IDR12   %1 12 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR12    Port input data y =  0..15
: GPIOB_IDR_IDR11   %1 11 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR11    Port input data y =  0..15
: GPIOB_IDR_IDR10   %1 10 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR10    Port input data y =  0..15
: GPIOB_IDR_IDR9   %1 9 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR9    Port input data y =  0..15
: GPIOB_IDR_IDR8   %1 8 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR8    Port input data y =  0..15
: GPIOB_IDR_IDR7   %1 7 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR7    Port input data y =  0..15
: GPIOB_IDR_IDR6   %1 6 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR6    Port input data y =  0..15
: GPIOB_IDR_IDR5   %1 5 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR5    Port input data y =  0..15
: GPIOB_IDR_IDR4   %1 4 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR4    Port input data y =  0..15
: GPIOB_IDR_IDR3   %1 3 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR3    Port input data y =  0..15
: GPIOB_IDR_IDR2   %1 2 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR2    Port input data y =  0..15
: GPIOB_IDR_IDR1   %1 1 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR1    Port input data y =  0..15
: GPIOB_IDR_IDR0   %1 0 lshift GPIOB_IDR bis! ;  \ GPIOB_IDR_IDR0    Port input data y =  0..15

\ GPIOB_ODR (read-write)
: GPIOB_ODR_ODR15   %1 15 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR15    Port output data y =  0..15
: GPIOB_ODR_ODR14   %1 14 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR14    Port output data y =  0..15
: GPIOB_ODR_ODR13   %1 13 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR13    Port output data y =  0..15
: GPIOB_ODR_ODR12   %1 12 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR12    Port output data y =  0..15
: GPIOB_ODR_ODR11   %1 11 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR11    Port output data y =  0..15
: GPIOB_ODR_ODR10   %1 10 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR10    Port output data y =  0..15
: GPIOB_ODR_ODR9   %1 9 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR9    Port output data y =  0..15
: GPIOB_ODR_ODR8   %1 8 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR8    Port output data y =  0..15
: GPIOB_ODR_ODR7   %1 7 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR7    Port output data y =  0..15
: GPIOB_ODR_ODR6   %1 6 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR6    Port output data y =  0..15
: GPIOB_ODR_ODR5   %1 5 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR5    Port output data y =  0..15
: GPIOB_ODR_ODR4   %1 4 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR4    Port output data y =  0..15
: GPIOB_ODR_ODR3   %1 3 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR3    Port output data y =  0..15
: GPIOB_ODR_ODR2   %1 2 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR2    Port output data y =  0..15
: GPIOB_ODR_ODR1   %1 1 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR1    Port output data y =  0..15
: GPIOB_ODR_ODR0   %1 0 lshift GPIOB_ODR bis! ;  \ GPIOB_ODR_ODR0    Port output data y =  0..15

\ GPIOB_BSRR (write-only)
: GPIOB_BSRR_BR15   %1 31 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR15    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR14   %1 30 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR14    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR13   %1 29 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR13    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR12   %1 28 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR12    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR11   %1 27 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR11    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR10   %1 26 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR10    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR9   %1 25 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR9    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR8   %1 24 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR8    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR7   %1 23 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR7    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR6   %1 22 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR6    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR5   %1 21 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR5    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR4   %1 20 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR4    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR3   %1 19 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR3    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR2   %1 18 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR2    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR1   %1 17 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR1    Port x reset bit y y =  0..15
: GPIOB_BSRR_BR0   %1 16 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BR0    Port x set bit y y=  0..15
: GPIOB_BSRR_BS15   %1 15 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS15    Port x set bit y y=  0..15
: GPIOB_BSRR_BS14   %1 14 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS14    Port x set bit y y=  0..15
: GPIOB_BSRR_BS13   %1 13 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS13    Port x set bit y y=  0..15
: GPIOB_BSRR_BS12   %1 12 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS12    Port x set bit y y=  0..15
: GPIOB_BSRR_BS11   %1 11 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS11    Port x set bit y y=  0..15
: GPIOB_BSRR_BS10   %1 10 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS10    Port x set bit y y=  0..15
: GPIOB_BSRR_BS9   %1 9 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS9    Port x set bit y y=  0..15
: GPIOB_BSRR_BS8   %1 8 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS8    Port x set bit y y=  0..15
: GPIOB_BSRR_BS7   %1 7 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS7    Port x set bit y y=  0..15
: GPIOB_BSRR_BS6   %1 6 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS6    Port x set bit y y=  0..15
: GPIOB_BSRR_BS5   %1 5 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS5    Port x set bit y y=  0..15
: GPIOB_BSRR_BS4   %1 4 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS4    Port x set bit y y=  0..15
: GPIOB_BSRR_BS3   %1 3 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS3    Port x set bit y y=  0..15
: GPIOB_BSRR_BS2   %1 2 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS2    Port x set bit y y=  0..15
: GPIOB_BSRR_BS1   %1 1 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS1    Port x set bit y y=  0..15
: GPIOB_BSRR_BS0   %1 0 lshift GPIOB_BSRR bis! ;  \ GPIOB_BSRR_BS0    Port x set bit y y=  0..15

\ GPIOB_LCKR (read-write)
: GPIOB_LCKR_LCKK   %1 16 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCKK    Port x lock bit y
: GPIOB_LCKR_LCK15   %1 15 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK14   %1 14 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK13   %1 13 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK12   %1 12 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK11   %1 11 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK10   %1 10 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK9   %1 9 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK8   %1 8 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK7   %1 7 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK6   %1 6 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK5   %1 5 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK4   %1 4 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK3   %1 3 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK2   %1 2 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK1   %1 1 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOB_LCKR_LCK0   %1 0 lshift GPIOB_LCKR bis! ;  \ GPIOB_LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOB_AFRL (read-write)
: GPIOB_AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOB_AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOB_AFRL bis! ;  \ GPIOB_AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOB_AFRH (read-write)
: GPIOB_AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOB_AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOB_AFRH bis! ;  \ GPIOB_AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOB_BRR (write-only)
: GPIOB_BRR_BR0   %1 0 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR0    Port x Reset bit y
: GPIOB_BRR_BR1   %1 1 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR1    Port x Reset bit y
: GPIOB_BRR_BR2   %1 2 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR2    Port x Reset bit y
: GPIOB_BRR_BR3   %1 3 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR3    Port x Reset bit y
: GPIOB_BRR_BR4   %1 4 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR4    Port x Reset bit y
: GPIOB_BRR_BR5   %1 5 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR5    Port x Reset bit y
: GPIOB_BRR_BR6   %1 6 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR6    Port x Reset bit y
: GPIOB_BRR_BR7   %1 7 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR7    Port x Reset bit y
: GPIOB_BRR_BR8   %1 8 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR8    Port x Reset bit y
: GPIOB_BRR_BR9   %1 9 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR9    Port x Reset bit y
: GPIOB_BRR_BR10   %1 10 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR10    Port x Reset bit y
: GPIOB_BRR_BR11   %1 11 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR11    Port x Reset bit y
: GPIOB_BRR_BR12   %1 12 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR12    Port x Reset bit y
: GPIOB_BRR_BR13   %1 13 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR13    Port x Reset bit y
: GPIOB_BRR_BR14   %1 14 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR14    Port x Reset bit y
: GPIOB_BRR_BR15   %1 15 lshift GPIOB_BRR bis! ;  \ GPIOB_BRR_BR15    Port x Reset bit y

\ GPIOA_MODER (read-write)
: GPIOA_MODER_MODER15   ( %XX -- ) 30 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER15    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER14   ( %XX -- ) 28 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER14    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER13   ( %XX -- ) 26 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER13    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER12   ( %XX -- ) 24 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER12    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER11   ( %XX -- ) 22 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER11    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER10   ( %XX -- ) 20 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER10    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER9   ( %XX -- ) 18 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER9    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER8   ( %XX -- ) 16 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER8    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER7   ( %XX -- ) 14 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER7    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER6   ( %XX -- ) 12 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER6    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER5   ( %XX -- ) 10 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER5    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER4   ( %XX -- ) 8 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER4    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER3   ( %XX -- ) 6 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER3    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER2   ( %XX -- ) 4 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER2    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER1   ( %XX -- ) 2 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER1    Port x configuration bits y =  0..15
: GPIOA_MODER_MODER0   ( %XX -- ) 0 lshift GPIOA_MODER bis! ;  \ GPIOA_MODER_MODER0    Port x configuration bits y =  0..15

\ GPIOA_OTYPER (read-write)
: GPIOA_OTYPER_OT15   %1 15 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT15    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT14   %1 14 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT14    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT13   %1 13 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT13    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT12   %1 12 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT12    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT11   %1 11 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT11    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT10   %1 10 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT10    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT9   %1 9 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT9    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT8   %1 8 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT8    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT7   %1 7 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT7    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT6   %1 6 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT6    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT5   %1 5 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT5    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT4   %1 4 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT4    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT3   %1 3 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT3    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT2   %1 2 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT2    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT1   %1 1 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT1    Port x configuration bits y =  0..15
: GPIOA_OTYPER_OT0   %1 0 lshift GPIOA_OTYPER bis! ;  \ GPIOA_OTYPER_OT0    Port x configuration bits y =  0..15

\ GPIOA_OSPEEDR (read-write)
: GPIOA_OSPEEDR_OSPEEDR15   ( %XX -- ) 30 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR15    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR14   ( %XX -- ) 28 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR14    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR13   ( %XX -- ) 26 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR13    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR12   ( %XX -- ) 24 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR12    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR11   ( %XX -- ) 22 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR11    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR10   ( %XX -- ) 20 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR10    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR9   ( %XX -- ) 18 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR9    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR8   ( %XX -- ) 16 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR8    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR7   ( %XX -- ) 14 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR7    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR6   ( %XX -- ) 12 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR6    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR5   ( %XX -- ) 10 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR5    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR4   ( %XX -- ) 8 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR4    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR3   ( %XX -- ) 6 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR3    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR2   ( %XX -- ) 4 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR2    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR1   ( %XX -- ) 2 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR1    Port x configuration bits y =  0..15
: GPIOA_OSPEEDR_OSPEEDR0   ( %XX -- ) 0 lshift GPIOA_OSPEEDR bis! ;  \ GPIOA_OSPEEDR_OSPEEDR0    Port x configuration bits y =  0..15

\ GPIOA_PUPDR (read-write)
: GPIOA_PUPDR_PUPDR15   ( %XX -- ) 30 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR15    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR14   ( %XX -- ) 28 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR14    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR13   ( %XX -- ) 26 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR13    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR12   ( %XX -- ) 24 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR12    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR11   ( %XX -- ) 22 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR11    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR10   ( %XX -- ) 20 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR10    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR9   ( %XX -- ) 18 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR9    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR8   ( %XX -- ) 16 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR8    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR7   ( %XX -- ) 14 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR7    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR6   ( %XX -- ) 12 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR6    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR5   ( %XX -- ) 10 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR5    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR4   ( %XX -- ) 8 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR4    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR3   ( %XX -- ) 6 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR3    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR2   ( %XX -- ) 4 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR2    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR1   ( %XX -- ) 2 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR1    Port x configuration bits y =  0..15
: GPIOA_PUPDR_PUPDR0   ( %XX -- ) 0 lshift GPIOA_PUPDR bis! ;  \ GPIOA_PUPDR_PUPDR0    Port x configuration bits y =  0..15

\ GPIOA_IDR (read-only)
: GPIOA_IDR_IDR15   %1 15 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR15    Port input data y =  0..15
: GPIOA_IDR_IDR14   %1 14 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR14    Port input data y =  0..15
: GPIOA_IDR_IDR13   %1 13 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR13    Port input data y =  0..15
: GPIOA_IDR_IDR12   %1 12 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR12    Port input data y =  0..15
: GPIOA_IDR_IDR11   %1 11 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR11    Port input data y =  0..15
: GPIOA_IDR_IDR10   %1 10 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR10    Port input data y =  0..15
: GPIOA_IDR_IDR9   %1 9 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR9    Port input data y =  0..15
: GPIOA_IDR_IDR8   %1 8 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR8    Port input data y =  0..15
: GPIOA_IDR_IDR7   %1 7 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR7    Port input data y =  0..15
: GPIOA_IDR_IDR6   %1 6 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR6    Port input data y =  0..15
: GPIOA_IDR_IDR5   %1 5 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR5    Port input data y =  0..15
: GPIOA_IDR_IDR4   %1 4 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR4    Port input data y =  0..15
: GPIOA_IDR_IDR3   %1 3 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR3    Port input data y =  0..15
: GPIOA_IDR_IDR2   %1 2 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR2    Port input data y =  0..15
: GPIOA_IDR_IDR1   %1 1 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR1    Port input data y =  0..15
: GPIOA_IDR_IDR0   %1 0 lshift GPIOA_IDR bis! ;  \ GPIOA_IDR_IDR0    Port input data y =  0..15

\ GPIOA_ODR (read-write)
: GPIOA_ODR_ODR15   %1 15 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR15    Port output data y =  0..15
: GPIOA_ODR_ODR14   %1 14 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR14    Port output data y =  0..15
: GPIOA_ODR_ODR13   %1 13 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR13    Port output data y =  0..15
: GPIOA_ODR_ODR12   %1 12 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR12    Port output data y =  0..15
: GPIOA_ODR_ODR11   %1 11 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR11    Port output data y =  0..15
: GPIOA_ODR_ODR10   %1 10 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR10    Port output data y =  0..15
: GPIOA_ODR_ODR9   %1 9 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR9    Port output data y =  0..15
: GPIOA_ODR_ODR8   %1 8 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR8    Port output data y =  0..15
: GPIOA_ODR_ODR7   %1 7 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR7    Port output data y =  0..15
: GPIOA_ODR_ODR6   %1 6 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR6    Port output data y =  0..15
: GPIOA_ODR_ODR5   %1 5 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR5    Port output data y =  0..15
: GPIOA_ODR_ODR4   %1 4 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR4    Port output data y =  0..15
: GPIOA_ODR_ODR3   %1 3 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR3    Port output data y =  0..15
: GPIOA_ODR_ODR2   %1 2 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR2    Port output data y =  0..15
: GPIOA_ODR_ODR1   %1 1 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR1    Port output data y =  0..15
: GPIOA_ODR_ODR0   %1 0 lshift GPIOA_ODR bis! ;  \ GPIOA_ODR_ODR0    Port output data y =  0..15

\ GPIOA_BSRR (write-only)
: GPIOA_BSRR_BR15   %1 31 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR15    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR14   %1 30 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR14    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR13   %1 29 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR13    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR12   %1 28 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR12    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR11   %1 27 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR11    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR10   %1 26 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR10    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR9   %1 25 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR9    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR8   %1 24 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR8    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR7   %1 23 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR7    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR6   %1 22 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR6    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR5   %1 21 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR5    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR4   %1 20 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR4    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR3   %1 19 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR3    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR2   %1 18 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR2    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR1   %1 17 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR1    Port x reset bit y y =  0..15
: GPIOA_BSRR_BR0   %1 16 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BR0    Port x set bit y y=  0..15
: GPIOA_BSRR_BS15   %1 15 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS15    Port x set bit y y=  0..15
: GPIOA_BSRR_BS14   %1 14 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS14    Port x set bit y y=  0..15
: GPIOA_BSRR_BS13   %1 13 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS13    Port x set bit y y=  0..15
: GPIOA_BSRR_BS12   %1 12 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS12    Port x set bit y y=  0..15
: GPIOA_BSRR_BS11   %1 11 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS11    Port x set bit y y=  0..15
: GPIOA_BSRR_BS10   %1 10 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS10    Port x set bit y y=  0..15
: GPIOA_BSRR_BS9   %1 9 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS9    Port x set bit y y=  0..15
: GPIOA_BSRR_BS8   %1 8 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS8    Port x set bit y y=  0..15
: GPIOA_BSRR_BS7   %1 7 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS7    Port x set bit y y=  0..15
: GPIOA_BSRR_BS6   %1 6 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS6    Port x set bit y y=  0..15
: GPIOA_BSRR_BS5   %1 5 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS5    Port x set bit y y=  0..15
: GPIOA_BSRR_BS4   %1 4 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS4    Port x set bit y y=  0..15
: GPIOA_BSRR_BS3   %1 3 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS3    Port x set bit y y=  0..15
: GPIOA_BSRR_BS2   %1 2 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS2    Port x set bit y y=  0..15
: GPIOA_BSRR_BS1   %1 1 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS1    Port x set bit y y=  0..15
: GPIOA_BSRR_BS0   %1 0 lshift GPIOA_BSRR bis! ;  \ GPIOA_BSRR_BS0    Port x set bit y y=  0..15

\ GPIOA_LCKR (read-write)
: GPIOA_LCKR_LCKK   %1 16 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCKK    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK15   %1 15 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK15    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK14   %1 14 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK14    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK13   %1 13 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK13    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK12   %1 12 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK12    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK11   %1 11 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK11    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK10   %1 10 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK10    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK9   %1 9 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK9    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK8   %1 8 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK8    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK7   %1 7 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK7    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK6   %1 6 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK6    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK5   %1 5 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK5    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK4   %1 4 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK4    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK3   %1 3 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK3    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK2   %1 2 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK2    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK1   %1 1 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK1    Port x lock bit y y=  0..15
: GPIOA_LCKR_LCK0   %1 0 lshift GPIOA_LCKR bis! ;  \ GPIOA_LCKR_LCK0    Port x lock bit y y=  0..15

\ GPIOA_AFRL (read-write)
: GPIOA_AFRL_AFRL7   ( %XXXX -- ) 28 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL7    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL6   ( %XXXX -- ) 24 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL6    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL5   ( %XXXX -- ) 20 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL5    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL4   ( %XXXX -- ) 16 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL4    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL3   ( %XXXX -- ) 12 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL3    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL2   ( %XXXX -- ) 8 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL2    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL1   ( %XXXX -- ) 4 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL1    Alternate function selection for port x  bit y y = 0..7
: GPIOA_AFRL_AFRL0   ( %XXXX -- ) 0 lshift GPIOA_AFRL bis! ;  \ GPIOA_AFRL_AFRL0    Alternate function selection for port x  bit y y = 0..7

\ GPIOA_AFRH (read-write)
: GPIOA_AFRH_AFRH15   ( %XXXX -- ) 28 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH15    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH14   ( %XXXX -- ) 24 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH14    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH13   ( %XXXX -- ) 20 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH13    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH12   ( %XXXX -- ) 16 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH12    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH11   ( %XXXX -- ) 12 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH11    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH10   ( %XXXX -- ) 8 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH10    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH9   ( %XXXX -- ) 4 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH9    Alternate function selection for port x  bit y y = 8..15
: GPIOA_AFRH_AFRH8   ( %XXXX -- ) 0 lshift GPIOA_AFRH bis! ;  \ GPIOA_AFRH_AFRH8    Alternate function selection for port x  bit y y = 8..15

\ GPIOA_BRR (write-only)
: GPIOA_BRR_BR0   %1 0 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR0    Port x Reset bit y
: GPIOA_BRR_BR1   %1 1 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR1    Port x Reset bit y
: GPIOA_BRR_BR2   %1 2 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR2    Port x Reset bit y
: GPIOA_BRR_BR3   %1 3 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR3    Port x Reset bit y
: GPIOA_BRR_BR4   %1 4 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR4    Port x Reset bit y
: GPIOA_BRR_BR5   %1 5 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR5    Port x Reset bit y
: GPIOA_BRR_BR6   %1 6 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR6    Port x Reset bit y
: GPIOA_BRR_BR7   %1 7 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR7    Port x Reset bit y
: GPIOA_BRR_BR8   %1 8 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR8    Port x Reset bit y
: GPIOA_BRR_BR9   %1 9 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR9    Port x Reset bit y
: GPIOA_BRR_BR10   %1 10 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR10    Port x Reset bit y
: GPIOA_BRR_BR11   %1 11 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR11    Port x Reset bit y
: GPIOA_BRR_BR12   %1 12 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR12    Port x Reset bit y
: GPIOA_BRR_BR13   %1 13 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR13    Port x Reset bit y
: GPIOA_BRR_BR14   %1 14 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR14    Port x Reset bit y
: GPIOA_BRR_BR15   %1 15 lshift GPIOA_BRR bis! ;  \ GPIOA_BRR_BR15    Port x Reset bit y

\ SPI1_CR1 (read-write)
: SPI1_CR1_BIDIMODE   %1 15 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_BIDIMODE    Bidirectional data mode  enable
: SPI1_CR1_BIDIOE   %1 14 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_BIDIOE    Output enable in bidirectional  mode
: SPI1_CR1_CRCEN   %1 13 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_CRCEN    Hardware CRC calculation  enable
: SPI1_CR1_CRCNEXT   %1 12 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_CRCNEXT    CRC transfer next
: SPI1_CR1_DFF   %1 11 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_DFF    Data frame format
: SPI1_CR1_RXONLY   %1 10 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_RXONLY    Receive only
: SPI1_CR1_SSM   %1 9 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_SSM    Software slave management
: SPI1_CR1_SSI   %1 8 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_SSI    Internal slave select
: SPI1_CR1_LSBFIRST   %1 7 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_LSBFIRST    Frame format
: SPI1_CR1_SPE   %1 6 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_SPE    SPI enable
: SPI1_CR1_BR   ( %XXX -- ) 3 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_BR    Baud rate control
: SPI1_CR1_MSTR   %1 2 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_MSTR    Master selection
: SPI1_CR1_CPOL   %1 1 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_CPOL    Clock polarity
: SPI1_CR1_CPHA   %1 0 lshift SPI1_CR1 bis! ;  \ SPI1_CR1_CPHA    Clock phase

\ SPI1_CR2 (read-write)
: SPI1_CR2_RXDMAEN   %1 0 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_RXDMAEN    Rx buffer DMA enable
: SPI1_CR2_TXDMAEN   %1 1 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_TXDMAEN    Tx buffer DMA enable
: SPI1_CR2_SSOE   %1 2 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_SSOE    SS output enable
: SPI1_CR2_NSSP   %1 3 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_NSSP    NSS pulse management
: SPI1_CR2_FRF   %1 4 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_FRF    Frame format
: SPI1_CR2_ERRIE   %1 5 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_ERRIE    Error interrupt enable
: SPI1_CR2_RXNEIE   %1 6 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI1_CR2_TXEIE   %1 7 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI1_CR2_DS   ( %XXXX -- ) 8 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_DS    Data size
: SPI1_CR2_FRXTH   %1 12 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_FRXTH    FIFO reception threshold
: SPI1_CR2_LDMA_RX   %1 13 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_LDMA_RX    Last DMA transfer for  reception
: SPI1_CR2_LDMA_TX   %1 14 lshift SPI1_CR2 bis! ;  \ SPI1_CR2_LDMA_TX    Last DMA transfer for  transmission

\ SPI1_SR ()
: SPI1_SR_RXNE   %1 0 lshift SPI1_SR bis! ;  \ SPI1_SR_RXNE    Receive buffer not empty
: SPI1_SR_TXE   %1 1 lshift SPI1_SR bis! ;  \ SPI1_SR_TXE    Transmit buffer empty
: SPI1_SR_CHSIDE   %1 2 lshift SPI1_SR bis! ;  \ SPI1_SR_CHSIDE    Channel side
: SPI1_SR_UDR   %1 3 lshift SPI1_SR bis! ;  \ SPI1_SR_UDR    Underrun flag
: SPI1_SR_CRCERR   %1 4 lshift SPI1_SR bis! ;  \ SPI1_SR_CRCERR    CRC error flag
: SPI1_SR_MODF   %1 5 lshift SPI1_SR bis! ;  \ SPI1_SR_MODF    Mode fault
: SPI1_SR_OVR   %1 6 lshift SPI1_SR bis! ;  \ SPI1_SR_OVR    Overrun flag
: SPI1_SR_BSY   %1 7 lshift SPI1_SR bis! ;  \ SPI1_SR_BSY    Busy flag
: SPI1_SR_TIFRFE   %1 8 lshift SPI1_SR bis! ;  \ SPI1_SR_TIFRFE    TI frame format error
: SPI1_SR_FRLVL   ( %XX -- ) 9 lshift SPI1_SR bis! ;  \ SPI1_SR_FRLVL    FIFO reception level
: SPI1_SR_FTLVL   ( %XX -- ) 11 lshift SPI1_SR bis! ;  \ SPI1_SR_FTLVL    FIFO transmission level

\ SPI1_DR (read-write)
: SPI1_DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1_DR bis! ;  \ SPI1_DR_DR    Data register

\ SPI1_CRCPR (read-write)
: SPI1_CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1_CRCPR bis! ;  \ SPI1_CRCPR_CRCPOLY    CRC polynomial register

\ SPI1_RXCRCR (read-only)
: SPI1_RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1_RXCRCR bis! ;  \ SPI1_RXCRCR_RxCRC    Rx CRC register

\ SPI1_TXCRCR (read-only)
: SPI1_TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI1_TXCRCR bis! ;  \ SPI1_TXCRCR_TxCRC    Tx CRC register

\ SPI1_I2SCFGR (read-write)
: SPI1_I2SCFGR_I2SMOD   %1 11 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_I2SMOD    I2S mode selection
: SPI1_I2SCFGR_I2SE   %1 10 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_I2SE    I2S Enable
: SPI1_I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_I2SCFG    I2S configuration mode
: SPI1_I2SCFGR_PCMSYNC   %1 7 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI1_I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_I2SSTD    I2S standard selection
: SPI1_I2SCFGR_CKPOL   %1 3 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_CKPOL    Steady state clock  polarity
: SPI1_I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_DATLEN    Data length to be  transferred
: SPI1_I2SCFGR_CHLEN   %1 0 lshift SPI1_I2SCFGR bis! ;  \ SPI1_I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI1_I2SPR (read-write)
: SPI1_I2SPR_MCKOE   %1 9 lshift SPI1_I2SPR bis! ;  \ SPI1_I2SPR_MCKOE    Master clock output enable
: SPI1_I2SPR_ODD   %1 8 lshift SPI1_I2SPR bis! ;  \ SPI1_I2SPR_ODD    Odd factor for the  prescaler
: SPI1_I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI1_I2SPR bis! ;  \ SPI1_I2SPR_I2SDIV    I2S Linear prescaler

\ SPI2_CR1 (read-write)
: SPI2_CR1_BIDIMODE   %1 15 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_BIDIMODE    Bidirectional data mode  enable
: SPI2_CR1_BIDIOE   %1 14 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_BIDIOE    Output enable in bidirectional  mode
: SPI2_CR1_CRCEN   %1 13 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_CRCEN    Hardware CRC calculation  enable
: SPI2_CR1_CRCNEXT   %1 12 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_CRCNEXT    CRC transfer next
: SPI2_CR1_DFF   %1 11 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_DFF    Data frame format
: SPI2_CR1_RXONLY   %1 10 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_RXONLY    Receive only
: SPI2_CR1_SSM   %1 9 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_SSM    Software slave management
: SPI2_CR1_SSI   %1 8 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_SSI    Internal slave select
: SPI2_CR1_LSBFIRST   %1 7 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_LSBFIRST    Frame format
: SPI2_CR1_SPE   %1 6 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_SPE    SPI enable
: SPI2_CR1_BR   ( %XXX -- ) 3 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_BR    Baud rate control
: SPI2_CR1_MSTR   %1 2 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_MSTR    Master selection
: SPI2_CR1_CPOL   %1 1 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_CPOL    Clock polarity
: SPI2_CR1_CPHA   %1 0 lshift SPI2_CR1 bis! ;  \ SPI2_CR1_CPHA    Clock phase

\ SPI2_CR2 (read-write)
: SPI2_CR2_RXDMAEN   %1 0 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_RXDMAEN    Rx buffer DMA enable
: SPI2_CR2_TXDMAEN   %1 1 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_TXDMAEN    Tx buffer DMA enable
: SPI2_CR2_SSOE   %1 2 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_SSOE    SS output enable
: SPI2_CR2_NSSP   %1 3 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_NSSP    NSS pulse management
: SPI2_CR2_FRF   %1 4 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_FRF    Frame format
: SPI2_CR2_ERRIE   %1 5 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_ERRIE    Error interrupt enable
: SPI2_CR2_RXNEIE   %1 6 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_RXNEIE    RX buffer not empty interrupt  enable
: SPI2_CR2_TXEIE   %1 7 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_TXEIE    Tx buffer empty interrupt  enable
: SPI2_CR2_DS   ( %XXXX -- ) 8 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_DS    Data size
: SPI2_CR2_FRXTH   %1 12 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_FRXTH    FIFO reception threshold
: SPI2_CR2_LDMA_RX   %1 13 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_LDMA_RX    Last DMA transfer for  reception
: SPI2_CR2_LDMA_TX   %1 14 lshift SPI2_CR2 bis! ;  \ SPI2_CR2_LDMA_TX    Last DMA transfer for  transmission

\ SPI2_SR ()
: SPI2_SR_RXNE   %1 0 lshift SPI2_SR bis! ;  \ SPI2_SR_RXNE    Receive buffer not empty
: SPI2_SR_TXE   %1 1 lshift SPI2_SR bis! ;  \ SPI2_SR_TXE    Transmit buffer empty
: SPI2_SR_CHSIDE   %1 2 lshift SPI2_SR bis! ;  \ SPI2_SR_CHSIDE    Channel side
: SPI2_SR_UDR   %1 3 lshift SPI2_SR bis! ;  \ SPI2_SR_UDR    Underrun flag
: SPI2_SR_CRCERR   %1 4 lshift SPI2_SR bis! ;  \ SPI2_SR_CRCERR    CRC error flag
: SPI2_SR_MODF   %1 5 lshift SPI2_SR bis! ;  \ SPI2_SR_MODF    Mode fault
: SPI2_SR_OVR   %1 6 lshift SPI2_SR bis! ;  \ SPI2_SR_OVR    Overrun flag
: SPI2_SR_BSY   %1 7 lshift SPI2_SR bis! ;  \ SPI2_SR_BSY    Busy flag
: SPI2_SR_TIFRFE   %1 8 lshift SPI2_SR bis! ;  \ SPI2_SR_TIFRFE    TI frame format error
: SPI2_SR_FRLVL   ( %XX -- ) 9 lshift SPI2_SR bis! ;  \ SPI2_SR_FRLVL    FIFO reception level
: SPI2_SR_FTLVL   ( %XX -- ) 11 lshift SPI2_SR bis! ;  \ SPI2_SR_FTLVL    FIFO transmission level

\ SPI2_DR (read-write)
: SPI2_DR_DR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2_DR bis! ;  \ SPI2_DR_DR    Data register

\ SPI2_CRCPR (read-write)
: SPI2_CRCPR_CRCPOLY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2_CRCPR bis! ;  \ SPI2_CRCPR_CRCPOLY    CRC polynomial register

\ SPI2_RXCRCR (read-only)
: SPI2_RXCRCR_RxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2_RXCRCR bis! ;  \ SPI2_RXCRCR_RxCRC    Rx CRC register

\ SPI2_TXCRCR (read-only)
: SPI2_TXCRCR_TxCRC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift SPI2_TXCRCR bis! ;  \ SPI2_TXCRCR_TxCRC    Tx CRC register

\ SPI2_I2SCFGR (read-write)
: SPI2_I2SCFGR_I2SMOD   %1 11 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_I2SMOD    I2S mode selection
: SPI2_I2SCFGR_I2SE   %1 10 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_I2SE    I2S Enable
: SPI2_I2SCFGR_I2SCFG   ( %XX -- ) 8 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_I2SCFG    I2S configuration mode
: SPI2_I2SCFGR_PCMSYNC   %1 7 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_PCMSYNC    PCM frame synchronization
: SPI2_I2SCFGR_I2SSTD   ( %XX -- ) 4 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_I2SSTD    I2S standard selection
: SPI2_I2SCFGR_CKPOL   %1 3 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_CKPOL    Steady state clock  polarity
: SPI2_I2SCFGR_DATLEN   ( %XX -- ) 1 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_DATLEN    Data length to be  transferred
: SPI2_I2SCFGR_CHLEN   %1 0 lshift SPI2_I2SCFGR bis! ;  \ SPI2_I2SCFGR_CHLEN    Channel length number of bits per audio  channel

\ SPI2_I2SPR (read-write)
: SPI2_I2SPR_MCKOE   %1 9 lshift SPI2_I2SPR bis! ;  \ SPI2_I2SPR_MCKOE    Master clock output enable
: SPI2_I2SPR_ODD   %1 8 lshift SPI2_I2SPR bis! ;  \ SPI2_I2SPR_ODD    Odd factor for the  prescaler
: SPI2_I2SPR_I2SDIV   ( %XXXXXXXX -- ) 0 lshift SPI2_I2SPR bis! ;  \ SPI2_I2SPR_I2SDIV    I2S Linear prescaler

\ PWR_CR (read-write)
: PWR_CR_FPDS   %1 9 lshift PWR_CR bis! ;  \ PWR_CR_FPDS    Flash power down in Stop  mode
: PWR_CR_DBP   %1 8 lshift PWR_CR bis! ;  \ PWR_CR_DBP    Disable backup domain write  protection
: PWR_CR_PLS   ( %XXX -- ) 5 lshift PWR_CR bis! ;  \ PWR_CR_PLS    PVD level selection
: PWR_CR_PVDE   %1 4 lshift PWR_CR bis! ;  \ PWR_CR_PVDE    Power voltage detector  enable
: PWR_CR_CSBF   %1 3 lshift PWR_CR bis! ;  \ PWR_CR_CSBF    Clear standby flag
: PWR_CR_CWUF   %1 2 lshift PWR_CR bis! ;  \ PWR_CR_CWUF    Clear wakeup flag
: PWR_CR_PDDS   %1 1 lshift PWR_CR bis! ;  \ PWR_CR_PDDS    Power down deepsleep
: PWR_CR_LPDS   %1 0 lshift PWR_CR bis! ;  \ PWR_CR_LPDS    Low-power deep sleep

\ PWR_CSR ()
: PWR_CSR_BRE   %1 9 lshift PWR_CSR bis! ;  \ PWR_CSR_BRE    Backup regulator enable
: PWR_CSR_EWUP   %1 8 lshift PWR_CSR bis! ;  \ PWR_CSR_EWUP    Enable WKUP pin
: PWR_CSR_BRR   %1 3 lshift PWR_CSR bis! ;  \ PWR_CSR_BRR    Backup regulator ready
: PWR_CSR_PVDO   %1 2 lshift PWR_CSR bis! ;  \ PWR_CSR_PVDO    PVD output
: PWR_CSR_SBF   %1 1 lshift PWR_CSR bis! ;  \ PWR_CSR_SBF    Standby flag
: PWR_CSR_WUF   %1 0 lshift PWR_CSR bis! ;  \ PWR_CSR_WUF    Wakeup flag

\ I2C1_CR1 ()
: I2C1_CR1_PE   %1 0 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_PE    Peripheral enable
: I2C1_CR1_TXIE   %1 1 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_TXIE    TX Interrupt enable
: I2C1_CR1_RXIE   %1 2 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_RXIE    RX Interrupt enable
: I2C1_CR1_ADDRIE   %1 3 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_ADDRIE    Address match interrupt enable slave  only
: I2C1_CR1_NACKIE   %1 4 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_NACKIE    Not acknowledge received interrupt  enable
: I2C1_CR1_STOPIE   %1 5 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_STOPIE    STOP detection Interrupt  enable
: I2C1_CR1_TCIE   %1 6 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_TCIE    Transfer Complete interrupt  enable
: I2C1_CR1_ERRIE   %1 7 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_ERRIE    Error interrupts enable
: I2C1_CR1_DNF   ( %XXXX -- ) 8 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_DNF    Digital noise filter
: I2C1_CR1_ANFOFF   %1 12 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_ANFOFF    Analog noise filter OFF
: I2C1_CR1_SWRST   %1 13 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_SWRST    Software reset
: I2C1_CR1_TXDMAEN   %1 14 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_TXDMAEN    DMA transmission requests  enable
: I2C1_CR1_RXDMAEN   %1 15 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_RXDMAEN    DMA reception requests  enable
: I2C1_CR1_SBC   %1 16 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_SBC    Slave byte control
: I2C1_CR1_NOSTRETCH   %1 17 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_NOSTRETCH    Clock stretching disable
: I2C1_CR1_WUPEN   %1 18 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_WUPEN    Wakeup from STOP enable
: I2C1_CR1_GCEN   %1 19 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_GCEN    General call enable
: I2C1_CR1_SMBHEN   %1 20 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_SMBHEN    SMBus Host address enable
: I2C1_CR1_SMBDEN   %1 21 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_SMBDEN    SMBus Device Default address  enable
: I2C1_CR1_ALERTEN   %1 22 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_ALERTEN    SMBUS alert enable
: I2C1_CR1_PECEN   %1 23 lshift I2C1_CR1 bis! ;  \ I2C1_CR1_PECEN    PEC enable

\ I2C1_CR2 (read-write)
: I2C1_CR2_PECBYTE   %1 26 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_PECBYTE    Packet error checking byte
: I2C1_CR2_AUTOEND   %1 25 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_AUTOEND    Automatic end mode master  mode
: I2C1_CR2_RELOAD   %1 24 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_RELOAD    NBYTES reload mode
: I2C1_CR2_NBYTES   ( %XXXXXXXX -- ) 16 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_NBYTES    Number of bytes
: I2C1_CR2_NACK   %1 15 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_NACK    NACK generation slave  mode
: I2C1_CR2_STOP   %1 14 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_STOP    Stop generation master  mode
: I2C1_CR2_START   %1 13 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_START    Start generation
: I2C1_CR2_HEAD10R   %1 12 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_HEAD10R    10-bit address header only read  direction master receiver mode
: I2C1_CR2_ADD10   %1 11 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_ADD10    10-bit addressing mode master  mode
: I2C1_CR2_RD_WRN   %1 10 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_RD_WRN    Transfer direction master  mode
: I2C1_CR2_SADD8   ( %XX -- ) 8 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_SADD8    Slave address bit 9:8 master  mode
: I2C1_CR2_SADD1   ( %XXXXXXX -- ) 1 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_SADD1    Slave address bit 7:1 master  mode
: I2C1_CR2_SADD0   %1 0 lshift I2C1_CR2 bis! ;  \ I2C1_CR2_SADD0    Slave address bit 0 master  mode

\ I2C1_OAR1 (read-write)
: I2C1_OAR1_OA1_0   %1 0 lshift I2C1_OAR1 bis! ;  \ I2C1_OAR1_OA1_0    Interface address
: I2C1_OAR1_OA1_1   ( %XXXXXXX -- ) 1 lshift I2C1_OAR1 bis! ;  \ I2C1_OAR1_OA1_1    Interface address
: I2C1_OAR1_OA1_8   ( %XX -- ) 8 lshift I2C1_OAR1 bis! ;  \ I2C1_OAR1_OA1_8    Interface address
: I2C1_OAR1_OA1MODE   %1 10 lshift I2C1_OAR1 bis! ;  \ I2C1_OAR1_OA1MODE    Own Address 1 10-bit mode
: I2C1_OAR1_OA1EN   %1 15 lshift I2C1_OAR1 bis! ;  \ I2C1_OAR1_OA1EN    Own Address 1 enable

\ I2C1_OAR2 (read-write)
: I2C1_OAR2_OA2   ( %XXXXXXX -- ) 1 lshift I2C1_OAR2 bis! ;  \ I2C1_OAR2_OA2    Interface address
: I2C1_OAR2_OA2MSK   ( %XXX -- ) 8 lshift I2C1_OAR2 bis! ;  \ I2C1_OAR2_OA2MSK    Own Address 2 masks
: I2C1_OAR2_OA2EN   %1 15 lshift I2C1_OAR2 bis! ;  \ I2C1_OAR2_OA2EN    Own Address 2 enable

\ I2C1_TIMINGR (read-write)
: I2C1_TIMINGR_SCLL   ( %XXXXXXXX -- ) 0 lshift I2C1_TIMINGR bis! ;  \ I2C1_TIMINGR_SCLL    SCL low period master  mode
: I2C1_TIMINGR_SCLH   ( %XXXXXXXX -- ) 8 lshift I2C1_TIMINGR bis! ;  \ I2C1_TIMINGR_SCLH    SCL high period master  mode
: I2C1_TIMINGR_SDADEL   ( %XXXX -- ) 16 lshift I2C1_TIMINGR bis! ;  \ I2C1_TIMINGR_SDADEL    Data hold time
: I2C1_TIMINGR_SCLDEL   ( %XXXX -- ) 20 lshift I2C1_TIMINGR bis! ;  \ I2C1_TIMINGR_SCLDEL    Data setup time
: I2C1_TIMINGR_PRESC   ( %XXXX -- ) 28 lshift I2C1_TIMINGR bis! ;  \ I2C1_TIMINGR_PRESC    Timing prescaler

\ I2C1_TIMEOUTR (read-write)
: I2C1_TIMEOUTR_TIMEOUTA   ( %XXXXXXXXXXX -- ) 0 lshift I2C1_TIMEOUTR bis! ;  \ I2C1_TIMEOUTR_TIMEOUTA    Bus timeout A
: I2C1_TIMEOUTR_TIDLE   %1 12 lshift I2C1_TIMEOUTR bis! ;  \ I2C1_TIMEOUTR_TIDLE    Idle clock timeout  detection
: I2C1_TIMEOUTR_TIMOUTEN   %1 15 lshift I2C1_TIMEOUTR bis! ;  \ I2C1_TIMEOUTR_TIMOUTEN    Clock timeout enable
: I2C1_TIMEOUTR_TIMEOUTB   ( %XXXXXXXXXXX -- ) 16 lshift I2C1_TIMEOUTR bis! ;  \ I2C1_TIMEOUTR_TIMEOUTB    Bus timeout B
: I2C1_TIMEOUTR_TEXTEN   %1 31 lshift I2C1_TIMEOUTR bis! ;  \ I2C1_TIMEOUTR_TEXTEN    Extended clock timeout  enable

\ I2C1_ISR ()
: I2C1_ISR_ADDCODE   ( %XXXXXXX -- ) 17 lshift I2C1_ISR bis! ;  \ I2C1_ISR_ADDCODE    Address match code Slave  mode
: I2C1_ISR_DIR   %1 16 lshift I2C1_ISR bis! ;  \ I2C1_ISR_DIR    Transfer direction Slave  mode
: I2C1_ISR_BUSY   %1 15 lshift I2C1_ISR bis! ;  \ I2C1_ISR_BUSY    Bus busy
: I2C1_ISR_ALERT   %1 13 lshift I2C1_ISR bis! ;  \ I2C1_ISR_ALERT    SMBus alert
: I2C1_ISR_TIMEOUT   %1 12 lshift I2C1_ISR bis! ;  \ I2C1_ISR_TIMEOUT    Timeout or t_low detection  flag
: I2C1_ISR_PECERR   %1 11 lshift I2C1_ISR bis! ;  \ I2C1_ISR_PECERR    PEC Error in reception
: I2C1_ISR_OVR   %1 10 lshift I2C1_ISR bis! ;  \ I2C1_ISR_OVR    Overrun/Underrun slave  mode
: I2C1_ISR_ARLO   %1 9 lshift I2C1_ISR bis! ;  \ I2C1_ISR_ARLO    Arbitration lost
: I2C1_ISR_BERR   %1 8 lshift I2C1_ISR bis! ;  \ I2C1_ISR_BERR    Bus error
: I2C1_ISR_TCR   %1 7 lshift I2C1_ISR bis! ;  \ I2C1_ISR_TCR    Transfer Complete Reload
: I2C1_ISR_TC   %1 6 lshift I2C1_ISR bis! ;  \ I2C1_ISR_TC    Transfer Complete master  mode
: I2C1_ISR_STOPF   %1 5 lshift I2C1_ISR bis! ;  \ I2C1_ISR_STOPF    Stop detection flag
: I2C1_ISR_NACKF   %1 4 lshift I2C1_ISR bis! ;  \ I2C1_ISR_NACKF    Not acknowledge received  flag
: I2C1_ISR_ADDR   %1 3 lshift I2C1_ISR bis! ;  \ I2C1_ISR_ADDR    Address matched slave  mode
: I2C1_ISR_RXNE   %1 2 lshift I2C1_ISR bis! ;  \ I2C1_ISR_RXNE    Receive data register not empty  receivers
: I2C1_ISR_TXIS   %1 1 lshift I2C1_ISR bis! ;  \ I2C1_ISR_TXIS    Transmit interrupt status  transmitters
: I2C1_ISR_TXE   %1 0 lshift I2C1_ISR bis! ;  \ I2C1_ISR_TXE    Transmit data register empty  transmitters

\ I2C1_ICR (write-only)
: I2C1_ICR_ALERTCF   %1 13 lshift I2C1_ICR bis! ;  \ I2C1_ICR_ALERTCF    Alert flag clear
: I2C1_ICR_TIMOUTCF   %1 12 lshift I2C1_ICR bis! ;  \ I2C1_ICR_TIMOUTCF    Timeout detection flag  clear
: I2C1_ICR_PECCF   %1 11 lshift I2C1_ICR bis! ;  \ I2C1_ICR_PECCF    PEC Error flag clear
: I2C1_ICR_OVRCF   %1 10 lshift I2C1_ICR bis! ;  \ I2C1_ICR_OVRCF    Overrun/Underrun flag  clear
: I2C1_ICR_ARLOCF   %1 9 lshift I2C1_ICR bis! ;  \ I2C1_ICR_ARLOCF    Arbitration lost flag  clear
: I2C1_ICR_BERRCF   %1 8 lshift I2C1_ICR bis! ;  \ I2C1_ICR_BERRCF    Bus error flag clear
: I2C1_ICR_STOPCF   %1 5 lshift I2C1_ICR bis! ;  \ I2C1_ICR_STOPCF    Stop detection flag clear
: I2C1_ICR_NACKCF   %1 4 lshift I2C1_ICR bis! ;  \ I2C1_ICR_NACKCF    Not Acknowledge flag clear
: I2C1_ICR_ADDRCF   %1 3 lshift I2C1_ICR bis! ;  \ I2C1_ICR_ADDRCF    Address Matched flag clear

\ I2C1_PECR (read-only)
: I2C1_PECR_PEC   ( %XXXXXXXX -- ) 0 lshift I2C1_PECR bis! ;  \ I2C1_PECR_PEC    Packet error checking  register

\ I2C1_RXDR (read-only)
: I2C1_RXDR_RXDATA   ( %XXXXXXXX -- ) 0 lshift I2C1_RXDR bis! ;  \ I2C1_RXDR_RXDATA    8-bit receive data

\ I2C1_TXDR (read-write)
: I2C1_TXDR_TXDATA   ( %XXXXXXXX -- ) 0 lshift I2C1_TXDR bis! ;  \ I2C1_TXDR_TXDATA    8-bit transmit data

\ I2C2_CR1 ()
: I2C2_CR1_PE   %1 0 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_PE    Peripheral enable
: I2C2_CR1_TXIE   %1 1 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_TXIE    TX Interrupt enable
: I2C2_CR1_RXIE   %1 2 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_RXIE    RX Interrupt enable
: I2C2_CR1_ADDRIE   %1 3 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_ADDRIE    Address match interrupt enable slave  only
: I2C2_CR1_NACKIE   %1 4 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_NACKIE    Not acknowledge received interrupt  enable
: I2C2_CR1_STOPIE   %1 5 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_STOPIE    STOP detection Interrupt  enable
: I2C2_CR1_TCIE   %1 6 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_TCIE    Transfer Complete interrupt  enable
: I2C2_CR1_ERRIE   %1 7 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_ERRIE    Error interrupts enable
: I2C2_CR1_DNF   ( %XXXX -- ) 8 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_DNF    Digital noise filter
: I2C2_CR1_ANFOFF   %1 12 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_ANFOFF    Analog noise filter OFF
: I2C2_CR1_SWRST   %1 13 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_SWRST    Software reset
: I2C2_CR1_TXDMAEN   %1 14 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_TXDMAEN    DMA transmission requests  enable
: I2C2_CR1_RXDMAEN   %1 15 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_RXDMAEN    DMA reception requests  enable
: I2C2_CR1_SBC   %1 16 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_SBC    Slave byte control
: I2C2_CR1_NOSTRETCH   %1 17 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_NOSTRETCH    Clock stretching disable
: I2C2_CR1_WUPEN   %1 18 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_WUPEN    Wakeup from STOP enable
: I2C2_CR1_GCEN   %1 19 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_GCEN    General call enable
: I2C2_CR1_SMBHEN   %1 20 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_SMBHEN    SMBus Host address enable
: I2C2_CR1_SMBDEN   %1 21 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_SMBDEN    SMBus Device Default address  enable
: I2C2_CR1_ALERTEN   %1 22 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_ALERTEN    SMBUS alert enable
: I2C2_CR1_PECEN   %1 23 lshift I2C2_CR1 bis! ;  \ I2C2_CR1_PECEN    PEC enable

\ I2C2_CR2 (read-write)
: I2C2_CR2_PECBYTE   %1 26 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_PECBYTE    Packet error checking byte
: I2C2_CR2_AUTOEND   %1 25 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_AUTOEND    Automatic end mode master  mode
: I2C2_CR2_RELOAD   %1 24 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_RELOAD    NBYTES reload mode
: I2C2_CR2_NBYTES   ( %XXXXXXXX -- ) 16 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_NBYTES    Number of bytes
: I2C2_CR2_NACK   %1 15 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_NACK    NACK generation slave  mode
: I2C2_CR2_STOP   %1 14 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_STOP    Stop generation master  mode
: I2C2_CR2_START   %1 13 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_START    Start generation
: I2C2_CR2_HEAD10R   %1 12 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_HEAD10R    10-bit address header only read  direction master receiver mode
: I2C2_CR2_ADD10   %1 11 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_ADD10    10-bit addressing mode master  mode
: I2C2_CR2_RD_WRN   %1 10 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_RD_WRN    Transfer direction master  mode
: I2C2_CR2_SADD8   ( %XX -- ) 8 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_SADD8    Slave address bit 9:8 master  mode
: I2C2_CR2_SADD1   ( %XXXXXXX -- ) 1 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_SADD1    Slave address bit 7:1 master  mode
: I2C2_CR2_SADD0   %1 0 lshift I2C2_CR2 bis! ;  \ I2C2_CR2_SADD0    Slave address bit 0 master  mode

\ I2C2_OAR1 (read-write)
: I2C2_OAR1_OA1_0   %1 0 lshift I2C2_OAR1 bis! ;  \ I2C2_OAR1_OA1_0    Interface address
: I2C2_OAR1_OA1_1   ( %XXXXXXX -- ) 1 lshift I2C2_OAR1 bis! ;  \ I2C2_OAR1_OA1_1    Interface address
: I2C2_OAR1_OA1_8   ( %XX -- ) 8 lshift I2C2_OAR1 bis! ;  \ I2C2_OAR1_OA1_8    Interface address
: I2C2_OAR1_OA1MODE   %1 10 lshift I2C2_OAR1 bis! ;  \ I2C2_OAR1_OA1MODE    Own Address 1 10-bit mode
: I2C2_OAR1_OA1EN   %1 15 lshift I2C2_OAR1 bis! ;  \ I2C2_OAR1_OA1EN    Own Address 1 enable

\ I2C2_OAR2 (read-write)
: I2C2_OAR2_OA2   ( %XXXXXXX -- ) 1 lshift I2C2_OAR2 bis! ;  \ I2C2_OAR2_OA2    Interface address
: I2C2_OAR2_OA2MSK   ( %XXX -- ) 8 lshift I2C2_OAR2 bis! ;  \ I2C2_OAR2_OA2MSK    Own Address 2 masks
: I2C2_OAR2_OA2EN   %1 15 lshift I2C2_OAR2 bis! ;  \ I2C2_OAR2_OA2EN    Own Address 2 enable

\ I2C2_TIMINGR (read-write)
: I2C2_TIMINGR_SCLL   ( %XXXXXXXX -- ) 0 lshift I2C2_TIMINGR bis! ;  \ I2C2_TIMINGR_SCLL    SCL low period master  mode
: I2C2_TIMINGR_SCLH   ( %XXXXXXXX -- ) 8 lshift I2C2_TIMINGR bis! ;  \ I2C2_TIMINGR_SCLH    SCL high period master  mode
: I2C2_TIMINGR_SDADEL   ( %XXXX -- ) 16 lshift I2C2_TIMINGR bis! ;  \ I2C2_TIMINGR_SDADEL    Data hold time
: I2C2_TIMINGR_SCLDEL   ( %XXXX -- ) 20 lshift I2C2_TIMINGR bis! ;  \ I2C2_TIMINGR_SCLDEL    Data setup time
: I2C2_TIMINGR_PRESC   ( %XXXX -- ) 28 lshift I2C2_TIMINGR bis! ;  \ I2C2_TIMINGR_PRESC    Timing prescaler

\ I2C2_TIMEOUTR (read-write)
: I2C2_TIMEOUTR_TIMEOUTA   ( %XXXXXXXXXXX -- ) 0 lshift I2C2_TIMEOUTR bis! ;  \ I2C2_TIMEOUTR_TIMEOUTA    Bus timeout A
: I2C2_TIMEOUTR_TIDLE   %1 12 lshift I2C2_TIMEOUTR bis! ;  \ I2C2_TIMEOUTR_TIDLE    Idle clock timeout  detection
: I2C2_TIMEOUTR_TIMOUTEN   %1 15 lshift I2C2_TIMEOUTR bis! ;  \ I2C2_TIMEOUTR_TIMOUTEN    Clock timeout enable
: I2C2_TIMEOUTR_TIMEOUTB   ( %XXXXXXXXXXX -- ) 16 lshift I2C2_TIMEOUTR bis! ;  \ I2C2_TIMEOUTR_TIMEOUTB    Bus timeout B
: I2C2_TIMEOUTR_TEXTEN   %1 31 lshift I2C2_TIMEOUTR bis! ;  \ I2C2_TIMEOUTR_TEXTEN    Extended clock timeout  enable

\ I2C2_ISR ()
: I2C2_ISR_ADDCODE   ( %XXXXXXX -- ) 17 lshift I2C2_ISR bis! ;  \ I2C2_ISR_ADDCODE    Address match code Slave  mode
: I2C2_ISR_DIR   %1 16 lshift I2C2_ISR bis! ;  \ I2C2_ISR_DIR    Transfer direction Slave  mode
: I2C2_ISR_BUSY   %1 15 lshift I2C2_ISR bis! ;  \ I2C2_ISR_BUSY    Bus busy
: I2C2_ISR_ALERT   %1 13 lshift I2C2_ISR bis! ;  \ I2C2_ISR_ALERT    SMBus alert
: I2C2_ISR_TIMEOUT   %1 12 lshift I2C2_ISR bis! ;  \ I2C2_ISR_TIMEOUT    Timeout or t_low detection  flag
: I2C2_ISR_PECERR   %1 11 lshift I2C2_ISR bis! ;  \ I2C2_ISR_PECERR    PEC Error in reception
: I2C2_ISR_OVR   %1 10 lshift I2C2_ISR bis! ;  \ I2C2_ISR_OVR    Overrun/Underrun slave  mode
: I2C2_ISR_ARLO   %1 9 lshift I2C2_ISR bis! ;  \ I2C2_ISR_ARLO    Arbitration lost
: I2C2_ISR_BERR   %1 8 lshift I2C2_ISR bis! ;  \ I2C2_ISR_BERR    Bus error
: I2C2_ISR_TCR   %1 7 lshift I2C2_ISR bis! ;  \ I2C2_ISR_TCR    Transfer Complete Reload
: I2C2_ISR_TC   %1 6 lshift I2C2_ISR bis! ;  \ I2C2_ISR_TC    Transfer Complete master  mode
: I2C2_ISR_STOPF   %1 5 lshift I2C2_ISR bis! ;  \ I2C2_ISR_STOPF    Stop detection flag
: I2C2_ISR_NACKF   %1 4 lshift I2C2_ISR bis! ;  \ I2C2_ISR_NACKF    Not acknowledge received  flag
: I2C2_ISR_ADDR   %1 3 lshift I2C2_ISR bis! ;  \ I2C2_ISR_ADDR    Address matched slave  mode
: I2C2_ISR_RXNE   %1 2 lshift I2C2_ISR bis! ;  \ I2C2_ISR_RXNE    Receive data register not empty  receivers
: I2C2_ISR_TXIS   %1 1 lshift I2C2_ISR bis! ;  \ I2C2_ISR_TXIS    Transmit interrupt status  transmitters
: I2C2_ISR_TXE   %1 0 lshift I2C2_ISR bis! ;  \ I2C2_ISR_TXE    Transmit data register empty  transmitters

\ I2C2_ICR (write-only)
: I2C2_ICR_ALERTCF   %1 13 lshift I2C2_ICR bis! ;  \ I2C2_ICR_ALERTCF    Alert flag clear
: I2C2_ICR_TIMOUTCF   %1 12 lshift I2C2_ICR bis! ;  \ I2C2_ICR_TIMOUTCF    Timeout detection flag  clear
: I2C2_ICR_PECCF   %1 11 lshift I2C2_ICR bis! ;  \ I2C2_ICR_PECCF    PEC Error flag clear
: I2C2_ICR_OVRCF   %1 10 lshift I2C2_ICR bis! ;  \ I2C2_ICR_OVRCF    Overrun/Underrun flag  clear
: I2C2_ICR_ARLOCF   %1 9 lshift I2C2_ICR bis! ;  \ I2C2_ICR_ARLOCF    Arbitration lost flag  clear
: I2C2_ICR_BERRCF   %1 8 lshift I2C2_ICR bis! ;  \ I2C2_ICR_BERRCF    Bus error flag clear
: I2C2_ICR_STOPCF   %1 5 lshift I2C2_ICR bis! ;  \ I2C2_ICR_STOPCF    Stop detection flag clear
: I2C2_ICR_NACKCF   %1 4 lshift I2C2_ICR bis! ;  \ I2C2_ICR_NACKCF    Not Acknowledge flag clear
: I2C2_ICR_ADDRCF   %1 3 lshift I2C2_ICR bis! ;  \ I2C2_ICR_ADDRCF    Address Matched flag clear

\ I2C2_PECR (read-only)
: I2C2_PECR_PEC   ( %XXXXXXXX -- ) 0 lshift I2C2_PECR bis! ;  \ I2C2_PECR_PEC    Packet error checking  register

\ I2C2_RXDR (read-only)
: I2C2_RXDR_RXDATA   ( %XXXXXXXX -- ) 0 lshift I2C2_RXDR bis! ;  \ I2C2_RXDR_RXDATA    8-bit receive data

\ I2C2_TXDR (read-write)
: I2C2_TXDR_TXDATA   ( %XXXXXXXX -- ) 0 lshift I2C2_TXDR bis! ;  \ I2C2_TXDR_TXDATA    8-bit transmit data

\ IWDG_KR (write-only)
: IWDG_KR_KEY   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift IWDG_KR bis! ;  \ IWDG_KR_KEY    Key value

\ IWDG_PR (read-write)
: IWDG_PR_PR   ( %XXX -- ) 0 lshift IWDG_PR bis! ;  \ IWDG_PR_PR    Prescaler divider

\ IWDG_RLR (read-write)
: IWDG_RLR_RL   ( %XXXXXXXXXXX -- ) 0 lshift IWDG_RLR bis! ;  \ IWDG_RLR_RL    Watchdog counter reload  value

\ IWDG_SR (read-only)
: IWDG_SR_PVU   %1 0 lshift IWDG_SR bis! ;  \ IWDG_SR_PVU    Watchdog prescaler value  update
: IWDG_SR_RVU   %1 1 lshift IWDG_SR bis! ;  \ IWDG_SR_RVU    Watchdog counter reload value  update
: IWDG_SR_WVU   %1 2 lshift IWDG_SR bis! ;  \ IWDG_SR_WVU    Watchdog counter window value  update

\ IWDG_WINR (read-write)
: IWDG_WINR_WIN   ( %XXXXXXXXXXX -- ) 0 lshift IWDG_WINR bis! ;  \ IWDG_WINR_WIN    Watchdog counter window  value

\ WWDG_CR (read-write)
: WWDG_CR_WDGA   %1 7 lshift WWDG_CR bis! ;  \ WWDG_CR_WDGA    Activation bit
: WWDG_CR_T   ( %XXXXXXX -- ) 0 lshift WWDG_CR bis! ;  \ WWDG_CR_T    7-bit counter

\ WWDG_CFR (read-write)
: WWDG_CFR_EWI   %1 9 lshift WWDG_CFR bis! ;  \ WWDG_CFR_EWI    Early wakeup interrupt
: WWDG_CFR_WDGTB   ( %XX -- ) 7 lshift WWDG_CFR bis! ;  \ WWDG_CFR_WDGTB    Timer base
: WWDG_CFR_W   ( %XXXXXXX -- ) 0 lshift WWDG_CFR bis! ;  \ WWDG_CFR_W    7-bit window value

\ WWDG_SR (read-write)
: WWDG_SR_EWIF   %1 0 lshift WWDG_SR bis! ;  \ WWDG_SR_EWIF    Early wakeup interrupt  flag

\ TIM1_CR1 (read-write)
: TIM1_CR1_CKD   ( %XX -- ) 8 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_CKD    Clock division
: TIM1_CR1_ARPE   %1 7 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_ARPE    Auto-reload preload enable
: TIM1_CR1_CMS   ( %XX -- ) 5 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_CMS    Center-aligned mode  selection
: TIM1_CR1_DIR   %1 4 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_DIR    Direction
: TIM1_CR1_OPM   %1 3 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_OPM    One-pulse mode
: TIM1_CR1_URS   %1 2 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_URS    Update request source
: TIM1_CR1_UDIS   %1 1 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_UDIS    Update disable
: TIM1_CR1_CEN   %1 0 lshift TIM1_CR1 bis! ;  \ TIM1_CR1_CEN    Counter enable

\ TIM1_CR2 (read-write)
: TIM1_CR2_OIS4   %1 14 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS4    Output Idle state 4
: TIM1_CR2_OIS3N   %1 13 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS3N    Output Idle state 3
: TIM1_CR2_OIS3   %1 12 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS3    Output Idle state 3
: TIM1_CR2_OIS2N   %1 11 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS2N    Output Idle state 2
: TIM1_CR2_OIS2   %1 10 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS2    Output Idle state 2
: TIM1_CR2_OIS1N   %1 9 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS1N    Output Idle state 1
: TIM1_CR2_OIS1   %1 8 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_OIS1    Output Idle state 1
: TIM1_CR2_TI1S   %1 7 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_TI1S    TI1 selection
: TIM1_CR2_MMS   ( %XXX -- ) 4 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_MMS    Master mode selection
: TIM1_CR2_CCDS   %1 3 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_CCDS    Capture/compare DMA  selection
: TIM1_CR2_CCUS   %1 2 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_CCUS    Capture/compare control update  selection
: TIM1_CR2_CCPC   %1 0 lshift TIM1_CR2 bis! ;  \ TIM1_CR2_CCPC    Capture/compare preloaded  control

\ TIM1_SMCR (read-write)
: TIM1_SMCR_ETP   %1 15 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_ETP    External trigger polarity
: TIM1_SMCR_ECE   %1 14 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_ECE    External clock enable
: TIM1_SMCR_ETPS   ( %XX -- ) 12 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_ETPS    External trigger prescaler
: TIM1_SMCR_ETF   ( %XXXX -- ) 8 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_ETF    External trigger filter
: TIM1_SMCR_MSM   %1 7 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_MSM    Master/Slave mode
: TIM1_SMCR_TS   ( %XXX -- ) 4 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_TS    Trigger selection
: TIM1_SMCR_SMS   ( %XXX -- ) 0 lshift TIM1_SMCR bis! ;  \ TIM1_SMCR_SMS    Slave mode selection

\ TIM1_DIER (read-write)
: TIM1_DIER_TDE   %1 14 lshift TIM1_DIER bis! ;  \ TIM1_DIER_TDE    Trigger DMA request enable
: TIM1_DIER_COMDE   %1 13 lshift TIM1_DIER bis! ;  \ TIM1_DIER_COMDE    Reserved
: TIM1_DIER_CC4DE   %1 12 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM1_DIER_CC3DE   %1 11 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM1_DIER_CC2DE   %1 10 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM1_DIER_CC1DE   %1 9 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM1_DIER_UDE   %1 8 lshift TIM1_DIER bis! ;  \ TIM1_DIER_UDE    Update DMA request enable
: TIM1_DIER_BIE   %1 7 lshift TIM1_DIER bis! ;  \ TIM1_DIER_BIE    Break interrupt enable
: TIM1_DIER_TIE   %1 6 lshift TIM1_DIER bis! ;  \ TIM1_DIER_TIE    Trigger interrupt enable
: TIM1_DIER_COMIE   %1 5 lshift TIM1_DIER bis! ;  \ TIM1_DIER_COMIE    COM interrupt enable
: TIM1_DIER_CC4IE   %1 4 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM1_DIER_CC3IE   %1 3 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM1_DIER_CC2IE   %1 2 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM1_DIER_CC1IE   %1 1 lshift TIM1_DIER bis! ;  \ TIM1_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM1_DIER_UIE   %1 0 lshift TIM1_DIER bis! ;  \ TIM1_DIER_UIE    Update interrupt enable

\ TIM1_SR (read-write)
: TIM1_SR_CC4OF   %1 12 lshift TIM1_SR bis! ;  \ TIM1_SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM1_SR_CC3OF   %1 11 lshift TIM1_SR bis! ;  \ TIM1_SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM1_SR_CC2OF   %1 10 lshift TIM1_SR bis! ;  \ TIM1_SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM1_SR_CC1OF   %1 9 lshift TIM1_SR bis! ;  \ TIM1_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM1_SR_BIF   %1 7 lshift TIM1_SR bis! ;  \ TIM1_SR_BIF    Break interrupt flag
: TIM1_SR_TIF   %1 6 lshift TIM1_SR bis! ;  \ TIM1_SR_TIF    Trigger interrupt flag
: TIM1_SR_COMIF   %1 5 lshift TIM1_SR bis! ;  \ TIM1_SR_COMIF    COM interrupt flag
: TIM1_SR_CC4IF   %1 4 lshift TIM1_SR bis! ;  \ TIM1_SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM1_SR_CC3IF   %1 3 lshift TIM1_SR bis! ;  \ TIM1_SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM1_SR_CC2IF   %1 2 lshift TIM1_SR bis! ;  \ TIM1_SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM1_SR_CC1IF   %1 1 lshift TIM1_SR bis! ;  \ TIM1_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM1_SR_UIF   %1 0 lshift TIM1_SR bis! ;  \ TIM1_SR_UIF    Update interrupt flag

\ TIM1_EGR (write-only)
: TIM1_EGR_BG   %1 7 lshift TIM1_EGR bis! ;  \ TIM1_EGR_BG    Break generation
: TIM1_EGR_TG   %1 6 lshift TIM1_EGR bis! ;  \ TIM1_EGR_TG    Trigger generation
: TIM1_EGR_COMG   %1 5 lshift TIM1_EGR bis! ;  \ TIM1_EGR_COMG    Capture/Compare control update  generation
: TIM1_EGR_CC4G   %1 4 lshift TIM1_EGR bis! ;  \ TIM1_EGR_CC4G    Capture/compare 4  generation
: TIM1_EGR_CC3G   %1 3 lshift TIM1_EGR bis! ;  \ TIM1_EGR_CC3G    Capture/compare 3  generation
: TIM1_EGR_CC2G   %1 2 lshift TIM1_EGR bis! ;  \ TIM1_EGR_CC2G    Capture/compare 2  generation
: TIM1_EGR_CC1G   %1 1 lshift TIM1_EGR bis! ;  \ TIM1_EGR_CC1G    Capture/compare 1  generation
: TIM1_EGR_UG   %1 0 lshift TIM1_EGR bis! ;  \ TIM1_EGR_UG    Update generation

\ TIM1_CCMR1_Output (read-write)
: TIM1_CCMR1_Output_OC2CE   %1 15 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC2CE    Output Compare 2 clear  enable
: TIM1_CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC2M    Output Compare 2 mode
: TIM1_CCMR1_Output_OC2PE   %1 11 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM1_CCMR1_Output_OC2FE   %1 10 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM1_CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM1_CCMR1_Output_OC1CE   %1 7 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC1CE    Output Compare 1 clear  enable
: TIM1_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC1M    Output Compare 1 mode
: TIM1_CCMR1_Output_OC1PE   %1 3 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM1_CCMR1_Output_OC1FE   %1 2 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM1_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM1_CCMR1_Output bis! ;  \ TIM1_CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM1_CCMR1_Input (read-write)
: TIM1_CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_IC2F    Input capture 2 filter
: TIM1_CCMR1_Input_IC2PCS   ( %XX -- ) 10 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_IC2PCS    Input capture 2 prescaler
: TIM1_CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM1_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_IC1F    Input capture 1 filter
: TIM1_CCMR1_Input_IC1PCS   ( %XX -- ) 2 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_IC1PCS    Input capture 1 prescaler
: TIM1_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM1_CCMR1_Input bis! ;  \ TIM1_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM1_CCMR2_Output (read-write)
: TIM1_CCMR2_Output_OC4CE   %1 15 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM1_CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC4M    Output compare 4 mode
: TIM1_CCMR2_Output_OC4PE   %1 11 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM1_CCMR2_Output_OC4FE   %1 10 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM1_CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM1_CCMR2_Output_OC3CE   %1 7 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM1_CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC3M    Output compare 3 mode
: TIM1_CCMR2_Output_OC3PE   %1 3 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM1_CCMR2_Output_OC3FE   %1 2 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM1_CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM1_CCMR2_Output bis! ;  \ TIM1_CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM1_CCMR2_Input (read-write)
: TIM1_CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_IC4F    Input capture 4 filter
: TIM1_CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM1_CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM1_CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_IC3F    Input capture 3 filter
: TIM1_CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM1_CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM1_CCMR2_Input bis! ;  \ TIM1_CCMR2_Input_CC3S    Capture/compare 3  selection

\ TIM1_CCER (read-write)
: TIM1_CCER_CC4P   %1 13 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM1_CCER_CC4E   %1 12 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC4E    Capture/Compare 4 output  enable
: TIM1_CCER_CC3NP   %1 11 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM1_CCER_CC3NE   %1 10 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC3NE    Capture/Compare 3 complementary output  enable
: TIM1_CCER_CC3P   %1 9 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM1_CCER_CC3E   %1 8 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC3E    Capture/Compare 3 output  enable
: TIM1_CCER_CC2NP   %1 7 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM1_CCER_CC2NE   %1 6 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC2NE    Capture/Compare 2 complementary output  enable
: TIM1_CCER_CC2P   %1 5 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM1_CCER_CC2E   %1 4 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC2E    Capture/Compare 2 output  enable
: TIM1_CCER_CC1NP   %1 3 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM1_CCER_CC1NE   %1 2 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM1_CCER_CC1P   %1 1 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM1_CCER_CC1E   %1 0 lshift TIM1_CCER bis! ;  \ TIM1_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM1_CNT (read-write)
: TIM1_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_CNT bis! ;  \ TIM1_CNT_CNT    counter value

\ TIM1_PSC (read-write)
: TIM1_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_PSC bis! ;  \ TIM1_PSC_PSC    Prescaler value

\ TIM1_ARR (read-write)
: TIM1_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_ARR bis! ;  \ TIM1_ARR_ARR    Auto-reload value

\ TIM1_RCR (read-write)
: TIM1_RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM1_RCR bis! ;  \ TIM1_RCR_REP    Repetition counter value

\ TIM1_CCR1 (read-write)
: TIM1_CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_CCR1 bis! ;  \ TIM1_CCR1_CCR1    Capture/Compare 1 value

\ TIM1_CCR2 (read-write)
: TIM1_CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_CCR2 bis! ;  \ TIM1_CCR2_CCR2    Capture/Compare 2 value

\ TIM1_CCR3 (read-write)
: TIM1_CCR3_CCR3   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_CCR3 bis! ;  \ TIM1_CCR3_CCR3    Capture/Compare 3 value

\ TIM1_CCR4 (read-write)
: TIM1_CCR4_CCR4   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_CCR4 bis! ;  \ TIM1_CCR4_CCR4    Capture/Compare 3 value

\ TIM1_BDTR (read-write)
: TIM1_BDTR_MOE   %1 15 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_MOE    Main output enable
: TIM1_BDTR_AOE   %1 14 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_AOE    Automatic output enable
: TIM1_BDTR_BKP   %1 13 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_BKP    Break polarity
: TIM1_BDTR_BKE   %1 12 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_BKE    Break enable
: TIM1_BDTR_OSSR   %1 11 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_OSSR    Off-state selection for Run  mode
: TIM1_BDTR_OSSI   %1 10 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_OSSI    Off-state selection for Idle  mode
: TIM1_BDTR_LOCK   ( %XX -- ) 8 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_LOCK    Lock configuration
: TIM1_BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM1_BDTR bis! ;  \ TIM1_BDTR_DTG    Dead-time generator setup

\ TIM1_DCR (read-write)
: TIM1_DCR_DBL   ( %XXXXX -- ) 8 lshift TIM1_DCR bis! ;  \ TIM1_DCR_DBL    DMA burst length
: TIM1_DCR_DBA   ( %XXXXX -- ) 0 lshift TIM1_DCR bis! ;  \ TIM1_DCR_DBA    DMA base address

\ TIM1_DMAR (read-write)
: TIM1_DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM1_DMAR bis! ;  \ TIM1_DMAR_DMAB    DMA register for burst  accesses

\ TIM3_CR1 (read-write)
: TIM3_CR1_CKD   ( %XX -- ) 8 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_CKD    Clock division
: TIM3_CR1_ARPE   %1 7 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_ARPE    Auto-reload preload enable
: TIM3_CR1_CMS   ( %XX -- ) 5 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_CMS    Center-aligned mode  selection
: TIM3_CR1_DIR   %1 4 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_DIR    Direction
: TIM3_CR1_OPM   %1 3 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_OPM    One-pulse mode
: TIM3_CR1_URS   %1 2 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_URS    Update request source
: TIM3_CR1_UDIS   %1 1 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_UDIS    Update disable
: TIM3_CR1_CEN   %1 0 lshift TIM3_CR1 bis! ;  \ TIM3_CR1_CEN    Counter enable

\ TIM3_CR2 (read-write)
: TIM3_CR2_TI1S   %1 7 lshift TIM3_CR2 bis! ;  \ TIM3_CR2_TI1S    TI1 selection
: TIM3_CR2_MMS   ( %XXX -- ) 4 lshift TIM3_CR2 bis! ;  \ TIM3_CR2_MMS    Master mode selection
: TIM3_CR2_CCDS   %1 3 lshift TIM3_CR2 bis! ;  \ TIM3_CR2_CCDS    Capture/compare DMA  selection

\ TIM3_SMCR (read-write)
: TIM3_SMCR_ETP   %1 15 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_ETP    External trigger polarity
: TIM3_SMCR_ECE   %1 14 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_ECE    External clock enable
: TIM3_SMCR_ETPS   ( %XX -- ) 12 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_ETPS    External trigger prescaler
: TIM3_SMCR_ETF   ( %XXXX -- ) 8 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_ETF    External trigger filter
: TIM3_SMCR_MSM   %1 7 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_MSM    Master/Slave mode
: TIM3_SMCR_TS   ( %XXX -- ) 4 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_TS    Trigger selection
: TIM3_SMCR_SMS   ( %XXX -- ) 0 lshift TIM3_SMCR bis! ;  \ TIM3_SMCR_SMS    Slave mode selection

\ TIM3_DIER (read-write)
: TIM3_DIER_TDE   %1 14 lshift TIM3_DIER bis! ;  \ TIM3_DIER_TDE    Trigger DMA request enable
: TIM3_DIER_COMDE   %1 13 lshift TIM3_DIER bis! ;  \ TIM3_DIER_COMDE    Reserved
: TIM3_DIER_CC4DE   %1 12 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC4DE    Capture/Compare 4 DMA request  enable
: TIM3_DIER_CC3DE   %1 11 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC3DE    Capture/Compare 3 DMA request  enable
: TIM3_DIER_CC2DE   %1 10 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM3_DIER_CC1DE   %1 9 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM3_DIER_UDE   %1 8 lshift TIM3_DIER bis! ;  \ TIM3_DIER_UDE    Update DMA request enable
: TIM3_DIER_TIE   %1 6 lshift TIM3_DIER bis! ;  \ TIM3_DIER_TIE    Trigger interrupt enable
: TIM3_DIER_CC4IE   %1 4 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC4IE    Capture/Compare 4 interrupt  enable
: TIM3_DIER_CC3IE   %1 3 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC3IE    Capture/Compare 3 interrupt  enable
: TIM3_DIER_CC2IE   %1 2 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM3_DIER_CC1IE   %1 1 lshift TIM3_DIER bis! ;  \ TIM3_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM3_DIER_UIE   %1 0 lshift TIM3_DIER bis! ;  \ TIM3_DIER_UIE    Update interrupt enable

\ TIM3_SR (read-write)
: TIM3_SR_CC4OF   %1 12 lshift TIM3_SR bis! ;  \ TIM3_SR_CC4OF    Capture/Compare 4 overcapture  flag
: TIM3_SR_CC3OF   %1 11 lshift TIM3_SR bis! ;  \ TIM3_SR_CC3OF    Capture/Compare 3 overcapture  flag
: TIM3_SR_CC2OF   %1 10 lshift TIM3_SR bis! ;  \ TIM3_SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM3_SR_CC1OF   %1 9 lshift TIM3_SR bis! ;  \ TIM3_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM3_SR_TIF   %1 6 lshift TIM3_SR bis! ;  \ TIM3_SR_TIF    Trigger interrupt flag
: TIM3_SR_CC4IF   %1 4 lshift TIM3_SR bis! ;  \ TIM3_SR_CC4IF    Capture/Compare 4 interrupt  flag
: TIM3_SR_CC3IF   %1 3 lshift TIM3_SR bis! ;  \ TIM3_SR_CC3IF    Capture/Compare 3 interrupt  flag
: TIM3_SR_CC2IF   %1 2 lshift TIM3_SR bis! ;  \ TIM3_SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM3_SR_CC1IF   %1 1 lshift TIM3_SR bis! ;  \ TIM3_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM3_SR_UIF   %1 0 lshift TIM3_SR bis! ;  \ TIM3_SR_UIF    Update interrupt flag

\ TIM3_EGR (write-only)
: TIM3_EGR_TG   %1 6 lshift TIM3_EGR bis! ;  \ TIM3_EGR_TG    Trigger generation
: TIM3_EGR_CC4G   %1 4 lshift TIM3_EGR bis! ;  \ TIM3_EGR_CC4G    Capture/compare 4  generation
: TIM3_EGR_CC3G   %1 3 lshift TIM3_EGR bis! ;  \ TIM3_EGR_CC3G    Capture/compare 3  generation
: TIM3_EGR_CC2G   %1 2 lshift TIM3_EGR bis! ;  \ TIM3_EGR_CC2G    Capture/compare 2  generation
: TIM3_EGR_CC1G   %1 1 lshift TIM3_EGR bis! ;  \ TIM3_EGR_CC1G    Capture/compare 1  generation
: TIM3_EGR_UG   %1 0 lshift TIM3_EGR bis! ;  \ TIM3_EGR_UG    Update generation

\ TIM3_CCMR1_Output (read-write)
: TIM3_CCMR1_Output_OC2CE   %1 15 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC2CE    Output compare 2 clear  enable
: TIM3_CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC2M    Output compare 2 mode
: TIM3_CCMR1_Output_OC2PE   %1 11 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC2PE    Output compare 2 preload  enable
: TIM3_CCMR1_Output_OC2FE   %1 10 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC2FE    Output compare 2 fast  enable
: TIM3_CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM3_CCMR1_Output_OC1CE   %1 7 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC1CE    Output compare 1 clear  enable
: TIM3_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC1M    Output compare 1 mode
: TIM3_CCMR1_Output_OC1PE   %1 3 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC1PE    Output compare 1 preload  enable
: TIM3_CCMR1_Output_OC1FE   %1 2 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM3_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM3_CCMR1_Output bis! ;  \ TIM3_CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM3_CCMR1_Input (read-write)
: TIM3_CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_IC2F    Input capture 2 filter
: TIM3_CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM3_CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_CC2S    Capture/compare 2  selection
: TIM3_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_IC1F    Input capture 1 filter
: TIM3_CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM3_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM3_CCMR1_Input bis! ;  \ TIM3_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM3_CCMR2_Output (read-write)
: TIM3_CCMR2_Output_OC4CE   %1 15 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC4CE    Output compare 4 clear  enable
: TIM3_CCMR2_Output_OC4M   ( %XXX -- ) 12 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC4M    Output compare 4 mode
: TIM3_CCMR2_Output_OC4PE   %1 11 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC4PE    Output compare 4 preload  enable
: TIM3_CCMR2_Output_OC4FE   %1 10 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC4FE    Output compare 4 fast  enable
: TIM3_CCMR2_Output_CC4S   ( %XX -- ) 8 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_CC4S    Capture/Compare 4  selection
: TIM3_CCMR2_Output_OC3CE   %1 7 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC3CE    Output compare 3 clear  enable
: TIM3_CCMR2_Output_OC3M   ( %XXX -- ) 4 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC3M    Output compare 3 mode
: TIM3_CCMR2_Output_OC3PE   %1 3 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC3PE    Output compare 3 preload  enable
: TIM3_CCMR2_Output_OC3FE   %1 2 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_OC3FE    Output compare 3 fast  enable
: TIM3_CCMR2_Output_CC3S   ( %XX -- ) 0 lshift TIM3_CCMR2_Output bis! ;  \ TIM3_CCMR2_Output_CC3S    Capture/Compare 3  selection

\ TIM3_CCMR2_Input (read-write)
: TIM3_CCMR2_Input_IC4F   ( %XXXX -- ) 12 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_IC4F    Input capture 4 filter
: TIM3_CCMR2_Input_IC4PSC   ( %XX -- ) 10 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_IC4PSC    Input capture 4 prescaler
: TIM3_CCMR2_Input_CC4S   ( %XX -- ) 8 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_CC4S    Capture/Compare 4  selection
: TIM3_CCMR2_Input_IC3F   ( %XXXX -- ) 4 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_IC3F    Input capture 3 filter
: TIM3_CCMR2_Input_IC3PSC   ( %XX -- ) 2 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_IC3PSC    Input capture 3 prescaler
: TIM3_CCMR2_Input_CC3S   ( %XX -- ) 0 lshift TIM3_CCMR2_Input bis! ;  \ TIM3_CCMR2_Input_CC3S    Capture/Compare 3  selection

\ TIM3_CCER (read-write)
: TIM3_CCER_CC4NP   %1 15 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC4NP    Capture/Compare 4 output  Polarity
: TIM3_CCER_CC4P   %1 13 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC4P    Capture/Compare 3 output  Polarity
: TIM3_CCER_CC4E   %1 12 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC4E    Capture/Compare 4 output  enable
: TIM3_CCER_CC3NP   %1 11 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC3NP    Capture/Compare 3 output  Polarity
: TIM3_CCER_CC3P   %1 9 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC3P    Capture/Compare 3 output  Polarity
: TIM3_CCER_CC3E   %1 8 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC3E    Capture/Compare 3 output  enable
: TIM3_CCER_CC2NP   %1 7 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM3_CCER_CC2P   %1 5 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM3_CCER_CC2E   %1 4 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC2E    Capture/Compare 2 output  enable
: TIM3_CCER_CC1NP   %1 3 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM3_CCER_CC1P   %1 1 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM3_CCER_CC1E   %1 0 lshift TIM3_CCER bis! ;  \ TIM3_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM3_CNT (read-write)
: TIM3_CNT_CNT_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_CNT bis! ;  \ TIM3_CNT_CNT_H    High counter value TIM2  only
: TIM3_CNT_CNT_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_CNT bis! ;  \ TIM3_CNT_CNT_L    Low counter value

\ TIM3_PSC (read-write)
: TIM3_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_PSC bis! ;  \ TIM3_PSC_PSC    Prescaler value

\ TIM3_ARR (read-write)
: TIM3_ARR_ARR_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_ARR bis! ;  \ TIM3_ARR_ARR_H    High Auto-reload value TIM2  only
: TIM3_ARR_ARR_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_ARR bis! ;  \ TIM3_ARR_ARR_L    Low Auto-reload value

\ TIM3_CCR1 (read-write)
: TIM3_CCR1_CCR1_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_CCR1 bis! ;  \ TIM3_CCR1_CCR1_H    High Capture/Compare 1 value TIM2  only
: TIM3_CCR1_CCR1_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_CCR1 bis! ;  \ TIM3_CCR1_CCR1_L    Low Capture/Compare 1  value

\ TIM3_CCR2 (read-write)
: TIM3_CCR2_CCR2_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_CCR2 bis! ;  \ TIM3_CCR2_CCR2_H    High Capture/Compare 2 value TIM2  only
: TIM3_CCR2_CCR2_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_CCR2 bis! ;  \ TIM3_CCR2_CCR2_L    Low Capture/Compare 2  value

\ TIM3_CCR3 (read-write)
: TIM3_CCR3_CCR3_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_CCR3 bis! ;  \ TIM3_CCR3_CCR3_H    High Capture/Compare value TIM2  only
: TIM3_CCR3_CCR3_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_CCR3 bis! ;  \ TIM3_CCR3_CCR3_L    Low Capture/Compare value

\ TIM3_CCR4 (read-write)
: TIM3_CCR4_CCR4_H   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift TIM3_CCR4 bis! ;  \ TIM3_CCR4_CCR4_H    High Capture/Compare value TIM2  only
: TIM3_CCR4_CCR4_L   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_CCR4 bis! ;  \ TIM3_CCR4_CCR4_L    Low Capture/Compare value

\ TIM3_DCR (read-write)
: TIM3_DCR_DBL   ( %XXXXX -- ) 8 lshift TIM3_DCR bis! ;  \ TIM3_DCR_DBL    DMA burst length
: TIM3_DCR_DBA   ( %XXXXX -- ) 0 lshift TIM3_DCR bis! ;  \ TIM3_DCR_DBA    DMA base address

\ TIM3_DMAR (read-write)
: TIM3_DMAR_DMAR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM3_DMAR bis! ;  \ TIM3_DMAR_DMAR    DMA register for burst  accesses

\ TIM14_CR1 (read-write)
: TIM14_CR1_CKD   ( %XX -- ) 8 lshift TIM14_CR1 bis! ;  \ TIM14_CR1_CKD    Clock division
: TIM14_CR1_ARPE   %1 7 lshift TIM14_CR1 bis! ;  \ TIM14_CR1_ARPE    Auto-reload preload enable
: TIM14_CR1_URS   %1 2 lshift TIM14_CR1 bis! ;  \ TIM14_CR1_URS    Update request source
: TIM14_CR1_UDIS   %1 1 lshift TIM14_CR1 bis! ;  \ TIM14_CR1_UDIS    Update disable
: TIM14_CR1_CEN   %1 0 lshift TIM14_CR1 bis! ;  \ TIM14_CR1_CEN    Counter enable

\ TIM14_DIER (read-write)
: TIM14_DIER_CC1IE   %1 1 lshift TIM14_DIER bis! ;  \ TIM14_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM14_DIER_UIE   %1 0 lshift TIM14_DIER bis! ;  \ TIM14_DIER_UIE    Update interrupt enable

\ TIM14_SR (read-write)
: TIM14_SR_CC1OF   %1 9 lshift TIM14_SR bis! ;  \ TIM14_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM14_SR_CC1IF   %1 1 lshift TIM14_SR bis! ;  \ TIM14_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM14_SR_UIF   %1 0 lshift TIM14_SR bis! ;  \ TIM14_SR_UIF    Update interrupt flag

\ TIM14_EGR (write-only)
: TIM14_EGR_CC1G   %1 1 lshift TIM14_EGR bis! ;  \ TIM14_EGR_CC1G    Capture/compare 1  generation
: TIM14_EGR_UG   %1 0 lshift TIM14_EGR bis! ;  \ TIM14_EGR_UG    Update generation

\ TIM14_CCMR1_Output (read-write)
: TIM14_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM14_CCMR1_Output bis! ;  \ TIM14_CCMR1_Output_CC1S    Capture/Compare 1  selection
: TIM14_CCMR1_Output_OC1FE   %1 2 lshift TIM14_CCMR1_Output bis! ;  \ TIM14_CCMR1_Output_OC1FE    Output compare 1 fast  enable
: TIM14_CCMR1_Output_OC1PE   %1 3 lshift TIM14_CCMR1_Output bis! ;  \ TIM14_CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM14_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM14_CCMR1_Output bis! ;  \ TIM14_CCMR1_Output_OC1M    Output Compare 1 mode

\ TIM14_CCMR1_Input (read-write)
: TIM14_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM14_CCMR1_Input bis! ;  \ TIM14_CCMR1_Input_IC1F    Input capture 1 filter
: TIM14_CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM14_CCMR1_Input bis! ;  \ TIM14_CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM14_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM14_CCMR1_Input bis! ;  \ TIM14_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM14_CCER (read-write)
: TIM14_CCER_CC1NP   %1 3 lshift TIM14_CCER bis! ;  \ TIM14_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM14_CCER_CC1P   %1 1 lshift TIM14_CCER bis! ;  \ TIM14_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM14_CCER_CC1E   %1 0 lshift TIM14_CCER bis! ;  \ TIM14_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM14_CNT (read-write)
: TIM14_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14_CNT bis! ;  \ TIM14_CNT_CNT    counter value

\ TIM14_PSC (read-write)
: TIM14_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14_PSC bis! ;  \ TIM14_PSC_PSC    Prescaler value

\ TIM14_ARR (read-write)
: TIM14_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14_ARR bis! ;  \ TIM14_ARR_ARR    Auto-reload value

\ TIM14_CCR1 (read-write)
: TIM14_CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM14_CCR1 bis! ;  \ TIM14_CCR1_CCR1    Capture/Compare 1 value

\ TIM14_OR (read-write)
: TIM14_OR_RMP   ( %XX -- ) 0 lshift TIM14_OR bis! ;  \ TIM14_OR_RMP    Timer input 1 remap

\ TIM6_CR1 (read-write)
: TIM6_CR1_ARPE   %1 7 lshift TIM6_CR1 bis! ;  \ TIM6_CR1_ARPE    Auto-reload preload enable
: TIM6_CR1_OPM   %1 3 lshift TIM6_CR1 bis! ;  \ TIM6_CR1_OPM    One-pulse mode
: TIM6_CR1_URS   %1 2 lshift TIM6_CR1 bis! ;  \ TIM6_CR1_URS    Update request source
: TIM6_CR1_UDIS   %1 1 lshift TIM6_CR1 bis! ;  \ TIM6_CR1_UDIS    Update disable
: TIM6_CR1_CEN   %1 0 lshift TIM6_CR1 bis! ;  \ TIM6_CR1_CEN    Counter enable

\ TIM6_CR2 (read-write)
: TIM6_CR2_MMS   ( %XXX -- ) 4 lshift TIM6_CR2 bis! ;  \ TIM6_CR2_MMS    Master mode selection

\ TIM6_DIER (read-write)
: TIM6_DIER_UDE   %1 8 lshift TIM6_DIER bis! ;  \ TIM6_DIER_UDE    Update DMA request enable
: TIM6_DIER_UIE   %1 0 lshift TIM6_DIER bis! ;  \ TIM6_DIER_UIE    Update interrupt enable

\ TIM6_SR (read-write)
: TIM6_SR_UIF   %1 0 lshift TIM6_SR bis! ;  \ TIM6_SR_UIF    Update interrupt flag

\ TIM6_EGR (write-only)
: TIM6_EGR_UG   %1 0 lshift TIM6_EGR bis! ;  \ TIM6_EGR_UG    Update generation

\ TIM6_CNT (read-write)
: TIM6_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6_CNT bis! ;  \ TIM6_CNT_CNT    Low counter value

\ TIM6_PSC (read-write)
: TIM6_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6_PSC bis! ;  \ TIM6_PSC_PSC    Prescaler value

\ TIM6_ARR (read-write)
: TIM6_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM6_ARR bis! ;  \ TIM6_ARR_ARR    Low Auto-reload value

\ EXTI_IMR (read-write)
: EXTI_IMR_MR0   %1 0 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR0    Interrupt Mask on line 0
: EXTI_IMR_MR1   %1 1 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR1    Interrupt Mask on line 1
: EXTI_IMR_MR2   %1 2 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR2    Interrupt Mask on line 2
: EXTI_IMR_MR3   %1 3 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR3    Interrupt Mask on line 3
: EXTI_IMR_MR4   %1 4 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR4    Interrupt Mask on line 4
: EXTI_IMR_MR5   %1 5 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR5    Interrupt Mask on line 5
: EXTI_IMR_MR6   %1 6 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR6    Interrupt Mask on line 6
: EXTI_IMR_MR7   %1 7 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR7    Interrupt Mask on line 7
: EXTI_IMR_MR8   %1 8 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR8    Interrupt Mask on line 8
: EXTI_IMR_MR9   %1 9 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR9    Interrupt Mask on line 9
: EXTI_IMR_MR10   %1 10 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR10    Interrupt Mask on line 10
: EXTI_IMR_MR11   %1 11 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR11    Interrupt Mask on line 11
: EXTI_IMR_MR12   %1 12 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR12    Interrupt Mask on line 12
: EXTI_IMR_MR13   %1 13 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR13    Interrupt Mask on line 13
: EXTI_IMR_MR14   %1 14 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR14    Interrupt Mask on line 14
: EXTI_IMR_MR15   %1 15 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR15    Interrupt Mask on line 15
: EXTI_IMR_MR16   %1 16 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR16    Interrupt Mask on line 16
: EXTI_IMR_MR17   %1 17 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR17    Interrupt Mask on line 17
: EXTI_IMR_MR18   %1 18 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR18    Interrupt Mask on line 18
: EXTI_IMR_MR19   %1 19 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR19    Interrupt Mask on line 19
: EXTI_IMR_MR20   %1 20 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR20    Interrupt Mask on line 20
: EXTI_IMR_MR21   %1 21 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR21    Interrupt Mask on line 21
: EXTI_IMR_MR22   %1 22 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR22    Interrupt Mask on line 22
: EXTI_IMR_MR23   %1 23 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR23    Interrupt Mask on line 23
: EXTI_IMR_MR24   %1 24 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR24    Interrupt Mask on line 24
: EXTI_IMR_MR25   %1 25 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR25    Interrupt Mask on line 25
: EXTI_IMR_MR26   %1 26 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR26    Interrupt Mask on line 26
: EXTI_IMR_MR27   %1 27 lshift EXTI_IMR bis! ;  \ EXTI_IMR_MR27    Interrupt Mask on line 27

\ EXTI_EMR (read-write)
: EXTI_EMR_MR0   %1 0 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR0    Event Mask on line 0
: EXTI_EMR_MR1   %1 1 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR1    Event Mask on line 1
: EXTI_EMR_MR2   %1 2 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR2    Event Mask on line 2
: EXTI_EMR_MR3   %1 3 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR3    Event Mask on line 3
: EXTI_EMR_MR4   %1 4 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR4    Event Mask on line 4
: EXTI_EMR_MR5   %1 5 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR5    Event Mask on line 5
: EXTI_EMR_MR6   %1 6 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR6    Event Mask on line 6
: EXTI_EMR_MR7   %1 7 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR7    Event Mask on line 7
: EXTI_EMR_MR8   %1 8 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR8    Event Mask on line 8
: EXTI_EMR_MR9   %1 9 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR9    Event Mask on line 9
: EXTI_EMR_MR10   %1 10 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR10    Event Mask on line 10
: EXTI_EMR_MR11   %1 11 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR11    Event Mask on line 11
: EXTI_EMR_MR12   %1 12 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR12    Event Mask on line 12
: EXTI_EMR_MR13   %1 13 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR13    Event Mask on line 13
: EXTI_EMR_MR14   %1 14 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR14    Event Mask on line 14
: EXTI_EMR_MR15   %1 15 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR15    Event Mask on line 15
: EXTI_EMR_MR16   %1 16 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR16    Event Mask on line 16
: EXTI_EMR_MR17   %1 17 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR17    Event Mask on line 17
: EXTI_EMR_MR18   %1 18 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR18    Event Mask on line 18
: EXTI_EMR_MR19   %1 19 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR19    Event Mask on line 19
: EXTI_EMR_MR20   %1 20 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR20    Event Mask on line 20
: EXTI_EMR_MR21   %1 21 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR21    Event Mask on line 21
: EXTI_EMR_MR22   %1 22 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR22    Event Mask on line 22
: EXTI_EMR_MR23   %1 23 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR23    Event Mask on line 23
: EXTI_EMR_MR24   %1 24 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR24    Event Mask on line 24
: EXTI_EMR_MR25   %1 25 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR25    Event Mask on line 25
: EXTI_EMR_MR26   %1 26 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR26    Event Mask on line 26
: EXTI_EMR_MR27   %1 27 lshift EXTI_EMR bis! ;  \ EXTI_EMR_MR27    Event Mask on line 27

\ EXTI_RTSR (read-write)
: EXTI_RTSR_TR0   %1 0 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR0    Rising trigger event configuration of  line 0
: EXTI_RTSR_TR1   %1 1 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR1    Rising trigger event configuration of  line 1
: EXTI_RTSR_TR2   %1 2 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR2    Rising trigger event configuration of  line 2
: EXTI_RTSR_TR3   %1 3 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR3    Rising trigger event configuration of  line 3
: EXTI_RTSR_TR4   %1 4 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR4    Rising trigger event configuration of  line 4
: EXTI_RTSR_TR5   %1 5 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR5    Rising trigger event configuration of  line 5
: EXTI_RTSR_TR6   %1 6 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR6    Rising trigger event configuration of  line 6
: EXTI_RTSR_TR7   %1 7 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR7    Rising trigger event configuration of  line 7
: EXTI_RTSR_TR8   %1 8 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR8    Rising trigger event configuration of  line 8
: EXTI_RTSR_TR9   %1 9 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR9    Rising trigger event configuration of  line 9
: EXTI_RTSR_TR10   %1 10 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR10    Rising trigger event configuration of  line 10
: EXTI_RTSR_TR11   %1 11 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR11    Rising trigger event configuration of  line 11
: EXTI_RTSR_TR12   %1 12 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR12    Rising trigger event configuration of  line 12
: EXTI_RTSR_TR13   %1 13 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR13    Rising trigger event configuration of  line 13
: EXTI_RTSR_TR14   %1 14 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR14    Rising trigger event configuration of  line 14
: EXTI_RTSR_TR15   %1 15 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR15    Rising trigger event configuration of  line 15
: EXTI_RTSR_TR16   %1 16 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR16    Rising trigger event configuration of  line 16
: EXTI_RTSR_TR17   %1 17 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR17    Rising trigger event configuration of  line 17
: EXTI_RTSR_TR19   %1 19 lshift EXTI_RTSR bis! ;  \ EXTI_RTSR_TR19    Rising trigger event configuration of  line 19

\ EXTI_FTSR (read-write)
: EXTI_FTSR_TR0   %1 0 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR0    Falling trigger event configuration of  line 0
: EXTI_FTSR_TR1   %1 1 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR1    Falling trigger event configuration of  line 1
: EXTI_FTSR_TR2   %1 2 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR2    Falling trigger event configuration of  line 2
: EXTI_FTSR_TR3   %1 3 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR3    Falling trigger event configuration of  line 3
: EXTI_FTSR_TR4   %1 4 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR4    Falling trigger event configuration of  line 4
: EXTI_FTSR_TR5   %1 5 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR5    Falling trigger event configuration of  line 5
: EXTI_FTSR_TR6   %1 6 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR6    Falling trigger event configuration of  line 6
: EXTI_FTSR_TR7   %1 7 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR7    Falling trigger event configuration of  line 7
: EXTI_FTSR_TR8   %1 8 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR8    Falling trigger event configuration of  line 8
: EXTI_FTSR_TR9   %1 9 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR9    Falling trigger event configuration of  line 9
: EXTI_FTSR_TR10   %1 10 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR10    Falling trigger event configuration of  line 10
: EXTI_FTSR_TR11   %1 11 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR11    Falling trigger event configuration of  line 11
: EXTI_FTSR_TR12   %1 12 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR12    Falling trigger event configuration of  line 12
: EXTI_FTSR_TR13   %1 13 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR13    Falling trigger event configuration of  line 13
: EXTI_FTSR_TR14   %1 14 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR14    Falling trigger event configuration of  line 14
: EXTI_FTSR_TR15   %1 15 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR15    Falling trigger event configuration of  line 15
: EXTI_FTSR_TR16   %1 16 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR16    Falling trigger event configuration of  line 16
: EXTI_FTSR_TR17   %1 17 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR17    Falling trigger event configuration of  line 17
: EXTI_FTSR_TR19   %1 19 lshift EXTI_FTSR bis! ;  \ EXTI_FTSR_TR19    Falling trigger event configuration of  line 19

\ EXTI_SWIER (read-write)
: EXTI_SWIER_SWIER0   %1 0 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER0    Software Interrupt on line  0
: EXTI_SWIER_SWIER1   %1 1 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER1    Software Interrupt on line  1
: EXTI_SWIER_SWIER2   %1 2 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER2    Software Interrupt on line  2
: EXTI_SWIER_SWIER3   %1 3 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER3    Software Interrupt on line  3
: EXTI_SWIER_SWIER4   %1 4 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER4    Software Interrupt on line  4
: EXTI_SWIER_SWIER5   %1 5 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER5    Software Interrupt on line  5
: EXTI_SWIER_SWIER6   %1 6 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER6    Software Interrupt on line  6
: EXTI_SWIER_SWIER7   %1 7 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER7    Software Interrupt on line  7
: EXTI_SWIER_SWIER8   %1 8 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER8    Software Interrupt on line  8
: EXTI_SWIER_SWIER9   %1 9 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER9    Software Interrupt on line  9
: EXTI_SWIER_SWIER10   %1 10 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER10    Software Interrupt on line  10
: EXTI_SWIER_SWIER11   %1 11 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER11    Software Interrupt on line  11
: EXTI_SWIER_SWIER12   %1 12 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER12    Software Interrupt on line  12
: EXTI_SWIER_SWIER13   %1 13 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER13    Software Interrupt on line  13
: EXTI_SWIER_SWIER14   %1 14 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER14    Software Interrupt on line  14
: EXTI_SWIER_SWIER15   %1 15 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER15    Software Interrupt on line  15
: EXTI_SWIER_SWIER16   %1 16 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER16    Software Interrupt on line  16
: EXTI_SWIER_SWIER17   %1 17 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER17    Software Interrupt on line  17
: EXTI_SWIER_SWIER19   %1 19 lshift EXTI_SWIER bis! ;  \ EXTI_SWIER_SWIER19    Software Interrupt on line  19

\ EXTI_PR (read-write)
: EXTI_PR_PR0   %1 0 lshift EXTI_PR bis! ;  \ EXTI_PR_PR0    Pending bit 0
: EXTI_PR_PR1   %1 1 lshift EXTI_PR bis! ;  \ EXTI_PR_PR1    Pending bit 1
: EXTI_PR_PR2   %1 2 lshift EXTI_PR bis! ;  \ EXTI_PR_PR2    Pending bit 2
: EXTI_PR_PR3   %1 3 lshift EXTI_PR bis! ;  \ EXTI_PR_PR3    Pending bit 3
: EXTI_PR_PR4   %1 4 lshift EXTI_PR bis! ;  \ EXTI_PR_PR4    Pending bit 4
: EXTI_PR_PR5   %1 5 lshift EXTI_PR bis! ;  \ EXTI_PR_PR5    Pending bit 5
: EXTI_PR_PR6   %1 6 lshift EXTI_PR bis! ;  \ EXTI_PR_PR6    Pending bit 6
: EXTI_PR_PR7   %1 7 lshift EXTI_PR bis! ;  \ EXTI_PR_PR7    Pending bit 7
: EXTI_PR_PR8   %1 8 lshift EXTI_PR bis! ;  \ EXTI_PR_PR8    Pending bit 8
: EXTI_PR_PR9   %1 9 lshift EXTI_PR bis! ;  \ EXTI_PR_PR9    Pending bit 9
: EXTI_PR_PR10   %1 10 lshift EXTI_PR bis! ;  \ EXTI_PR_PR10    Pending bit 10
: EXTI_PR_PR11   %1 11 lshift EXTI_PR bis! ;  \ EXTI_PR_PR11    Pending bit 11
: EXTI_PR_PR12   %1 12 lshift EXTI_PR bis! ;  \ EXTI_PR_PR12    Pending bit 12
: EXTI_PR_PR13   %1 13 lshift EXTI_PR bis! ;  \ EXTI_PR_PR13    Pending bit 13
: EXTI_PR_PR14   %1 14 lshift EXTI_PR bis! ;  \ EXTI_PR_PR14    Pending bit 14
: EXTI_PR_PR15   %1 15 lshift EXTI_PR bis! ;  \ EXTI_PR_PR15    Pending bit 15
: EXTI_PR_PR16   %1 16 lshift EXTI_PR bis! ;  \ EXTI_PR_PR16    Pending bit 16
: EXTI_PR_PR17   %1 17 lshift EXTI_PR bis! ;  \ EXTI_PR_PR17    Pending bit 17
: EXTI_PR_PR19   %1 19 lshift EXTI_PR bis! ;  \ EXTI_PR_PR19    Pending bit 19

\ NVIC_ISER (read-write)
: NVIC_ISER_SETENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC_ISER bis! ;  \ NVIC_ISER_SETENA    SETENA

\ NVIC_ICER (read-write)
: NVIC_ICER_CLRENA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC_ICER bis! ;  \ NVIC_ICER_CLRENA    CLRENA

\ NVIC_ISPR (read-write)
: NVIC_ISPR_SETPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC_ISPR bis! ;  \ NVIC_ISPR_SETPEND    SETPEND

\ NVIC_ICPR (read-write)
: NVIC_ICPR_CLRPEND   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift NVIC_ICPR bis! ;  \ NVIC_ICPR_CLRPEND    CLRPEND

\ NVIC_IPR0 (read-write)
: NVIC_IPR0_PRI_00   ( %XX -- ) 6 lshift NVIC_IPR0 bis! ;  \ NVIC_IPR0_PRI_00    PRI_00
: NVIC_IPR0_PRI_01   ( %XX -- ) 14 lshift NVIC_IPR0 bis! ;  \ NVIC_IPR0_PRI_01    PRI_01
: NVIC_IPR0_PRI_02   ( %XX -- ) 22 lshift NVIC_IPR0 bis! ;  \ NVIC_IPR0_PRI_02    PRI_02
: NVIC_IPR0_PRI_03   ( %XX -- ) 30 lshift NVIC_IPR0 bis! ;  \ NVIC_IPR0_PRI_03    PRI_03

\ NVIC_IPR1 (read-write)
: NVIC_IPR1_PRI_40   ( %XX -- ) 6 lshift NVIC_IPR1 bis! ;  \ NVIC_IPR1_PRI_40    PRI_40
: NVIC_IPR1_PRI_41   ( %XX -- ) 14 lshift NVIC_IPR1 bis! ;  \ NVIC_IPR1_PRI_41    PRI_41
: NVIC_IPR1_PRI_42   ( %XX -- ) 22 lshift NVIC_IPR1 bis! ;  \ NVIC_IPR1_PRI_42    PRI_42
: NVIC_IPR1_PRI_43   ( %XX -- ) 30 lshift NVIC_IPR1 bis! ;  \ NVIC_IPR1_PRI_43    PRI_43

\ NVIC_IPR2 (read-write)
: NVIC_IPR2_PRI_80   ( %XX -- ) 6 lshift NVIC_IPR2 bis! ;  \ NVIC_IPR2_PRI_80    PRI_80
: NVIC_IPR2_PRI_81   ( %XX -- ) 14 lshift NVIC_IPR2 bis! ;  \ NVIC_IPR2_PRI_81    PRI_81
: NVIC_IPR2_PRI_82   ( %XX -- ) 22 lshift NVIC_IPR2 bis! ;  \ NVIC_IPR2_PRI_82    PRI_82
: NVIC_IPR2_PRI_83   ( %XX -- ) 30 lshift NVIC_IPR2 bis! ;  \ NVIC_IPR2_PRI_83    PRI_83

\ NVIC_IPR3 (read-write)
: NVIC_IPR3_PRI_120   ( %XX -- ) 6 lshift NVIC_IPR3 bis! ;  \ NVIC_IPR3_PRI_120    PRI_120
: NVIC_IPR3_PRI_121   ( %XX -- ) 14 lshift NVIC_IPR3 bis! ;  \ NVIC_IPR3_PRI_121    PRI_121
: NVIC_IPR3_PRI_122   ( %XX -- ) 22 lshift NVIC_IPR3 bis! ;  \ NVIC_IPR3_PRI_122    PRI_122
: NVIC_IPR3_PRI_123   ( %XX -- ) 30 lshift NVIC_IPR3 bis! ;  \ NVIC_IPR3_PRI_123    PRI_123

\ NVIC_IPR4 (read-write)
: NVIC_IPR4_PRI_160   ( %XX -- ) 6 lshift NVIC_IPR4 bis! ;  \ NVIC_IPR4_PRI_160    PRI_160
: NVIC_IPR4_PRI_161   ( %XX -- ) 14 lshift NVIC_IPR4 bis! ;  \ NVIC_IPR4_PRI_161    PRI_161
: NVIC_IPR4_PRI_162   ( %XX -- ) 22 lshift NVIC_IPR4 bis! ;  \ NVIC_IPR4_PRI_162    PRI_162
: NVIC_IPR4_PRI_163   ( %XX -- ) 30 lshift NVIC_IPR4 bis! ;  \ NVIC_IPR4_PRI_163    PRI_163

\ NVIC_IPR5 (read-write)
: NVIC_IPR5_PRI_200   ( %XX -- ) 6 lshift NVIC_IPR5 bis! ;  \ NVIC_IPR5_PRI_200    PRI_200
: NVIC_IPR5_PRI_201   ( %XX -- ) 14 lshift NVIC_IPR5 bis! ;  \ NVIC_IPR5_PRI_201    PRI_201
: NVIC_IPR5_PRI_202   ( %XX -- ) 22 lshift NVIC_IPR5 bis! ;  \ NVIC_IPR5_PRI_202    PRI_202
: NVIC_IPR5_PRI_203   ( %XX -- ) 30 lshift NVIC_IPR5 bis! ;  \ NVIC_IPR5_PRI_203    PRI_203

\ NVIC_IPR6 (read-write)
: NVIC_IPR6_PRI_240   ( %XX -- ) 6 lshift NVIC_IPR6 bis! ;  \ NVIC_IPR6_PRI_240    PRI_240
: NVIC_IPR6_PRI_241   ( %XX -- ) 14 lshift NVIC_IPR6 bis! ;  \ NVIC_IPR6_PRI_241    PRI_241
: NVIC_IPR6_PRI_242   ( %XX -- ) 22 lshift NVIC_IPR6 bis! ;  \ NVIC_IPR6_PRI_242    PRI_242
: NVIC_IPR6_PRI_243   ( %XX -- ) 30 lshift NVIC_IPR6 bis! ;  \ NVIC_IPR6_PRI_243    PRI_243

\ NVIC_IPR7 (read-write)
: NVIC_IPR7_PRI_280   ( %XX -- ) 6 lshift NVIC_IPR7 bis! ;  \ NVIC_IPR7_PRI_280    PRI_280
: NVIC_IPR7_PRI_281   ( %XX -- ) 14 lshift NVIC_IPR7 bis! ;  \ NVIC_IPR7_PRI_281    PRI_281
: NVIC_IPR7_PRI_282   ( %XX -- ) 22 lshift NVIC_IPR7 bis! ;  \ NVIC_IPR7_PRI_282    PRI_282
: NVIC_IPR7_PRI_283   ( %XX -- ) 30 lshift NVIC_IPR7 bis! ;  \ NVIC_IPR7_PRI_283    PRI_283

\ DMA_ISR (read-only)
: DMA_ISR_GIF1   %1 0 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF1    Channel 1 Global interrupt  flag
: DMA_ISR_TCIF1   %1 1 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF1    Channel 1 Transfer Complete  flag
: DMA_ISR_HTIF1   %1 2 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF1    Channel 1 Half Transfer Complete  flag
: DMA_ISR_TEIF1   %1 3 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF1    Channel 1 Transfer Error  flag
: DMA_ISR_GIF2   %1 4 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF2    Channel 2 Global interrupt  flag
: DMA_ISR_TCIF2   %1 5 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF2    Channel 2 Transfer Complete  flag
: DMA_ISR_HTIF2   %1 6 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF2    Channel 2 Half Transfer Complete  flag
: DMA_ISR_TEIF2   %1 7 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF2    Channel 2 Transfer Error  flag
: DMA_ISR_GIF3   %1 8 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF3    Channel 3 Global interrupt  flag
: DMA_ISR_TCIF3   %1 9 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF3    Channel 3 Transfer Complete  flag
: DMA_ISR_HTIF3   %1 10 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF3    Channel 3 Half Transfer Complete  flag
: DMA_ISR_TEIF3   %1 11 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF3    Channel 3 Transfer Error  flag
: DMA_ISR_GIF4   %1 12 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF4    Channel 4 Global interrupt  flag
: DMA_ISR_TCIF4   %1 13 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF4    Channel 4 Transfer Complete  flag
: DMA_ISR_HTIF4   %1 14 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF4    Channel 4 Half Transfer Complete  flag
: DMA_ISR_TEIF4   %1 15 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF4    Channel 4 Transfer Error  flag
: DMA_ISR_GIF5   %1 16 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF5    Channel 5 Global interrupt  flag
: DMA_ISR_TCIF5   %1 17 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF5    Channel 5 Transfer Complete  flag
: DMA_ISR_HTIF5   %1 18 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF5    Channel 5 Half Transfer Complete  flag
: DMA_ISR_TEIF5   %1 19 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF5    Channel 5 Transfer Error  flag
: DMA_ISR_GIF6   %1 20 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF6    Channel 6 Global interrupt  flag
: DMA_ISR_TCIF6   %1 21 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF6    Channel 6 Transfer Complete  flag
: DMA_ISR_HTIF6   %1 22 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF6    Channel 6 Half Transfer Complete  flag
: DMA_ISR_TEIF6   %1 23 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF6    Channel 6 Transfer Error  flag
: DMA_ISR_GIF7   %1 24 lshift DMA_ISR bis! ;  \ DMA_ISR_GIF7    Channel 7 Global interrupt  flag
: DMA_ISR_TCIF7   %1 25 lshift DMA_ISR bis! ;  \ DMA_ISR_TCIF7    Channel 7 Transfer Complete  flag
: DMA_ISR_HTIF7   %1 26 lshift DMA_ISR bis! ;  \ DMA_ISR_HTIF7    Channel 7 Half Transfer Complete  flag
: DMA_ISR_TEIF7   %1 27 lshift DMA_ISR bis! ;  \ DMA_ISR_TEIF7    Channel 7 Transfer Error  flag

\ DMA_IFCR (write-only)
: DMA_IFCR_CGIF1   %1 0 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF1    Channel 1 Global interrupt  clear
: DMA_IFCR_CTCIF1   %1 1 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF1    Channel 1 Transfer Complete  clear
: DMA_IFCR_CHTIF1   %1 2 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF1    Channel 1 Half Transfer  clear
: DMA_IFCR_CTEIF1   %1 3 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF1    Channel 1 Transfer Error  clear
: DMA_IFCR_CGIF2   %1 4 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF2    Channel 2 Global interrupt  clear
: DMA_IFCR_CTCIF2   %1 5 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF2    Channel 2 Transfer Complete  clear
: DMA_IFCR_CHTIF2   %1 6 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF2    Channel 2 Half Transfer  clear
: DMA_IFCR_CTEIF2   %1 7 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF2    Channel 2 Transfer Error  clear
: DMA_IFCR_CGIF3   %1 8 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF3    Channel 3 Global interrupt  clear
: DMA_IFCR_CTCIF3   %1 9 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF3    Channel 3 Transfer Complete  clear
: DMA_IFCR_CHTIF3   %1 10 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF3    Channel 3 Half Transfer  clear
: DMA_IFCR_CTEIF3   %1 11 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF3    Channel 3 Transfer Error  clear
: DMA_IFCR_CGIF4   %1 12 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF4    Channel 4 Global interrupt  clear
: DMA_IFCR_CTCIF4   %1 13 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF4    Channel 4 Transfer Complete  clear
: DMA_IFCR_CHTIF4   %1 14 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF4    Channel 4 Half Transfer  clear
: DMA_IFCR_CTEIF4   %1 15 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF4    Channel 4 Transfer Error  clear
: DMA_IFCR_CGIF5   %1 16 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF5    Channel 5 Global interrupt  clear
: DMA_IFCR_CTCIF5   %1 17 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF5    Channel 5 Transfer Complete  clear
: DMA_IFCR_CHTIF5   %1 18 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF5    Channel 5 Half Transfer  clear
: DMA_IFCR_CTEIF5   %1 19 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF5    Channel 5 Transfer Error  clear
: DMA_IFCR_CGIF6   %1 20 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF6    Channel 6 Global interrupt  clear
: DMA_IFCR_CTCIF6   %1 21 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF6    Channel 6 Transfer Complete  clear
: DMA_IFCR_CHTIF6   %1 22 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF6    Channel 6 Half Transfer  clear
: DMA_IFCR_CTEIF6   %1 23 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF6    Channel 6 Transfer Error  clear
: DMA_IFCR_CGIF7   %1 24 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CGIF7    Channel 7 Global interrupt  clear
: DMA_IFCR_CTCIF7   %1 25 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTCIF7    Channel 7 Transfer Complete  clear
: DMA_IFCR_CHTIF7   %1 26 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CHTIF7    Channel 7 Half Transfer  clear
: DMA_IFCR_CTEIF7   %1 27 lshift DMA_IFCR bis! ;  \ DMA_IFCR_CTEIF7    Channel 7 Transfer Error  clear

\ DMA_CCR1 (read-write)
: DMA_CCR1_EN   %1 0 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_EN    Channel enable
: DMA_CCR1_TCIE   %1 1 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_TCIE    Transfer complete interrupt  enable
: DMA_CCR1_HTIE   %1 2 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_HTIE    Half Transfer interrupt  enable
: DMA_CCR1_TEIE   %1 3 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_TEIE    Transfer error interrupt  enable
: DMA_CCR1_DIR   %1 4 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_DIR    Data transfer direction
: DMA_CCR1_CIRC   %1 5 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_CIRC    Circular mode
: DMA_CCR1_PINC   %1 6 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_PINC    Peripheral increment mode
: DMA_CCR1_MINC   %1 7 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_MINC    Memory increment mode
: DMA_CCR1_PSIZE   ( %XX -- ) 8 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_PSIZE    Peripheral size
: DMA_CCR1_MSIZE   ( %XX -- ) 10 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_MSIZE    Memory size
: DMA_CCR1_PL   ( %XX -- ) 12 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_PL    Channel Priority level
: DMA_CCR1_MEM2MEM   %1 14 lshift DMA_CCR1 bis! ;  \ DMA_CCR1_MEM2MEM    Memory to memory mode

\ DMA_CNDTR1 (read-write)
: DMA_CNDTR1_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR1 bis! ;  \ DMA_CNDTR1_NDT    Number of data to transfer

\ DMA_CPAR1 (read-write)
: DMA_CPAR1_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR1 bis! ;  \ DMA_CPAR1_PA    Peripheral address

\ DMA_CMAR1 (read-write)
: DMA_CMAR1_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR1 bis! ;  \ DMA_CMAR1_MA    Memory address

\ DMA_CCR2 (read-write)
: DMA_CCR2_EN   %1 0 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_EN    Channel enable
: DMA_CCR2_TCIE   %1 1 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_TCIE    Transfer complete interrupt  enable
: DMA_CCR2_HTIE   %1 2 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_HTIE    Half Transfer interrupt  enable
: DMA_CCR2_TEIE   %1 3 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_TEIE    Transfer error interrupt  enable
: DMA_CCR2_DIR   %1 4 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_DIR    Data transfer direction
: DMA_CCR2_CIRC   %1 5 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_CIRC    Circular mode
: DMA_CCR2_PINC   %1 6 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_PINC    Peripheral increment mode
: DMA_CCR2_MINC   %1 7 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_MINC    Memory increment mode
: DMA_CCR2_PSIZE   ( %XX -- ) 8 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_PSIZE    Peripheral size
: DMA_CCR2_MSIZE   ( %XX -- ) 10 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_MSIZE    Memory size
: DMA_CCR2_PL   ( %XX -- ) 12 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_PL    Channel Priority level
: DMA_CCR2_MEM2MEM   %1 14 lshift DMA_CCR2 bis! ;  \ DMA_CCR2_MEM2MEM    Memory to memory mode

\ DMA_CNDTR2 (read-write)
: DMA_CNDTR2_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR2 bis! ;  \ DMA_CNDTR2_NDT    Number of data to transfer

\ DMA_CPAR2 (read-write)
: DMA_CPAR2_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR2 bis! ;  \ DMA_CPAR2_PA    Peripheral address

\ DMA_CMAR2 (read-write)
: DMA_CMAR2_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR2 bis! ;  \ DMA_CMAR2_MA    Memory address

\ DMA_CCR3 (read-write)
: DMA_CCR3_EN   %1 0 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_EN    Channel enable
: DMA_CCR3_TCIE   %1 1 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_TCIE    Transfer complete interrupt  enable
: DMA_CCR3_HTIE   %1 2 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_HTIE    Half Transfer interrupt  enable
: DMA_CCR3_TEIE   %1 3 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_TEIE    Transfer error interrupt  enable
: DMA_CCR3_DIR   %1 4 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_DIR    Data transfer direction
: DMA_CCR3_CIRC   %1 5 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_CIRC    Circular mode
: DMA_CCR3_PINC   %1 6 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_PINC    Peripheral increment mode
: DMA_CCR3_MINC   %1 7 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_MINC    Memory increment mode
: DMA_CCR3_PSIZE   ( %XX -- ) 8 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_PSIZE    Peripheral size
: DMA_CCR3_MSIZE   ( %XX -- ) 10 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_MSIZE    Memory size
: DMA_CCR3_PL   ( %XX -- ) 12 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_PL    Channel Priority level
: DMA_CCR3_MEM2MEM   %1 14 lshift DMA_CCR3 bis! ;  \ DMA_CCR3_MEM2MEM    Memory to memory mode

\ DMA_CNDTR3 (read-write)
: DMA_CNDTR3_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR3 bis! ;  \ DMA_CNDTR3_NDT    Number of data to transfer

\ DMA_CPAR3 (read-write)
: DMA_CPAR3_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR3 bis! ;  \ DMA_CPAR3_PA    Peripheral address

\ DMA_CMAR3 (read-write)
: DMA_CMAR3_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR3 bis! ;  \ DMA_CMAR3_MA    Memory address

\ DMA_CCR4 (read-write)
: DMA_CCR4_EN   %1 0 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_EN    Channel enable
: DMA_CCR4_TCIE   %1 1 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_TCIE    Transfer complete interrupt  enable
: DMA_CCR4_HTIE   %1 2 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_HTIE    Half Transfer interrupt  enable
: DMA_CCR4_TEIE   %1 3 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_TEIE    Transfer error interrupt  enable
: DMA_CCR4_DIR   %1 4 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_DIR    Data transfer direction
: DMA_CCR4_CIRC   %1 5 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_CIRC    Circular mode
: DMA_CCR4_PINC   %1 6 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_PINC    Peripheral increment mode
: DMA_CCR4_MINC   %1 7 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_MINC    Memory increment mode
: DMA_CCR4_PSIZE   ( %XX -- ) 8 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_PSIZE    Peripheral size
: DMA_CCR4_MSIZE   ( %XX -- ) 10 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_MSIZE    Memory size
: DMA_CCR4_PL   ( %XX -- ) 12 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_PL    Channel Priority level
: DMA_CCR4_MEM2MEM   %1 14 lshift DMA_CCR4 bis! ;  \ DMA_CCR4_MEM2MEM    Memory to memory mode

\ DMA_CNDTR4 (read-write)
: DMA_CNDTR4_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR4 bis! ;  \ DMA_CNDTR4_NDT    Number of data to transfer

\ DMA_CPAR4 (read-write)
: DMA_CPAR4_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR4 bis! ;  \ DMA_CPAR4_PA    Peripheral address

\ DMA_CMAR4 (read-write)
: DMA_CMAR4_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR4 bis! ;  \ DMA_CMAR4_MA    Memory address

\ DMA_CCR5 (read-write)
: DMA_CCR5_EN   %1 0 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_EN    Channel enable
: DMA_CCR5_TCIE   %1 1 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_TCIE    Transfer complete interrupt  enable
: DMA_CCR5_HTIE   %1 2 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_HTIE    Half Transfer interrupt  enable
: DMA_CCR5_TEIE   %1 3 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_TEIE    Transfer error interrupt  enable
: DMA_CCR5_DIR   %1 4 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_DIR    Data transfer direction
: DMA_CCR5_CIRC   %1 5 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_CIRC    Circular mode
: DMA_CCR5_PINC   %1 6 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_PINC    Peripheral increment mode
: DMA_CCR5_MINC   %1 7 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_MINC    Memory increment mode
: DMA_CCR5_PSIZE   ( %XX -- ) 8 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_PSIZE    Peripheral size
: DMA_CCR5_MSIZE   ( %XX -- ) 10 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_MSIZE    Memory size
: DMA_CCR5_PL   ( %XX -- ) 12 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_PL    Channel Priority level
: DMA_CCR5_MEM2MEM   %1 14 lshift DMA_CCR5 bis! ;  \ DMA_CCR5_MEM2MEM    Memory to memory mode

\ DMA_CNDTR5 (read-write)
: DMA_CNDTR5_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR5 bis! ;  \ DMA_CNDTR5_NDT    Number of data to transfer

\ DMA_CPAR5 (read-write)
: DMA_CPAR5_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR5 bis! ;  \ DMA_CPAR5_PA    Peripheral address

\ DMA_CMAR5 (read-write)
: DMA_CMAR5_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR5 bis! ;  \ DMA_CMAR5_MA    Memory address

\ DMA_CCR6 (read-write)
: DMA_CCR6_EN   %1 0 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_EN    Channel enable
: DMA_CCR6_TCIE   %1 1 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_TCIE    Transfer complete interrupt  enable
: DMA_CCR6_HTIE   %1 2 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_HTIE    Half Transfer interrupt  enable
: DMA_CCR6_TEIE   %1 3 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_TEIE    Transfer error interrupt  enable
: DMA_CCR6_DIR   %1 4 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_DIR    Data transfer direction
: DMA_CCR6_CIRC   %1 5 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_CIRC    Circular mode
: DMA_CCR6_PINC   %1 6 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_PINC    Peripheral increment mode
: DMA_CCR6_MINC   %1 7 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_MINC    Memory increment mode
: DMA_CCR6_PSIZE   ( %XX -- ) 8 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_PSIZE    Peripheral size
: DMA_CCR6_MSIZE   ( %XX -- ) 10 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_MSIZE    Memory size
: DMA_CCR6_PL   ( %XX -- ) 12 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_PL    Channel Priority level
: DMA_CCR6_MEM2MEM   %1 14 lshift DMA_CCR6 bis! ;  \ DMA_CCR6_MEM2MEM    Memory to memory mode

\ DMA_CNDTR6 (read-write)
: DMA_CNDTR6_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR6 bis! ;  \ DMA_CNDTR6_NDT    Number of data to transfer

\ DMA_CPAR6 (read-write)
: DMA_CPAR6_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR6 bis! ;  \ DMA_CPAR6_PA    Peripheral address

\ DMA_CMAR6 (read-write)
: DMA_CMAR6_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR6 bis! ;  \ DMA_CMAR6_MA    Memory address

\ DMA_CCR7 (read-write)
: DMA_CCR7_EN   %1 0 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_EN    Channel enable
: DMA_CCR7_TCIE   %1 1 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_TCIE    Transfer complete interrupt  enable
: DMA_CCR7_HTIE   %1 2 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_HTIE    Half Transfer interrupt  enable
: DMA_CCR7_TEIE   %1 3 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_TEIE    Transfer error interrupt  enable
: DMA_CCR7_DIR   %1 4 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_DIR    Data transfer direction
: DMA_CCR7_CIRC   %1 5 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_CIRC    Circular mode
: DMA_CCR7_PINC   %1 6 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_PINC    Peripheral increment mode
: DMA_CCR7_MINC   %1 7 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_MINC    Memory increment mode
: DMA_CCR7_PSIZE   ( %XX -- ) 8 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_PSIZE    Peripheral size
: DMA_CCR7_MSIZE   ( %XX -- ) 10 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_MSIZE    Memory size
: DMA_CCR7_PL   ( %XX -- ) 12 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_PL    Channel Priority level
: DMA_CCR7_MEM2MEM   %1 14 lshift DMA_CCR7 bis! ;  \ DMA_CCR7_MEM2MEM    Memory to memory mode

\ DMA_CNDTR7 (read-write)
: DMA_CNDTR7_NDT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CNDTR7 bis! ;  \ DMA_CNDTR7_NDT    Number of data to transfer

\ DMA_CPAR7 (read-write)
: DMA_CPAR7_PA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CPAR7 bis! ;  \ DMA_CPAR7_PA    Peripheral address

\ DMA_CMAR7 (read-write)
: DMA_CMAR7_MA   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift DMA_CMAR7 bis! ;  \ DMA_CMAR7_MA    Memory address

\ RCC_CR ()
: RCC_CR_HSION   %1 0 lshift RCC_CR bis! ;  \ RCC_CR_HSION    Internal High Speed clock  enable
: RCC_CR_HSIRDY   %1 1 lshift RCC_CR bis! ;  \ RCC_CR_HSIRDY    Internal High Speed clock ready  flag
: RCC_CR_HSITRIM   ( %XXXXX -- ) 3 lshift RCC_CR bis! ;  \ RCC_CR_HSITRIM    Internal High Speed clock  trimming
: RCC_CR_HSICAL   ( %XXXXXXXX -- ) 8 lshift RCC_CR bis! ;  \ RCC_CR_HSICAL    Internal High Speed clock  Calibration
: RCC_CR_HSEON   %1 16 lshift RCC_CR bis! ;  \ RCC_CR_HSEON    External High Speed clock  enable
: RCC_CR_HSERDY   %1 17 lshift RCC_CR bis! ;  \ RCC_CR_HSERDY    External High Speed clock ready  flag
: RCC_CR_HSEBYP   %1 18 lshift RCC_CR bis! ;  \ RCC_CR_HSEBYP    External High Speed clock  Bypass
: RCC_CR_CSSON   %1 19 lshift RCC_CR bis! ;  \ RCC_CR_CSSON    Clock Security System  enable
: RCC_CR_PLLON   %1 24 lshift RCC_CR bis! ;  \ RCC_CR_PLLON    PLL enable
: RCC_CR_PLLRDY   %1 25 lshift RCC_CR bis! ;  \ RCC_CR_PLLRDY    PLL clock ready flag

\ RCC_CFGR ()
: RCC_CFGR_SW   ( %XX -- ) 0 lshift RCC_CFGR bis! ;  \ RCC_CFGR_SW    System clock Switch
: RCC_CFGR_SWS   ( %XX -- ) 2 lshift RCC_CFGR bis! ;  \ RCC_CFGR_SWS    System Clock Switch Status
: RCC_CFGR_HPRE   ( %XXXX -- ) 4 lshift RCC_CFGR bis! ;  \ RCC_CFGR_HPRE    AHB prescaler
: RCC_CFGR_PPRE   ( %XXX -- ) 8 lshift RCC_CFGR bis! ;  \ RCC_CFGR_PPRE    APB Low speed prescaler  APB1
: RCC_CFGR_ADCPRE   %1 14 lshift RCC_CFGR bis! ;  \ RCC_CFGR_ADCPRE    ADC prescaler
: RCC_CFGR_PLLSRC   ( %XX -- ) 15 lshift RCC_CFGR bis! ;  \ RCC_CFGR_PLLSRC    PLL input clock source
: RCC_CFGR_PLLXTPRE   %1 17 lshift RCC_CFGR bis! ;  \ RCC_CFGR_PLLXTPRE    HSE divider for PLL entry
: RCC_CFGR_PLLMUL   ( %XXXX -- ) 18 lshift RCC_CFGR bis! ;  \ RCC_CFGR_PLLMUL    PLL Multiplication Factor
: RCC_CFGR_MCO   ( %XXX -- ) 24 lshift RCC_CFGR bis! ;  \ RCC_CFGR_MCO    Microcontroller clock  output
: RCC_CFGR_MCOPRE   ( %XXX -- ) 28 lshift RCC_CFGR bis! ;  \ RCC_CFGR_MCOPRE    Microcontroller Clock Output  Prescaler
: RCC_CFGR_PLLNODIV   %1 31 lshift RCC_CFGR bis! ;  \ RCC_CFGR_PLLNODIV    PLL clock not divided for  MCO

\ RCC_CIR ()
: RCC_CIR_LSIRDYF   %1 0 lshift RCC_CIR bis! ;  \ RCC_CIR_LSIRDYF    LSI Ready Interrupt flag
: RCC_CIR_LSERDYF   %1 1 lshift RCC_CIR bis! ;  \ RCC_CIR_LSERDYF    LSE Ready Interrupt flag
: RCC_CIR_HSIRDYF   %1 2 lshift RCC_CIR bis! ;  \ RCC_CIR_HSIRDYF    HSI Ready Interrupt flag
: RCC_CIR_HSERDYF   %1 3 lshift RCC_CIR bis! ;  \ RCC_CIR_HSERDYF    HSE Ready Interrupt flag
: RCC_CIR_PLLRDYF   %1 4 lshift RCC_CIR bis! ;  \ RCC_CIR_PLLRDYF    PLL Ready Interrupt flag
: RCC_CIR_HSI14RDYF   %1 5 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI14RDYF    HSI14 ready interrupt flag
: RCC_CIR_HSI48RDYF   %1 6 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI48RDYF    HSI48 ready interrupt flag
: RCC_CIR_CSSF   %1 7 lshift RCC_CIR bis! ;  \ RCC_CIR_CSSF    Clock Security System Interrupt  flag
: RCC_CIR_LSIRDYIE   %1 8 lshift RCC_CIR bis! ;  \ RCC_CIR_LSIRDYIE    LSI Ready Interrupt Enable
: RCC_CIR_LSERDYIE   %1 9 lshift RCC_CIR bis! ;  \ RCC_CIR_LSERDYIE    LSE Ready Interrupt Enable
: RCC_CIR_HSIRDYIE   %1 10 lshift RCC_CIR bis! ;  \ RCC_CIR_HSIRDYIE    HSI Ready Interrupt Enable
: RCC_CIR_HSERDYIE   %1 11 lshift RCC_CIR bis! ;  \ RCC_CIR_HSERDYIE    HSE Ready Interrupt Enable
: RCC_CIR_PLLRDYIE   %1 12 lshift RCC_CIR bis! ;  \ RCC_CIR_PLLRDYIE    PLL Ready Interrupt Enable
: RCC_CIR_HSI14RDYE   %1 13 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI14RDYE    HSI14 ready interrupt  enable
: RCC_CIR_HSI48RDYIE   %1 14 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI48RDYIE    HSI48 ready interrupt  enable
: RCC_CIR_LSIRDYC   %1 16 lshift RCC_CIR bis! ;  \ RCC_CIR_LSIRDYC    LSI Ready Interrupt Clear
: RCC_CIR_LSERDYC   %1 17 lshift RCC_CIR bis! ;  \ RCC_CIR_LSERDYC    LSE Ready Interrupt Clear
: RCC_CIR_HSIRDYC   %1 18 lshift RCC_CIR bis! ;  \ RCC_CIR_HSIRDYC    HSI Ready Interrupt Clear
: RCC_CIR_HSERDYC   %1 19 lshift RCC_CIR bis! ;  \ RCC_CIR_HSERDYC    HSE Ready Interrupt Clear
: RCC_CIR_PLLRDYC   %1 20 lshift RCC_CIR bis! ;  \ RCC_CIR_PLLRDYC    PLL Ready Interrupt Clear
: RCC_CIR_HSI14RDYC   %1 21 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI14RDYC    HSI 14 MHz Ready Interrupt  Clear
: RCC_CIR_HSI48RDYC   %1 22 lshift RCC_CIR bis! ;  \ RCC_CIR_HSI48RDYC    HSI48 Ready Interrupt  Clear
: RCC_CIR_CSSC   %1 23 lshift RCC_CIR bis! ;  \ RCC_CIR_CSSC    Clock security system interrupt  clear

\ RCC_APB2RSTR (read-write)
: RCC_APB2RSTR_SYSCFGRST   %1 0 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_SYSCFGRST    SYSCFG and COMP reset
: RCC_APB2RSTR_ADCRST   %1 9 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_ADCRST    ADC interface reset
: RCC_APB2RSTR_TIM1RST   %1 11 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_TIM1RST    TIM1 timer reset
: RCC_APB2RSTR_SPI1RST   %1 12 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_SPI1RST    SPI 1 reset
: RCC_APB2RSTR_USART1RST   %1 14 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_USART1RST    USART1 reset
: RCC_APB2RSTR_TIM15RST   %1 16 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_TIM15RST    TIM15 timer reset
: RCC_APB2RSTR_TIM16RST   %1 17 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_TIM16RST    TIM16 timer reset
: RCC_APB2RSTR_TIM17RST   %1 18 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_TIM17RST    TIM17 timer reset
: RCC_APB2RSTR_DBGMCURST   %1 22 lshift RCC_APB2RSTR bis! ;  \ RCC_APB2RSTR_DBGMCURST    Debug MCU reset

\ RCC_APB1RSTR (read-write)
: RCC_APB1RSTR_TIM3RST   %1 1 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_TIM3RST    Timer 3 reset
: RCC_APB1RSTR_TIM6RST   %1 4 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_TIM6RST    Timer 6 reset
: RCC_APB1RSTR_TIM14RST   %1 8 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_TIM14RST    Timer 14 reset
: RCC_APB1RSTR_WWDGRST   %1 11 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_WWDGRST    Window watchdog reset
: RCC_APB1RSTR_SPI2RST   %1 14 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_SPI2RST    SPI2 reset
: RCC_APB1RSTR_USART2RST   %1 17 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_USART2RST    USART 2 reset
: RCC_APB1RSTR_I2C1RST   %1 21 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_I2C1RST    I2C1 reset
: RCC_APB1RSTR_I2C2RST   %1 22 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_I2C2RST    I2C2 reset
: RCC_APB1RSTR_PWRRST   %1 28 lshift RCC_APB1RSTR bis! ;  \ RCC_APB1RSTR_PWRRST    Power interface reset

\ RCC_AHBENR (read-write)
: RCC_AHBENR_DMAEN   %1 0 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_DMAEN    DMA1 clock enable
: RCC_AHBENR_SRAMEN   %1 2 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_SRAMEN    SRAM interface clock  enable
: RCC_AHBENR_FLITFEN   %1 4 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_FLITFEN    FLITF clock enable
: RCC_AHBENR_CRCEN   %1 6 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_CRCEN    CRC clock enable
: RCC_AHBENR_IOPAEN   %1 17 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_IOPAEN    I/O port A clock enable
: RCC_AHBENR_IOPBEN   %1 18 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_IOPBEN    I/O port B clock enable
: RCC_AHBENR_IOPCEN   %1 19 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_IOPCEN    I/O port C clock enable
: RCC_AHBENR_IOPDEN   %1 20 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_IOPDEN    I/O port D clock enable
: RCC_AHBENR_IOPFEN   %1 22 lshift RCC_AHBENR bis! ;  \ RCC_AHBENR_IOPFEN    I/O port F clock enable

\ RCC_APB2ENR (read-write)
: RCC_APB2ENR_SYSCFGEN   %1 0 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_SYSCFGEN    SYSCFG clock enable
: RCC_APB2ENR_ADCEN   %1 9 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_ADCEN    ADC 1 interface clock  enable
: RCC_APB2ENR_TIM1EN   %1 11 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_TIM1EN    TIM1 Timer clock enable
: RCC_APB2ENR_SPI1EN   %1 12 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_SPI1EN    SPI 1 clock enable
: RCC_APB2ENR_USART1EN   %1 14 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_USART1EN    USART1 clock enable
: RCC_APB2ENR_TIM15EN   %1 16 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_TIM15EN    TIM15 timer clock enable
: RCC_APB2ENR_TIM16EN   %1 17 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_TIM16EN    TIM16 timer clock enable
: RCC_APB2ENR_TIM17EN   %1 18 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_TIM17EN    TIM17 timer clock enable
: RCC_APB2ENR_DBGMCUEN   %1 22 lshift RCC_APB2ENR bis! ;  \ RCC_APB2ENR_DBGMCUEN    MCU debug module clock  enable

\ RCC_APB1ENR (read-write)
: RCC_APB1ENR_TIM3EN   %1 1 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_TIM3EN    Timer 3 clock enable
: RCC_APB1ENR_TIM6EN   %1 4 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_TIM6EN    Timer 6 clock enable
: RCC_APB1ENR_TIM14EN   %1 8 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_TIM14EN    Timer 14 clock enable
: RCC_APB1ENR_WWDGEN   %1 11 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_WWDGEN    Window watchdog clock  enable
: RCC_APB1ENR_SPI2EN   %1 14 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_SPI2EN    SPI 2 clock enable
: RCC_APB1ENR_USART2EN   %1 17 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_USART2EN    USART 2 clock enable
: RCC_APB1ENR_I2C1EN   %1 21 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_I2C1EN    I2C 1 clock enable
: RCC_APB1ENR_I2C2EN   %1 22 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_I2C2EN    I2C 2 clock enable
: RCC_APB1ENR_PWREN   %1 28 lshift RCC_APB1ENR bis! ;  \ RCC_APB1ENR_PWREN    Power interface clock  enable

\ RCC_BDCR ()
: RCC_BDCR_LSEON   %1 0 lshift RCC_BDCR bis! ;  \ RCC_BDCR_LSEON    External Low Speed oscillator  enable
: RCC_BDCR_LSERDY   %1 1 lshift RCC_BDCR bis! ;  \ RCC_BDCR_LSERDY    External Low Speed oscillator  ready
: RCC_BDCR_LSEBYP   %1 2 lshift RCC_BDCR bis! ;  \ RCC_BDCR_LSEBYP    External Low Speed oscillator  bypass
: RCC_BDCR_LSEDRV   ( %XX -- ) 3 lshift RCC_BDCR bis! ;  \ RCC_BDCR_LSEDRV    LSE oscillator drive  capability
: RCC_BDCR_RTCSEL   ( %XX -- ) 8 lshift RCC_BDCR bis! ;  \ RCC_BDCR_RTCSEL    RTC clock source selection
: RCC_BDCR_RTCEN   %1 15 lshift RCC_BDCR bis! ;  \ RCC_BDCR_RTCEN    RTC clock enable
: RCC_BDCR_BDRST   %1 16 lshift RCC_BDCR bis! ;  \ RCC_BDCR_BDRST    Backup domain software  reset

\ RCC_CSR ()
: RCC_CSR_LSION   %1 0 lshift RCC_CSR bis! ;  \ RCC_CSR_LSION    Internal low speed oscillator  enable
: RCC_CSR_LSIRDY   %1 1 lshift RCC_CSR bis! ;  \ RCC_CSR_LSIRDY    Internal low speed oscillator  ready
: RCC_CSR_RMVF   %1 24 lshift RCC_CSR bis! ;  \ RCC_CSR_RMVF    Remove reset flag
: RCC_CSR_OBLRSTF   %1 25 lshift RCC_CSR bis! ;  \ RCC_CSR_OBLRSTF    Option byte loader reset  flag
: RCC_CSR_PINRSTF   %1 26 lshift RCC_CSR bis! ;  \ RCC_CSR_PINRSTF    PIN reset flag
: RCC_CSR_PORRSTF   %1 27 lshift RCC_CSR bis! ;  \ RCC_CSR_PORRSTF    POR/PDR reset flag
: RCC_CSR_SFTRSTF   %1 28 lshift RCC_CSR bis! ;  \ RCC_CSR_SFTRSTF    Software reset flag
: RCC_CSR_IWDGRSTF   %1 29 lshift RCC_CSR bis! ;  \ RCC_CSR_IWDGRSTF    Independent watchdog reset  flag
: RCC_CSR_WWDGRSTF   %1 30 lshift RCC_CSR bis! ;  \ RCC_CSR_WWDGRSTF    Window watchdog reset flag
: RCC_CSR_LPWRRSTF   %1 31 lshift RCC_CSR bis! ;  \ RCC_CSR_LPWRRSTF    Low-power reset flag

\ RCC_AHBRSTR (read-write)
: RCC_AHBRSTR_IOPARST   %1 17 lshift RCC_AHBRSTR bis! ;  \ RCC_AHBRSTR_IOPARST    I/O port A reset
: RCC_AHBRSTR_IOPBRST   %1 18 lshift RCC_AHBRSTR bis! ;  \ RCC_AHBRSTR_IOPBRST    I/O port B reset
: RCC_AHBRSTR_IOPCRST   %1 19 lshift RCC_AHBRSTR bis! ;  \ RCC_AHBRSTR_IOPCRST    I/O port C reset
: RCC_AHBRSTR_IOPDRST   %1 20 lshift RCC_AHBRSTR bis! ;  \ RCC_AHBRSTR_IOPDRST    I/O port D reset
: RCC_AHBRSTR_IOPFRST   %1 22 lshift RCC_AHBRSTR bis! ;  \ RCC_AHBRSTR_IOPFRST    I/O port F reset

\ RCC_CFGR2 (read-write)
: RCC_CFGR2_PREDIV   ( %XXXX -- ) 0 lshift RCC_CFGR2 bis! ;  \ RCC_CFGR2_PREDIV    PREDIV division factor

\ RCC_CFGR3 (read-write)
: RCC_CFGR3_USART1SW   ( %XX -- ) 0 lshift RCC_CFGR3 bis! ;  \ RCC_CFGR3_USART1SW    USART1 clock source  selection
: RCC_CFGR3_I2C1SW   %1 4 lshift RCC_CFGR3 bis! ;  \ RCC_CFGR3_I2C1SW    I2C1 clock source  selection
: RCC_CFGR3_ADCSW   %1 8 lshift RCC_CFGR3 bis! ;  \ RCC_CFGR3_ADCSW    ADC clock source selection
: RCC_CFGR3_USART2SW   ( %XX -- ) 16 lshift RCC_CFGR3 bis! ;  \ RCC_CFGR3_USART2SW    USART2 clock source  selection

\ RCC_CR2 ()
: RCC_CR2_HSI14ON   %1 0 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI14ON    HSI14 clock enable
: RCC_CR2_HSI14RDY   %1 1 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI14RDY    HR14 clock ready flag
: RCC_CR2_HSI14DIS   %1 2 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI14DIS    HSI14 clock request from ADC  disable
: RCC_CR2_HSI14TRIM   ( %XXXXX -- ) 3 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI14TRIM    HSI14 clock trimming
: RCC_CR2_HSI14CAL   ( %XXXXXXXX -- ) 8 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI14CAL    HSI14 clock calibration
: RCC_CR2_HSI48ON   %1 16 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI48ON    HSI48 clock enable
: RCC_CR2_HSI48RDY   %1 17 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI48RDY    HSI48 clock ready flag
: RCC_CR2_HSI48CAL   %1 24 lshift RCC_CR2 bis! ;  \ RCC_CR2_HSI48CAL    HSI48 factory clock  calibration

\ SYSCFG_CFGR1 (read-write)
: SYSCFG_CFGR1_MEM_MODE   ( %XX -- ) 0 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_MEM_MODE    Memory mapping selection  bits
: SYSCFG_CFGR1_ADC_DMA_RMP   %1 8 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_ADC_DMA_RMP    ADC DMA remapping bit
: SYSCFG_CFGR1_USART1_TX_DMA_RMP   %1 9 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_USART1_TX_DMA_RMP    USART1_TX DMA remapping  bit
: SYSCFG_CFGR1_USART1_RX_DMA_RMP   %1 10 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_USART1_RX_DMA_RMP    USART1_RX DMA request remapping  bit
: SYSCFG_CFGR1_TIM16_DMA_RMP   %1 11 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_TIM16_DMA_RMP    TIM16 DMA request remapping  bit
: SYSCFG_CFGR1_TIM17_DMA_RMP   %1 12 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_TIM17_DMA_RMP    TIM17 DMA request remapping  bit
: SYSCFG_CFGR1_I2C_PB6_FM   %1 16 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C_PB6_FM    Fast Mode Plus FM plus driving  capability activation bits.
: SYSCFG_CFGR1_I2C_PB7_FM   %1 17 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C_PB7_FM    Fast Mode Plus FM+ driving capability  activation bits.
: SYSCFG_CFGR1_I2C_PB8_FM   %1 18 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C_PB8_FM    Fast Mode Plus FM+ driving capability  activation bits.
: SYSCFG_CFGR1_I2C_PB9_FM   %1 19 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C_PB9_FM    Fast Mode Plus FM+ driving capability  activation bits.
: SYSCFG_CFGR1_I2C1_FM_plus   %1 20 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C1_FM_plus    FM+ driving capability activation for  I2C1
: SYSCFG_CFGR1_I2C2_FM_plus   %1 21 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C2_FM_plus    FM+ driving capability activation for  I2C2
: SYSCFG_CFGR1_SPI2_DMA_RMP   %1 24 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_SPI2_DMA_RMP    SPI2 DMA request remapping  bit
: SYSCFG_CFGR1_USART2_DMA_RMP   %1 25 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_USART2_DMA_RMP    USART2 DMA request remapping  bit
: SYSCFG_CFGR1_USART3_DMA_RMP   %1 26 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_USART3_DMA_RMP    USART3 DMA request remapping  bit
: SYSCFG_CFGR1_I2C1_DMA_RMP   %1 27 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_I2C1_DMA_RMP    I2C1 DMA request remapping  bit
: SYSCFG_CFGR1_TIM1_DMA_RMP   %1 28 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_TIM1_DMA_RMP    TIM1 DMA request remapping  bit
: SYSCFG_CFGR1_TIM2_DMA_RMP   %1 29 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_TIM2_DMA_RMP    TIM2 DMA request remapping  bit
: SYSCFG_CFGR1_TIM3_DMA_RMP   %1 30 lshift SYSCFG_CFGR1 bis! ;  \ SYSCFG_CFGR1_TIM3_DMA_RMP    TIM3 DMA request remapping  bit

\ SYSCFG_EXTICR1 (read-write)
: SYSCFG_EXTICR1_EXTI3   ( %XXXX -- ) 12 lshift SYSCFG_EXTICR1 bis! ;  \ SYSCFG_EXTICR1_EXTI3    EXTI 3 configuration bits
: SYSCFG_EXTICR1_EXTI2   ( %XXXX -- ) 8 lshift SYSCFG_EXTICR1 bis! ;  \ SYSCFG_EXTICR1_EXTI2    EXTI 2 configuration bits
: SYSCFG_EXTICR1_EXTI1   ( %XXXX -- ) 4 lshift SYSCFG_EXTICR1 bis! ;  \ SYSCFG_EXTICR1_EXTI1    EXTI 1 configuration bits
: SYSCFG_EXTICR1_EXTI0   ( %XXXX -- ) 0 lshift SYSCFG_EXTICR1 bis! ;  \ SYSCFG_EXTICR1_EXTI0    EXTI 0 configuration bits

\ SYSCFG_EXTICR2 (read-write)
: SYSCFG_EXTICR2_EXTI7   ( %XXXX -- ) 12 lshift SYSCFG_EXTICR2 bis! ;  \ SYSCFG_EXTICR2_EXTI7    EXTI 7 configuration bits
: SYSCFG_EXTICR2_EXTI6   ( %XXXX -- ) 8 lshift SYSCFG_EXTICR2 bis! ;  \ SYSCFG_EXTICR2_EXTI6    EXTI 6 configuration bits
: SYSCFG_EXTICR2_EXTI5   ( %XXXX -- ) 4 lshift SYSCFG_EXTICR2 bis! ;  \ SYSCFG_EXTICR2_EXTI5    EXTI 5 configuration bits
: SYSCFG_EXTICR2_EXTI4   ( %XXXX -- ) 0 lshift SYSCFG_EXTICR2 bis! ;  \ SYSCFG_EXTICR2_EXTI4    EXTI 4 configuration bits

\ SYSCFG_EXTICR3 (read-write)
: SYSCFG_EXTICR3_EXTI11   ( %XXXX -- ) 12 lshift SYSCFG_EXTICR3 bis! ;  \ SYSCFG_EXTICR3_EXTI11    EXTI 11 configuration bits
: SYSCFG_EXTICR3_EXTI10   ( %XXXX -- ) 8 lshift SYSCFG_EXTICR3 bis! ;  \ SYSCFG_EXTICR3_EXTI10    EXTI 10 configuration bits
: SYSCFG_EXTICR3_EXTI9   ( %XXXX -- ) 4 lshift SYSCFG_EXTICR3 bis! ;  \ SYSCFG_EXTICR3_EXTI9    EXTI 9 configuration bits
: SYSCFG_EXTICR3_EXTI8   ( %XXXX -- ) 0 lshift SYSCFG_EXTICR3 bis! ;  \ SYSCFG_EXTICR3_EXTI8    EXTI 8 configuration bits

\ SYSCFG_EXTICR4 (read-write)
: SYSCFG_EXTICR4_EXTI15   ( %XXXX -- ) 12 lshift SYSCFG_EXTICR4 bis! ;  \ SYSCFG_EXTICR4_EXTI15    EXTI 15 configuration bits
: SYSCFG_EXTICR4_EXTI14   ( %XXXX -- ) 8 lshift SYSCFG_EXTICR4 bis! ;  \ SYSCFG_EXTICR4_EXTI14    EXTI 14 configuration bits
: SYSCFG_EXTICR4_EXTI13   ( %XXXX -- ) 4 lshift SYSCFG_EXTICR4 bis! ;  \ SYSCFG_EXTICR4_EXTI13    EXTI 13 configuration bits
: SYSCFG_EXTICR4_EXTI12   ( %XXXX -- ) 0 lshift SYSCFG_EXTICR4 bis! ;  \ SYSCFG_EXTICR4_EXTI12    EXTI 12 configuration bits

\ SYSCFG_CFGR2 (read-write)
: SYSCFG_CFGR2_SRAM_PEF   %1 8 lshift SYSCFG_CFGR2 bis! ;  \ SYSCFG_CFGR2_SRAM_PEF    SRAM parity flag
: SYSCFG_CFGR2_PVD_LOCK   %1 2 lshift SYSCFG_CFGR2 bis! ;  \ SYSCFG_CFGR2_PVD_LOCK    PVD lock enable bit
: SYSCFG_CFGR2_SRAM_PARITY_LOCK   %1 1 lshift SYSCFG_CFGR2 bis! ;  \ SYSCFG_CFGR2_SRAM_PARITY_LOCK    SRAM parity lock bit
: SYSCFG_CFGR2_LOCUP_LOCK   %1 0 lshift SYSCFG_CFGR2 bis! ;  \ SYSCFG_CFGR2_LOCUP_LOCK    Cortex-M0 LOCKUP bit enable  bit

\ ADC_ISR (read-write)
: ADC_ISR_AWD   %1 7 lshift ADC_ISR bis! ;  \ ADC_ISR_AWD    Analog watchdog flag
: ADC_ISR_OVR   %1 4 lshift ADC_ISR bis! ;  \ ADC_ISR_OVR    ADC overrun
: ADC_ISR_EOS   %1 3 lshift ADC_ISR bis! ;  \ ADC_ISR_EOS    End of sequence flag
: ADC_ISR_EOC   %1 2 lshift ADC_ISR bis! ;  \ ADC_ISR_EOC    End of conversion flag
: ADC_ISR_EOSMP   %1 1 lshift ADC_ISR bis! ;  \ ADC_ISR_EOSMP    End of sampling flag
: ADC_ISR_ADRDY   %1 0 lshift ADC_ISR bis! ;  \ ADC_ISR_ADRDY    ADC ready

\ ADC_IER (read-write)
: ADC_IER_AWDIE   %1 7 lshift ADC_IER bis! ;  \ ADC_IER_AWDIE    Analog watchdog interrupt  enable
: ADC_IER_OVRIE   %1 4 lshift ADC_IER bis! ;  \ ADC_IER_OVRIE    Overrun interrupt enable
: ADC_IER_EOSIE   %1 3 lshift ADC_IER bis! ;  \ ADC_IER_EOSIE    End of conversion sequence interrupt  enable
: ADC_IER_EOCIE   %1 2 lshift ADC_IER bis! ;  \ ADC_IER_EOCIE    End of conversion interrupt  enable
: ADC_IER_EOSMPIE   %1 1 lshift ADC_IER bis! ;  \ ADC_IER_EOSMPIE    End of sampling flag interrupt  enable
: ADC_IER_ADRDYIE   %1 0 lshift ADC_IER bis! ;  \ ADC_IER_ADRDYIE    ADC ready interrupt enable

\ ADC_CR (read-write)
: ADC_CR_ADCAL   %1 31 lshift ADC_CR bis! ;  \ ADC_CR_ADCAL    ADC calibration
: ADC_CR_ADSTP   %1 4 lshift ADC_CR bis! ;  \ ADC_CR_ADSTP    ADC stop conversion  command
: ADC_CR_ADSTART   %1 2 lshift ADC_CR bis! ;  \ ADC_CR_ADSTART    ADC start conversion  command
: ADC_CR_ADDIS   %1 1 lshift ADC_CR bis! ;  \ ADC_CR_ADDIS    ADC disable command
: ADC_CR_ADEN   %1 0 lshift ADC_CR bis! ;  \ ADC_CR_ADEN    ADC enable command

\ ADC_CFGR1 (read-write)
: ADC_CFGR1_AWDCH   ( %XXXXX -- ) 26 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_AWDCH    Analog watchdog channel  selection
: ADC_CFGR1_AWDEN   %1 23 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_AWDEN    Analog watchdog enable
: ADC_CFGR1_AWDSGL   %1 22 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_AWDSGL    Enable the watchdog on a single channel  or on all channels
: ADC_CFGR1_DISCEN   %1 16 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_DISCEN    Discontinuous mode
: ADC_CFGR1_AUTOFF   %1 15 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_AUTOFF    Auto-off mode
: ADC_CFGR1_AUTDLY   %1 14 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_AUTDLY    Auto-delayed conversion  mode
: ADC_CFGR1_CONT   %1 13 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_CONT    Single / continuous conversion  mode
: ADC_CFGR1_OVRMOD   %1 12 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_OVRMOD    Overrun management mode
: ADC_CFGR1_EXTEN   ( %XX -- ) 10 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_EXTEN    External trigger enable and polarity  selection
: ADC_CFGR1_EXTSEL   ( %XXX -- ) 6 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_EXTSEL    External trigger selection
: ADC_CFGR1_ALIGN   %1 5 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_ALIGN    Data alignment
: ADC_CFGR1_RES   ( %XX -- ) 3 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_RES    Data resolution
: ADC_CFGR1_SCANDIR   %1 2 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_SCANDIR    Scan sequence direction
: ADC_CFGR1_DMACFG   %1 1 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_DMACFG    Direct memery access  configuration
: ADC_CFGR1_DMAEN   %1 0 lshift ADC_CFGR1 bis! ;  \ ADC_CFGR1_DMAEN    Direct memory access  enable

\ ADC_CFGR2 (read-write)
: ADC_CFGR2_JITOFF_D4   %1 31 lshift ADC_CFGR2 bis! ;  \ ADC_CFGR2_JITOFF_D4    JITOFF_D4
: ADC_CFGR2_JITOFF_D2   %1 30 lshift ADC_CFGR2 bis! ;  \ ADC_CFGR2_JITOFF_D2    JITOFF_D2

\ ADC_SMPR (read-write)
: ADC_SMPR_SMPR   ( %XXX -- ) 0 lshift ADC_SMPR bis! ;  \ ADC_SMPR_SMPR    Sampling time selection

\ ADC_TR (read-write)
: ADC_TR_HT   ( %XXXXXXXXXXX -- ) 16 lshift ADC_TR bis! ;  \ ADC_TR_HT    Analog watchdog higher  threshold
: ADC_TR_LT   ( %XXXXXXXXXXX -- ) 0 lshift ADC_TR bis! ;  \ ADC_TR_LT    Analog watchdog lower  threshold

\ ADC_CHSELR (read-write)
: ADC_CHSELR_CHSEL18   %1 18 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL18    Channel-x selection
: ADC_CHSELR_CHSEL17   %1 17 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL17    Channel-x selection
: ADC_CHSELR_CHSEL16   %1 16 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL16    Channel-x selection
: ADC_CHSELR_CHSEL15   %1 15 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL15    Channel-x selection
: ADC_CHSELR_CHSEL14   %1 14 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL14    Channel-x selection
: ADC_CHSELR_CHSEL13   %1 13 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL13    Channel-x selection
: ADC_CHSELR_CHSEL12   %1 12 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL12    Channel-x selection
: ADC_CHSELR_CHSEL11   %1 11 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL11    Channel-x selection
: ADC_CHSELR_CHSEL10   %1 10 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL10    Channel-x selection
: ADC_CHSELR_CHSEL9   %1 9 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL9    Channel-x selection
: ADC_CHSELR_CHSEL8   %1 8 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL8    Channel-x selection
: ADC_CHSELR_CHSEL7   %1 7 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL7    Channel-x selection
: ADC_CHSELR_CHSEL6   %1 6 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL6    Channel-x selection
: ADC_CHSELR_CHSEL5   %1 5 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL5    Channel-x selection
: ADC_CHSELR_CHSEL4   %1 4 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL4    Channel-x selection
: ADC_CHSELR_CHSEL3   %1 3 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL3    Channel-x selection
: ADC_CHSELR_CHSEL2   %1 2 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL2    Channel-x selection
: ADC_CHSELR_CHSEL1   %1 1 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL1    Channel-x selection
: ADC_CHSELR_CHSEL0   %1 0 lshift ADC_CHSELR bis! ;  \ ADC_CHSELR_CHSEL0    Channel-x selection

\ ADC_DR (read-only)
: ADC_DR_DATA   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift ADC_DR bis! ;  \ ADC_DR_DATA    Converted data

\ ADC_CCR (read-write)
: ADC_CCR_VBATEN   %1 24 lshift ADC_CCR bis! ;  \ ADC_CCR_VBATEN    VBAT enable
: ADC_CCR_TSEN   %1 23 lshift ADC_CCR bis! ;  \ ADC_CCR_TSEN    Temperature sensor enable
: ADC_CCR_VREFEN   %1 22 lshift ADC_CCR bis! ;  \ ADC_CCR_VREFEN    Temperature sensor and VREFINT  enable

\ USART1_CR1 (read-write)
: USART1_CR1_UE   %1 0 lshift USART1_CR1 bis! ;  \ USART1_CR1_UE    USART enable
: USART1_CR1_UESM   %1 1 lshift USART1_CR1 bis! ;  \ USART1_CR1_UESM    USART enable in Stop mode
: USART1_CR1_RE   %1 2 lshift USART1_CR1 bis! ;  \ USART1_CR1_RE    Receiver enable
: USART1_CR1_TE   %1 3 lshift USART1_CR1 bis! ;  \ USART1_CR1_TE    Transmitter enable
: USART1_CR1_IDLEIE   %1 4 lshift USART1_CR1 bis! ;  \ USART1_CR1_IDLEIE    IDLE interrupt enable
: USART1_CR1_RXNEIE   %1 5 lshift USART1_CR1 bis! ;  \ USART1_CR1_RXNEIE    RXNE interrupt enable
: USART1_CR1_TCIE   %1 6 lshift USART1_CR1 bis! ;  \ USART1_CR1_TCIE    Transmission complete interrupt  enable
: USART1_CR1_TXEIE   %1 7 lshift USART1_CR1 bis! ;  \ USART1_CR1_TXEIE    interrupt enable
: USART1_CR1_PEIE   %1 8 lshift USART1_CR1 bis! ;  \ USART1_CR1_PEIE    PE interrupt enable
: USART1_CR1_PS   %1 9 lshift USART1_CR1 bis! ;  \ USART1_CR1_PS    Parity selection
: USART1_CR1_PCE   %1 10 lshift USART1_CR1 bis! ;  \ USART1_CR1_PCE    Parity control enable
: USART1_CR1_WAKE   %1 11 lshift USART1_CR1 bis! ;  \ USART1_CR1_WAKE    Receiver wakeup method
: USART1_CR1_M   %1 12 lshift USART1_CR1 bis! ;  \ USART1_CR1_M    Word length
: USART1_CR1_MME   %1 13 lshift USART1_CR1 bis! ;  \ USART1_CR1_MME    Mute mode enable
: USART1_CR1_CMIE   %1 14 lshift USART1_CR1 bis! ;  \ USART1_CR1_CMIE    Character match interrupt  enable
: USART1_CR1_OVER8   %1 15 lshift USART1_CR1 bis! ;  \ USART1_CR1_OVER8    Oversampling mode
: USART1_CR1_DEDT   ( %XXXXX -- ) 16 lshift USART1_CR1 bis! ;  \ USART1_CR1_DEDT    Driver Enable deassertion  time
: USART1_CR1_DEAT   ( %XXXXX -- ) 21 lshift USART1_CR1 bis! ;  \ USART1_CR1_DEAT    Driver Enable assertion  time
: USART1_CR1_RTOIE   %1 26 lshift USART1_CR1 bis! ;  \ USART1_CR1_RTOIE    Receiver timeout interrupt  enable
: USART1_CR1_EOBIE   %1 27 lshift USART1_CR1 bis! ;  \ USART1_CR1_EOBIE    End of Block interrupt  enable
: USART1_CR1_M1   %1 28 lshift USART1_CR1 bis! ;  \ USART1_CR1_M1    Word length

\ USART1_CR2 (read-write)
: USART1_CR2_ADD4   ( %XXXX -- ) 28 lshift USART1_CR2 bis! ;  \ USART1_CR2_ADD4    Address of the USART node
: USART1_CR2_ADD0   ( %XXXX -- ) 24 lshift USART1_CR2 bis! ;  \ USART1_CR2_ADD0    Address of the USART node
: USART1_CR2_RTOEN   %1 23 lshift USART1_CR2 bis! ;  \ USART1_CR2_RTOEN    Receiver timeout enable
: USART1_CR2_ABRMOD   ( %XX -- ) 21 lshift USART1_CR2 bis! ;  \ USART1_CR2_ABRMOD    Auto baud rate mode
: USART1_CR2_ABREN   %1 20 lshift USART1_CR2 bis! ;  \ USART1_CR2_ABREN    Auto baud rate enable
: USART1_CR2_MSBFIRST   %1 19 lshift USART1_CR2 bis! ;  \ USART1_CR2_MSBFIRST    Most significant bit first
: USART1_CR2_DATAINV   %1 18 lshift USART1_CR2 bis! ;  \ USART1_CR2_DATAINV    Binary data inversion
: USART1_CR2_TXINV   %1 17 lshift USART1_CR2 bis! ;  \ USART1_CR2_TXINV    TX pin active level  inversion
: USART1_CR2_RXINV   %1 16 lshift USART1_CR2 bis! ;  \ USART1_CR2_RXINV    RX pin active level  inversion
: USART1_CR2_SWAP   %1 15 lshift USART1_CR2 bis! ;  \ USART1_CR2_SWAP    Swap TX/RX pins
: USART1_CR2_LINEN   %1 14 lshift USART1_CR2 bis! ;  \ USART1_CR2_LINEN    LIN mode enable
: USART1_CR2_STOP   ( %XX -- ) 12 lshift USART1_CR2 bis! ;  \ USART1_CR2_STOP    STOP bits
: USART1_CR2_CLKEN   %1 11 lshift USART1_CR2 bis! ;  \ USART1_CR2_CLKEN    Clock enable
: USART1_CR2_CPOL   %1 10 lshift USART1_CR2 bis! ;  \ USART1_CR2_CPOL    Clock polarity
: USART1_CR2_CPHA   %1 9 lshift USART1_CR2 bis! ;  \ USART1_CR2_CPHA    Clock phase
: USART1_CR2_LBCL   %1 8 lshift USART1_CR2 bis! ;  \ USART1_CR2_LBCL    Last bit clock pulse
: USART1_CR2_LBDIE   %1 6 lshift USART1_CR2 bis! ;  \ USART1_CR2_LBDIE    LIN break detection interrupt  enable
: USART1_CR2_LBDL   %1 5 lshift USART1_CR2 bis! ;  \ USART1_CR2_LBDL    LIN break detection length
: USART1_CR2_ADDM7   %1 4 lshift USART1_CR2 bis! ;  \ USART1_CR2_ADDM7    7-bit Address Detection/4-bit Address  Detection

\ USART1_CR3 (read-write)
: USART1_CR3_WUFIE   %1 22 lshift USART1_CR3 bis! ;  \ USART1_CR3_WUFIE    Wakeup from Stop mode interrupt  enable
: USART1_CR3_WUS   ( %XX -- ) 20 lshift USART1_CR3 bis! ;  \ USART1_CR3_WUS    Wakeup from Stop mode interrupt flag  selection
: USART1_CR3_SCARCNT   ( %XXX -- ) 17 lshift USART1_CR3 bis! ;  \ USART1_CR3_SCARCNT    Smartcard auto-retry count
: USART1_CR3_DEP   %1 15 lshift USART1_CR3 bis! ;  \ USART1_CR3_DEP    Driver enable polarity  selection
: USART1_CR3_DEM   %1 14 lshift USART1_CR3 bis! ;  \ USART1_CR3_DEM    Driver enable mode
: USART1_CR3_DDRE   %1 13 lshift USART1_CR3 bis! ;  \ USART1_CR3_DDRE    DMA Disable on Reception  Error
: USART1_CR3_OVRDIS   %1 12 lshift USART1_CR3 bis! ;  \ USART1_CR3_OVRDIS    Overrun Disable
: USART1_CR3_ONEBIT   %1 11 lshift USART1_CR3 bis! ;  \ USART1_CR3_ONEBIT    One sample bit method  enable
: USART1_CR3_CTSIE   %1 10 lshift USART1_CR3 bis! ;  \ USART1_CR3_CTSIE    CTS interrupt enable
: USART1_CR3_CTSE   %1 9 lshift USART1_CR3 bis! ;  \ USART1_CR3_CTSE    CTS enable
: USART1_CR3_RTSE   %1 8 lshift USART1_CR3 bis! ;  \ USART1_CR3_RTSE    RTS enable
: USART1_CR3_DMAT   %1 7 lshift USART1_CR3 bis! ;  \ USART1_CR3_DMAT    DMA enable transmitter
: USART1_CR3_DMAR   %1 6 lshift USART1_CR3 bis! ;  \ USART1_CR3_DMAR    DMA enable receiver
: USART1_CR3_SCEN   %1 5 lshift USART1_CR3 bis! ;  \ USART1_CR3_SCEN    Smartcard mode enable
: USART1_CR3_NACK   %1 4 lshift USART1_CR3 bis! ;  \ USART1_CR3_NACK    Smartcard NACK enable
: USART1_CR3_HDSEL   %1 3 lshift USART1_CR3 bis! ;  \ USART1_CR3_HDSEL    Half-duplex selection
: USART1_CR3_IRLP   %1 2 lshift USART1_CR3 bis! ;  \ USART1_CR3_IRLP    IrDA low-power
: USART1_CR3_IREN   %1 1 lshift USART1_CR3 bis! ;  \ USART1_CR3_IREN    IrDA mode enable
: USART1_CR3_EIE   %1 0 lshift USART1_CR3 bis! ;  \ USART1_CR3_EIE    Error interrupt enable

\ USART1_BRR (read-write)
: USART1_BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART1_BRR bis! ;  \ USART1_BRR_DIV_Mantissa    mantissa of USARTDIV
: USART1_BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART1_BRR bis! ;  \ USART1_BRR_DIV_Fraction    fraction of USARTDIV

\ USART1_GTPR (read-write)
: USART1_GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART1_GTPR bis! ;  \ USART1_GTPR_GT    Guard time value
: USART1_GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART1_GTPR bis! ;  \ USART1_GTPR_PSC    Prescaler value

\ USART1_RTOR (read-write)
: USART1_RTOR_BLEN   ( %XXXXXXXX -- ) 24 lshift USART1_RTOR bis! ;  \ USART1_RTOR_BLEN    Block Length
: USART1_RTOR_RTO   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift USART1_RTOR bis! ;  \ USART1_RTOR_RTO    Receiver timeout value

\ USART1_RQR (read-write)
: USART1_RQR_TXFRQ   %1 4 lshift USART1_RQR bis! ;  \ USART1_RQR_TXFRQ    Transmit data flush  request
: USART1_RQR_RXFRQ   %1 3 lshift USART1_RQR bis! ;  \ USART1_RQR_RXFRQ    Receive data flush request
: USART1_RQR_MMRQ   %1 2 lshift USART1_RQR bis! ;  \ USART1_RQR_MMRQ    Mute mode request
: USART1_RQR_SBKRQ   %1 1 lshift USART1_RQR bis! ;  \ USART1_RQR_SBKRQ    Send break request
: USART1_RQR_ABRRQ   %1 0 lshift USART1_RQR bis! ;  \ USART1_RQR_ABRRQ    Auto baud rate request

\ USART1_ISR (read-only)
: USART1_ISR_REACK   %1 22 lshift USART1_ISR bis! ;  \ USART1_ISR_REACK    Receive enable acknowledge  flag
: USART1_ISR_TEACK   %1 21 lshift USART1_ISR bis! ;  \ USART1_ISR_TEACK    Transmit enable acknowledge  flag
: USART1_ISR_WUF   %1 20 lshift USART1_ISR bis! ;  \ USART1_ISR_WUF    Wakeup from Stop mode flag
: USART1_ISR_RWU   %1 19 lshift USART1_ISR bis! ;  \ USART1_ISR_RWU    Receiver wakeup from Mute  mode
: USART1_ISR_SBKF   %1 18 lshift USART1_ISR bis! ;  \ USART1_ISR_SBKF    Send break flag
: USART1_ISR_CMF   %1 17 lshift USART1_ISR bis! ;  \ USART1_ISR_CMF    character match flag
: USART1_ISR_BUSY   %1 16 lshift USART1_ISR bis! ;  \ USART1_ISR_BUSY    Busy flag
: USART1_ISR_ABRF   %1 15 lshift USART1_ISR bis! ;  \ USART1_ISR_ABRF    Auto baud rate flag
: USART1_ISR_ABRE   %1 14 lshift USART1_ISR bis! ;  \ USART1_ISR_ABRE    Auto baud rate error
: USART1_ISR_EOBF   %1 12 lshift USART1_ISR bis! ;  \ USART1_ISR_EOBF    End of block flag
: USART1_ISR_RTOF   %1 11 lshift USART1_ISR bis! ;  \ USART1_ISR_RTOF    Receiver timeout
: USART1_ISR_CTS   %1 10 lshift USART1_ISR bis! ;  \ USART1_ISR_CTS    CTS flag
: USART1_ISR_CTSIF   %1 9 lshift USART1_ISR bis! ;  \ USART1_ISR_CTSIF    CTS interrupt flag
: USART1_ISR_LBDF   %1 8 lshift USART1_ISR bis! ;  \ USART1_ISR_LBDF    LIN break detection flag
: USART1_ISR_TXE   %1 7 lshift USART1_ISR bis! ;  \ USART1_ISR_TXE    Transmit data register  empty
: USART1_ISR_TC   %1 6 lshift USART1_ISR bis! ;  \ USART1_ISR_TC    Transmission complete
: USART1_ISR_RXNE   %1 5 lshift USART1_ISR bis! ;  \ USART1_ISR_RXNE    Read data register not  empty
: USART1_ISR_IDLE   %1 4 lshift USART1_ISR bis! ;  \ USART1_ISR_IDLE    Idle line detected
: USART1_ISR_ORE   %1 3 lshift USART1_ISR bis! ;  \ USART1_ISR_ORE    Overrun error
: USART1_ISR_NF   %1 2 lshift USART1_ISR bis! ;  \ USART1_ISR_NF    Noise detected flag
: USART1_ISR_FE   %1 1 lshift USART1_ISR bis! ;  \ USART1_ISR_FE    Framing error
: USART1_ISR_PE   %1 0 lshift USART1_ISR bis! ;  \ USART1_ISR_PE    Parity error

\ USART1_ICR (read-write)
: USART1_ICR_WUCF   %1 20 lshift USART1_ICR bis! ;  \ USART1_ICR_WUCF    Wakeup from Stop mode clear  flag
: USART1_ICR_CMCF   %1 17 lshift USART1_ICR bis! ;  \ USART1_ICR_CMCF    Character match clear flag
: USART1_ICR_EOBCF   %1 12 lshift USART1_ICR bis! ;  \ USART1_ICR_EOBCF    End of timeout clear flag
: USART1_ICR_RTOCF   %1 11 lshift USART1_ICR bis! ;  \ USART1_ICR_RTOCF    Receiver timeout clear  flag
: USART1_ICR_CTSCF   %1 9 lshift USART1_ICR bis! ;  \ USART1_ICR_CTSCF    CTS clear flag
: USART1_ICR_LBDCF   %1 8 lshift USART1_ICR bis! ;  \ USART1_ICR_LBDCF    LIN break detection clear  flag
: USART1_ICR_TCCF   %1 6 lshift USART1_ICR bis! ;  \ USART1_ICR_TCCF    Transmission complete clear  flag
: USART1_ICR_IDLECF   %1 4 lshift USART1_ICR bis! ;  \ USART1_ICR_IDLECF    Idle line detected clear  flag
: USART1_ICR_ORECF   %1 3 lshift USART1_ICR bis! ;  \ USART1_ICR_ORECF    Overrun error clear flag
: USART1_ICR_NCF   %1 2 lshift USART1_ICR bis! ;  \ USART1_ICR_NCF    Noise detected clear flag
: USART1_ICR_FECF   %1 1 lshift USART1_ICR bis! ;  \ USART1_ICR_FECF    Framing error clear flag
: USART1_ICR_PECF   %1 0 lshift USART1_ICR bis! ;  \ USART1_ICR_PECF    Parity error clear flag

\ USART1_RDR (read-only)
: USART1_RDR_RDR   ( %XXXXXXXXX -- ) 0 lshift USART1_RDR bis! ;  \ USART1_RDR_RDR    Receive data value

\ USART1_TDR (read-write)
: USART1_TDR_TDR   ( %XXXXXXXXX -- ) 0 lshift USART1_TDR bis! ;  \ USART1_TDR_TDR    Transmit data value

\ USART2_CR1 (read-write)
: USART2_CR1_UE   %1 0 lshift USART2_CR1 bis! ;  \ USART2_CR1_UE    USART enable
: USART2_CR1_UESM   %1 1 lshift USART2_CR1 bis! ;  \ USART2_CR1_UESM    USART enable in Stop mode
: USART2_CR1_RE   %1 2 lshift USART2_CR1 bis! ;  \ USART2_CR1_RE    Receiver enable
: USART2_CR1_TE   %1 3 lshift USART2_CR1 bis! ;  \ USART2_CR1_TE    Transmitter enable
: USART2_CR1_IDLEIE   %1 4 lshift USART2_CR1 bis! ;  \ USART2_CR1_IDLEIE    IDLE interrupt enable
: USART2_CR1_RXNEIE   %1 5 lshift USART2_CR1 bis! ;  \ USART2_CR1_RXNEIE    RXNE interrupt enable
: USART2_CR1_TCIE   %1 6 lshift USART2_CR1 bis! ;  \ USART2_CR1_TCIE    Transmission complete interrupt  enable
: USART2_CR1_TXEIE   %1 7 lshift USART2_CR1 bis! ;  \ USART2_CR1_TXEIE    interrupt enable
: USART2_CR1_PEIE   %1 8 lshift USART2_CR1 bis! ;  \ USART2_CR1_PEIE    PE interrupt enable
: USART2_CR1_PS   %1 9 lshift USART2_CR1 bis! ;  \ USART2_CR1_PS    Parity selection
: USART2_CR1_PCE   %1 10 lshift USART2_CR1 bis! ;  \ USART2_CR1_PCE    Parity control enable
: USART2_CR1_WAKE   %1 11 lshift USART2_CR1 bis! ;  \ USART2_CR1_WAKE    Receiver wakeup method
: USART2_CR1_M   %1 12 lshift USART2_CR1 bis! ;  \ USART2_CR1_M    Word length
: USART2_CR1_MME   %1 13 lshift USART2_CR1 bis! ;  \ USART2_CR1_MME    Mute mode enable
: USART2_CR1_CMIE   %1 14 lshift USART2_CR1 bis! ;  \ USART2_CR1_CMIE    Character match interrupt  enable
: USART2_CR1_OVER8   %1 15 lshift USART2_CR1 bis! ;  \ USART2_CR1_OVER8    Oversampling mode
: USART2_CR1_DEDT   ( %XXXXX -- ) 16 lshift USART2_CR1 bis! ;  \ USART2_CR1_DEDT    Driver Enable deassertion  time
: USART2_CR1_DEAT   ( %XXXXX -- ) 21 lshift USART2_CR1 bis! ;  \ USART2_CR1_DEAT    Driver Enable assertion  time
: USART2_CR1_RTOIE   %1 26 lshift USART2_CR1 bis! ;  \ USART2_CR1_RTOIE    Receiver timeout interrupt  enable
: USART2_CR1_EOBIE   %1 27 lshift USART2_CR1 bis! ;  \ USART2_CR1_EOBIE    End of Block interrupt  enable
: USART2_CR1_M1   %1 28 lshift USART2_CR1 bis! ;  \ USART2_CR1_M1    Word length

\ USART2_CR2 (read-write)
: USART2_CR2_ADD4   ( %XXXX -- ) 28 lshift USART2_CR2 bis! ;  \ USART2_CR2_ADD4    Address of the USART node
: USART2_CR2_ADD0   ( %XXXX -- ) 24 lshift USART2_CR2 bis! ;  \ USART2_CR2_ADD0    Address of the USART node
: USART2_CR2_RTOEN   %1 23 lshift USART2_CR2 bis! ;  \ USART2_CR2_RTOEN    Receiver timeout enable
: USART2_CR2_ABRMOD   ( %XX -- ) 21 lshift USART2_CR2 bis! ;  \ USART2_CR2_ABRMOD    Auto baud rate mode
: USART2_CR2_ABREN   %1 20 lshift USART2_CR2 bis! ;  \ USART2_CR2_ABREN    Auto baud rate enable
: USART2_CR2_MSBFIRST   %1 19 lshift USART2_CR2 bis! ;  \ USART2_CR2_MSBFIRST    Most significant bit first
: USART2_CR2_DATAINV   %1 18 lshift USART2_CR2 bis! ;  \ USART2_CR2_DATAINV    Binary data inversion
: USART2_CR2_TXINV   %1 17 lshift USART2_CR2 bis! ;  \ USART2_CR2_TXINV    TX pin active level  inversion
: USART2_CR2_RXINV   %1 16 lshift USART2_CR2 bis! ;  \ USART2_CR2_RXINV    RX pin active level  inversion
: USART2_CR2_SWAP   %1 15 lshift USART2_CR2 bis! ;  \ USART2_CR2_SWAP    Swap TX/RX pins
: USART2_CR2_LINEN   %1 14 lshift USART2_CR2 bis! ;  \ USART2_CR2_LINEN    LIN mode enable
: USART2_CR2_STOP   ( %XX -- ) 12 lshift USART2_CR2 bis! ;  \ USART2_CR2_STOP    STOP bits
: USART2_CR2_CLKEN   %1 11 lshift USART2_CR2 bis! ;  \ USART2_CR2_CLKEN    Clock enable
: USART2_CR2_CPOL   %1 10 lshift USART2_CR2 bis! ;  \ USART2_CR2_CPOL    Clock polarity
: USART2_CR2_CPHA   %1 9 lshift USART2_CR2 bis! ;  \ USART2_CR2_CPHA    Clock phase
: USART2_CR2_LBCL   %1 8 lshift USART2_CR2 bis! ;  \ USART2_CR2_LBCL    Last bit clock pulse
: USART2_CR2_LBDIE   %1 6 lshift USART2_CR2 bis! ;  \ USART2_CR2_LBDIE    LIN break detection interrupt  enable
: USART2_CR2_LBDL   %1 5 lshift USART2_CR2 bis! ;  \ USART2_CR2_LBDL    LIN break detection length
: USART2_CR2_ADDM7   %1 4 lshift USART2_CR2 bis! ;  \ USART2_CR2_ADDM7    7-bit Address Detection/4-bit Address  Detection

\ USART2_CR3 (read-write)
: USART2_CR3_WUFIE   %1 22 lshift USART2_CR3 bis! ;  \ USART2_CR3_WUFIE    Wakeup from Stop mode interrupt  enable
: USART2_CR3_WUS   ( %XX -- ) 20 lshift USART2_CR3 bis! ;  \ USART2_CR3_WUS    Wakeup from Stop mode interrupt flag  selection
: USART2_CR3_SCARCNT   ( %XXX -- ) 17 lshift USART2_CR3 bis! ;  \ USART2_CR3_SCARCNT    Smartcard auto-retry count
: USART2_CR3_DEP   %1 15 lshift USART2_CR3 bis! ;  \ USART2_CR3_DEP    Driver enable polarity  selection
: USART2_CR3_DEM   %1 14 lshift USART2_CR3 bis! ;  \ USART2_CR3_DEM    Driver enable mode
: USART2_CR3_DDRE   %1 13 lshift USART2_CR3 bis! ;  \ USART2_CR3_DDRE    DMA Disable on Reception  Error
: USART2_CR3_OVRDIS   %1 12 lshift USART2_CR3 bis! ;  \ USART2_CR3_OVRDIS    Overrun Disable
: USART2_CR3_ONEBIT   %1 11 lshift USART2_CR3 bis! ;  \ USART2_CR3_ONEBIT    One sample bit method  enable
: USART2_CR3_CTSIE   %1 10 lshift USART2_CR3 bis! ;  \ USART2_CR3_CTSIE    CTS interrupt enable
: USART2_CR3_CTSE   %1 9 lshift USART2_CR3 bis! ;  \ USART2_CR3_CTSE    CTS enable
: USART2_CR3_RTSE   %1 8 lshift USART2_CR3 bis! ;  \ USART2_CR3_RTSE    RTS enable
: USART2_CR3_DMAT   %1 7 lshift USART2_CR3 bis! ;  \ USART2_CR3_DMAT    DMA enable transmitter
: USART2_CR3_DMAR   %1 6 lshift USART2_CR3 bis! ;  \ USART2_CR3_DMAR    DMA enable receiver
: USART2_CR3_SCEN   %1 5 lshift USART2_CR3 bis! ;  \ USART2_CR3_SCEN    Smartcard mode enable
: USART2_CR3_NACK   %1 4 lshift USART2_CR3 bis! ;  \ USART2_CR3_NACK    Smartcard NACK enable
: USART2_CR3_HDSEL   %1 3 lshift USART2_CR3 bis! ;  \ USART2_CR3_HDSEL    Half-duplex selection
: USART2_CR3_IRLP   %1 2 lshift USART2_CR3 bis! ;  \ USART2_CR3_IRLP    IrDA low-power
: USART2_CR3_IREN   %1 1 lshift USART2_CR3 bis! ;  \ USART2_CR3_IREN    IrDA mode enable
: USART2_CR3_EIE   %1 0 lshift USART2_CR3 bis! ;  \ USART2_CR3_EIE    Error interrupt enable

\ USART2_BRR (read-write)
: USART2_BRR_DIV_Mantissa   ( %XXXXXXXXXXX -- ) 4 lshift USART2_BRR bis! ;  \ USART2_BRR_DIV_Mantissa    mantissa of USARTDIV
: USART2_BRR_DIV_Fraction   ( %XXXX -- ) 0 lshift USART2_BRR bis! ;  \ USART2_BRR_DIV_Fraction    fraction of USARTDIV

\ USART2_GTPR (read-write)
: USART2_GTPR_GT   ( %XXXXXXXX -- ) 8 lshift USART2_GTPR bis! ;  \ USART2_GTPR_GT    Guard time value
: USART2_GTPR_PSC   ( %XXXXXXXX -- ) 0 lshift USART2_GTPR bis! ;  \ USART2_GTPR_PSC    Prescaler value

\ USART2_RTOR (read-write)
: USART2_RTOR_BLEN   ( %XXXXXXXX -- ) 24 lshift USART2_RTOR bis! ;  \ USART2_RTOR_BLEN    Block Length
: USART2_RTOR_RTO   ( %XXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift USART2_RTOR bis! ;  \ USART2_RTOR_RTO    Receiver timeout value

\ USART2_RQR (read-write)
: USART2_RQR_TXFRQ   %1 4 lshift USART2_RQR bis! ;  \ USART2_RQR_TXFRQ    Transmit data flush  request
: USART2_RQR_RXFRQ   %1 3 lshift USART2_RQR bis! ;  \ USART2_RQR_RXFRQ    Receive data flush request
: USART2_RQR_MMRQ   %1 2 lshift USART2_RQR bis! ;  \ USART2_RQR_MMRQ    Mute mode request
: USART2_RQR_SBKRQ   %1 1 lshift USART2_RQR bis! ;  \ USART2_RQR_SBKRQ    Send break request
: USART2_RQR_ABRRQ   %1 0 lshift USART2_RQR bis! ;  \ USART2_RQR_ABRRQ    Auto baud rate request

\ USART2_ISR (read-only)
: USART2_ISR_REACK   %1 22 lshift USART2_ISR bis! ;  \ USART2_ISR_REACK    Receive enable acknowledge  flag
: USART2_ISR_TEACK   %1 21 lshift USART2_ISR bis! ;  \ USART2_ISR_TEACK    Transmit enable acknowledge  flag
: USART2_ISR_WUF   %1 20 lshift USART2_ISR bis! ;  \ USART2_ISR_WUF    Wakeup from Stop mode flag
: USART2_ISR_RWU   %1 19 lshift USART2_ISR bis! ;  \ USART2_ISR_RWU    Receiver wakeup from Mute  mode
: USART2_ISR_SBKF   %1 18 lshift USART2_ISR bis! ;  \ USART2_ISR_SBKF    Send break flag
: USART2_ISR_CMF   %1 17 lshift USART2_ISR bis! ;  \ USART2_ISR_CMF    character match flag
: USART2_ISR_BUSY   %1 16 lshift USART2_ISR bis! ;  \ USART2_ISR_BUSY    Busy flag
: USART2_ISR_ABRF   %1 15 lshift USART2_ISR bis! ;  \ USART2_ISR_ABRF    Auto baud rate flag
: USART2_ISR_ABRE   %1 14 lshift USART2_ISR bis! ;  \ USART2_ISR_ABRE    Auto baud rate error
: USART2_ISR_EOBF   %1 12 lshift USART2_ISR bis! ;  \ USART2_ISR_EOBF    End of block flag
: USART2_ISR_RTOF   %1 11 lshift USART2_ISR bis! ;  \ USART2_ISR_RTOF    Receiver timeout
: USART2_ISR_CTS   %1 10 lshift USART2_ISR bis! ;  \ USART2_ISR_CTS    CTS flag
: USART2_ISR_CTSIF   %1 9 lshift USART2_ISR bis! ;  \ USART2_ISR_CTSIF    CTS interrupt flag
: USART2_ISR_LBDF   %1 8 lshift USART2_ISR bis! ;  \ USART2_ISR_LBDF    LIN break detection flag
: USART2_ISR_TXE   %1 7 lshift USART2_ISR bis! ;  \ USART2_ISR_TXE    Transmit data register  empty
: USART2_ISR_TC   %1 6 lshift USART2_ISR bis! ;  \ USART2_ISR_TC    Transmission complete
: USART2_ISR_RXNE   %1 5 lshift USART2_ISR bis! ;  \ USART2_ISR_RXNE    Read data register not  empty
: USART2_ISR_IDLE   %1 4 lshift USART2_ISR bis! ;  \ USART2_ISR_IDLE    Idle line detected
: USART2_ISR_ORE   %1 3 lshift USART2_ISR bis! ;  \ USART2_ISR_ORE    Overrun error
: USART2_ISR_NF   %1 2 lshift USART2_ISR bis! ;  \ USART2_ISR_NF    Noise detected flag
: USART2_ISR_FE   %1 1 lshift USART2_ISR bis! ;  \ USART2_ISR_FE    Framing error
: USART2_ISR_PE   %1 0 lshift USART2_ISR bis! ;  \ USART2_ISR_PE    Parity error

\ USART2_ICR (read-write)
: USART2_ICR_WUCF   %1 20 lshift USART2_ICR bis! ;  \ USART2_ICR_WUCF    Wakeup from Stop mode clear  flag
: USART2_ICR_CMCF   %1 17 lshift USART2_ICR bis! ;  \ USART2_ICR_CMCF    Character match clear flag
: USART2_ICR_EOBCF   %1 12 lshift USART2_ICR bis! ;  \ USART2_ICR_EOBCF    End of timeout clear flag
: USART2_ICR_RTOCF   %1 11 lshift USART2_ICR bis! ;  \ USART2_ICR_RTOCF    Receiver timeout clear  flag
: USART2_ICR_CTSCF   %1 9 lshift USART2_ICR bis! ;  \ USART2_ICR_CTSCF    CTS clear flag
: USART2_ICR_LBDCF   %1 8 lshift USART2_ICR bis! ;  \ USART2_ICR_LBDCF    LIN break detection clear  flag
: USART2_ICR_TCCF   %1 6 lshift USART2_ICR bis! ;  \ USART2_ICR_TCCF    Transmission complete clear  flag
: USART2_ICR_IDLECF   %1 4 lshift USART2_ICR bis! ;  \ USART2_ICR_IDLECF    Idle line detected clear  flag
: USART2_ICR_ORECF   %1 3 lshift USART2_ICR bis! ;  \ USART2_ICR_ORECF    Overrun error clear flag
: USART2_ICR_NCF   %1 2 lshift USART2_ICR bis! ;  \ USART2_ICR_NCF    Noise detected clear flag
: USART2_ICR_FECF   %1 1 lshift USART2_ICR bis! ;  \ USART2_ICR_FECF    Framing error clear flag
: USART2_ICR_PECF   %1 0 lshift USART2_ICR bis! ;  \ USART2_ICR_PECF    Parity error clear flag

\ USART2_RDR (read-only)
: USART2_RDR_RDR   ( %XXXXXXXXX -- ) 0 lshift USART2_RDR bis! ;  \ USART2_RDR_RDR    Receive data value

\ USART2_TDR (read-write)
: USART2_TDR_TDR   ( %XXXXXXXXX -- ) 0 lshift USART2_TDR bis! ;  \ USART2_TDR_TDR    Transmit data value

\ RTC_TR (read-write)
: RTC_TR_PM   %1 22 lshift RTC_TR bis! ;  \ RTC_TR_PM    AM/PM notation
: RTC_TR_HT   ( %XX -- ) 20 lshift RTC_TR bis! ;  \ RTC_TR_HT    Hour tens in BCD format
: RTC_TR_HU   ( %XXXX -- ) 16 lshift RTC_TR bis! ;  \ RTC_TR_HU    Hour units in BCD format
: RTC_TR_MNT   ( %XXX -- ) 12 lshift RTC_TR bis! ;  \ RTC_TR_MNT    Minute tens in BCD format
: RTC_TR_MNU   ( %XXXX -- ) 8 lshift RTC_TR bis! ;  \ RTC_TR_MNU    Minute units in BCD format
: RTC_TR_ST   ( %XXX -- ) 4 lshift RTC_TR bis! ;  \ RTC_TR_ST    Second tens in BCD format
: RTC_TR_SU   ( %XXXX -- ) 0 lshift RTC_TR bis! ;  \ RTC_TR_SU    Second units in BCD format

\ RTC_DR (read-write)
: RTC_DR_YT   ( %XXXX -- ) 20 lshift RTC_DR bis! ;  \ RTC_DR_YT    Year tens in BCD format
: RTC_DR_YU   ( %XXXX -- ) 16 lshift RTC_DR bis! ;  \ RTC_DR_YU    Year units in BCD format
: RTC_DR_WDU   ( %XXX -- ) 13 lshift RTC_DR bis! ;  \ RTC_DR_WDU    Week day units
: RTC_DR_MT   %1 12 lshift RTC_DR bis! ;  \ RTC_DR_MT    Month tens in BCD format
: RTC_DR_MU   ( %XXXX -- ) 8 lshift RTC_DR bis! ;  \ RTC_DR_MU    Month units in BCD format
: RTC_DR_DT   ( %XX -- ) 4 lshift RTC_DR bis! ;  \ RTC_DR_DT    Date tens in BCD format
: RTC_DR_DU   ( %XXXX -- ) 0 lshift RTC_DR bis! ;  \ RTC_DR_DU    Date units in BCD format

\ RTC_CR ()
: RTC_CR_TSEDGE   %1 3 lshift RTC_CR bis! ;  \ RTC_CR_TSEDGE    Time-stamp event active  edge
: RTC_CR_REFCKON   %1 4 lshift RTC_CR bis! ;  \ RTC_CR_REFCKON    RTC_REFIN reference clock detection  enable 50 or 60 Hz
: RTC_CR_BYPSHAD   %1 5 lshift RTC_CR bis! ;  \ RTC_CR_BYPSHAD    Bypass the shadow  registers
: RTC_CR_FMT   %1 6 lshift RTC_CR bis! ;  \ RTC_CR_FMT    Hour format
: RTC_CR_ALRAE   %1 8 lshift RTC_CR bis! ;  \ RTC_CR_ALRAE    Alarm A enable
: RTC_CR_TSE   %1 11 lshift RTC_CR bis! ;  \ RTC_CR_TSE    timestamp enable
: RTC_CR_ALRAIE   %1 12 lshift RTC_CR bis! ;  \ RTC_CR_ALRAIE    Alarm A interrupt enable
: RTC_CR_TSIE   %1 15 lshift RTC_CR bis! ;  \ RTC_CR_TSIE    Time-stamp interrupt  enable
: RTC_CR_ADD1H   %1 16 lshift RTC_CR bis! ;  \ RTC_CR_ADD1H    Add 1 hour summer time  change
: RTC_CR_SUB1H   %1 17 lshift RTC_CR bis! ;  \ RTC_CR_SUB1H    Subtract 1 hour winter time  change
: RTC_CR_BKP   %1 18 lshift RTC_CR bis! ;  \ RTC_CR_BKP    Backup
: RTC_CR_COSEL   %1 19 lshift RTC_CR bis! ;  \ RTC_CR_COSEL    Calibration output  selection
: RTC_CR_POL   %1 20 lshift RTC_CR bis! ;  \ RTC_CR_POL    Output polarity
: RTC_CR_OSEL   ( %XX -- ) 21 lshift RTC_CR bis! ;  \ RTC_CR_OSEL    Output selection
: RTC_CR_COE   %1 23 lshift RTC_CR bis! ;  \ RTC_CR_COE    Calibration output enable

\ RTC_ISR ()
: RTC_ISR_ALRAWF   %1 0 lshift RTC_ISR bis! ;  \ RTC_ISR_ALRAWF    Alarm A write flag
: RTC_ISR_SHPF   %1 3 lshift RTC_ISR bis! ;  \ RTC_ISR_SHPF    Shift operation pending
: RTC_ISR_INITS   %1 4 lshift RTC_ISR bis! ;  \ RTC_ISR_INITS    Initialization status flag
: RTC_ISR_RSF   %1 5 lshift RTC_ISR bis! ;  \ RTC_ISR_RSF    Registers synchronization  flag
: RTC_ISR_INITF   %1 6 lshift RTC_ISR bis! ;  \ RTC_ISR_INITF    Initialization flag
: RTC_ISR_INIT   %1 7 lshift RTC_ISR bis! ;  \ RTC_ISR_INIT    Initialization mode
: RTC_ISR_ALRAF   %1 8 lshift RTC_ISR bis! ;  \ RTC_ISR_ALRAF    Alarm A flag
: RTC_ISR_TSF   %1 11 lshift RTC_ISR bis! ;  \ RTC_ISR_TSF    Time-stamp flag
: RTC_ISR_TSOVF   %1 12 lshift RTC_ISR bis! ;  \ RTC_ISR_TSOVF    Time-stamp overflow flag
: RTC_ISR_TAMP1F   %1 13 lshift RTC_ISR bis! ;  \ RTC_ISR_TAMP1F    RTC_TAMP1 detection flag
: RTC_ISR_TAMP2F   %1 14 lshift RTC_ISR bis! ;  \ RTC_ISR_TAMP2F    RTC_TAMP2 detection flag
: RTC_ISR_RECALPF   %1 16 lshift RTC_ISR bis! ;  \ RTC_ISR_RECALPF    Recalibration pending Flag

\ RTC_PRER (read-write)
: RTC_PRER_PREDIV_A   ( %XXXXXXX -- ) 16 lshift RTC_PRER bis! ;  \ RTC_PRER_PREDIV_A    Asynchronous prescaler  factor
: RTC_PRER_PREDIV_S   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC_PRER bis! ;  \ RTC_PRER_PREDIV_S    Synchronous prescaler  factor

\ RTC_ALRMAR (read-write)
: RTC_ALRMAR_MSK4   %1 31 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MSK4    Alarm A date mask
: RTC_ALRMAR_WDSEL   %1 30 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_WDSEL    Week day selection
: RTC_ALRMAR_DT   ( %XX -- ) 28 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_DT    Date tens in BCD format.
: RTC_ALRMAR_DU   ( %XXXX -- ) 24 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_DU    Date units or day in BCD  format.
: RTC_ALRMAR_MSK3   %1 23 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MSK3    Alarm A hours mask
: RTC_ALRMAR_PM   %1 22 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_PM    AM/PM notation
: RTC_ALRMAR_HT   ( %XX -- ) 20 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_HT    Hour tens in BCD format.
: RTC_ALRMAR_HU   ( %XXXX -- ) 16 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_HU    Hour units in BCD format.
: RTC_ALRMAR_MSK2   %1 15 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MSK2    Alarm A minutes mask
: RTC_ALRMAR_MNT   ( %XXX -- ) 12 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MNT    Minute tens in BCD format.
: RTC_ALRMAR_MNU   ( %XXXX -- ) 8 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MNU    Minute units in BCD  format.
: RTC_ALRMAR_MSK1   %1 7 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_MSK1    Alarm A seconds mask
: RTC_ALRMAR_ST   ( %XXX -- ) 4 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_ST    Second tens in BCD format.
: RTC_ALRMAR_SU   ( %XXXX -- ) 0 lshift RTC_ALRMAR bis! ;  \ RTC_ALRMAR_SU    Second units in BCD  format.

\ RTC_WPR (write-only)
: RTC_WPR_KEY   ( %XXXXXXXX -- ) 0 lshift RTC_WPR bis! ;  \ RTC_WPR_KEY    Write protection key

\ RTC_SSR (read-only)
: RTC_SSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC_SSR bis! ;  \ RTC_SSR_SS    Sub second value

\ RTC_SHIFTR (write-only)
: RTC_SHIFTR_ADD1S   %1 31 lshift RTC_SHIFTR bis! ;  \ RTC_SHIFTR_ADD1S    Reserved
: RTC_SHIFTR_SUBFS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC_SHIFTR bis! ;  \ RTC_SHIFTR_SUBFS    Subtract a fraction of a  second

\ RTC_TSTR (read-only)
: RTC_TSTR_PM   %1 22 lshift RTC_TSTR bis! ;  \ RTC_TSTR_PM    AM/PM notation
: RTC_TSTR_HT   ( %XX -- ) 20 lshift RTC_TSTR bis! ;  \ RTC_TSTR_HT    Hour tens in BCD format.
: RTC_TSTR_HU   ( %XXXX -- ) 16 lshift RTC_TSTR bis! ;  \ RTC_TSTR_HU    Hour units in BCD format.
: RTC_TSTR_MNT   ( %XXX -- ) 12 lshift RTC_TSTR bis! ;  \ RTC_TSTR_MNT    Minute tens in BCD format.
: RTC_TSTR_MNU   ( %XXXX -- ) 8 lshift RTC_TSTR bis! ;  \ RTC_TSTR_MNU    Minute units in BCD  format.
: RTC_TSTR_ST   ( %XXX -- ) 4 lshift RTC_TSTR bis! ;  \ RTC_TSTR_ST    Second tens in BCD format.
: RTC_TSTR_SU   ( %XXXX -- ) 0 lshift RTC_TSTR bis! ;  \ RTC_TSTR_SU    Second units in BCD  format.

\ RTC_TSDR (read-only)
: RTC_TSDR_WDU   ( %XXX -- ) 13 lshift RTC_TSDR bis! ;  \ RTC_TSDR_WDU    Week day units
: RTC_TSDR_MT   %1 12 lshift RTC_TSDR bis! ;  \ RTC_TSDR_MT    Month tens in BCD format
: RTC_TSDR_MU   ( %XXXX -- ) 8 lshift RTC_TSDR bis! ;  \ RTC_TSDR_MU    Month units in BCD format
: RTC_TSDR_DT   ( %XX -- ) 4 lshift RTC_TSDR bis! ;  \ RTC_TSDR_DT    Date tens in BCD format
: RTC_TSDR_DU   ( %XXXX -- ) 0 lshift RTC_TSDR bis! ;  \ RTC_TSDR_DU    Date units in BCD format

\ RTC_TSSSR (read-only)
: RTC_TSSSR_SS   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift RTC_TSSSR bis! ;  \ RTC_TSSSR_SS    Sub second value

\ RTC_CALR (read-write)
: RTC_CALR_CALP   %1 15 lshift RTC_CALR bis! ;  \ RTC_CALR_CALP    Use an 8-second calibration cycle  period
: RTC_CALR_CALW8   %1 14 lshift RTC_CALR bis! ;  \ RTC_CALR_CALW8    Use a 16-second calibration cycle  period
: RTC_CALR_CALW16   %1 13 lshift RTC_CALR bis! ;  \ RTC_CALR_CALW16    Reserved
: RTC_CALR_CALM   ( %XXXXXXXXX -- ) 0 lshift RTC_CALR bis! ;  \ RTC_CALR_CALM    Calibration minus

\ RTC_TAFCR (read-write)
: RTC_TAFCR_PC15MODE   %1 23 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC15MODE    PC15 mode
: RTC_TAFCR_PC15VALUE   %1 22 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC15VALUE    PC15 value
: RTC_TAFCR_PC14MODE   %1 21 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC14MODE    PC14 mode
: RTC_TAFCR_PC14VALUE   %1 20 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC14VALUE    PC14 value
: RTC_TAFCR_PC13MODE   %1 19 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC13MODE    PC13 mode
: RTC_TAFCR_PC13VALUE   %1 18 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_PC13VALUE    RTC_ALARM output type/PC13  value
: RTC_TAFCR_TAMP_PUDIS   %1 15 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP_PUDIS    RTC_TAMPx pull-up disable
: RTC_TAFCR_TAMP_PRCH   ( %XX -- ) 13 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP_PRCH    RTC_TAMPx precharge  duration
: RTC_TAFCR_TAMPFLT   ( %XX -- ) 11 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMPFLT    RTC_TAMPx filter count
: RTC_TAFCR_TAMPFREQ   ( %XXX -- ) 8 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMPFREQ    Tamper sampling frequency
: RTC_TAFCR_TAMPTS   %1 7 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMPTS    Activate timestamp on tamper detection  event
: RTC_TAFCR_TAMP2_TRG   %1 4 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP2_TRG    Active level for RTC_TAMP2  input
: RTC_TAFCR_TAMP2E   %1 3 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP2E    RTC_TAMP2 input detection  enable
: RTC_TAFCR_TAMPIE   %1 2 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMPIE    Tamper interrupt enable
: RTC_TAFCR_TAMP1TRG   %1 1 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP1TRG    Active level for RTC_TAMP1  input
: RTC_TAFCR_TAMP1E   %1 0 lshift RTC_TAFCR bis! ;  \ RTC_TAFCR_TAMP1E    RTC_TAMP1 input detection  enable

\ RTC_ALRMASSR (read-write)
: RTC_ALRMASSR_MASKSS   ( %XXXX -- ) 24 lshift RTC_ALRMASSR bis! ;  \ RTC_ALRMASSR_MASKSS    Mask the most-significant bits starting  at this bit
: RTC_ALRMASSR_SS   ( %XXXXXXXXXXXXXXX -- ) 0 lshift RTC_ALRMASSR bis! ;  \ RTC_ALRMASSR_SS    Sub seconds value

\ RTC_BKP0R (read-write)
: RTC_BKP0R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC_BKP0R bis! ;  \ RTC_BKP0R_BKP    BKP

\ RTC_BKP1R (read-write)
: RTC_BKP1R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC_BKP1R bis! ;  \ RTC_BKP1R_BKP    BKP

\ RTC_BKP2R (read-write)
: RTC_BKP2R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC_BKP2R bis! ;  \ RTC_BKP2R_BKP    BKP

\ RTC_BKP3R (read-write)
: RTC_BKP3R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC_BKP3R bis! ;  \ RTC_BKP3R_BKP    BKP

\ RTC_BKP4R (read-write)
: RTC_BKP4R_BKP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift RTC_BKP4R bis! ;  \ RTC_BKP4R_BKP    BKP

\ TIM15_CR1 (read-write)
: TIM15_CR1_CKD   ( %XX -- ) 8 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_CKD    Clock division
: TIM15_CR1_ARPE   %1 7 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_ARPE    Auto-reload preload enable
: TIM15_CR1_OPM   %1 3 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_OPM    One-pulse mode
: TIM15_CR1_URS   %1 2 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_URS    Update request source
: TIM15_CR1_UDIS   %1 1 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_UDIS    Update disable
: TIM15_CR1_CEN   %1 0 lshift TIM15_CR1 bis! ;  \ TIM15_CR1_CEN    Counter enable

\ TIM15_CR2 (read-write)
: TIM15_CR2_OIS2   %1 10 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_OIS2    Output Idle state 2
: TIM15_CR2_OIS1N   %1 9 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_OIS1N    Output Idle state 1
: TIM15_CR2_OIS1   %1 8 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_OIS1    Output Idle state 1
: TIM15_CR2_MMS   ( %XXX -- ) 4 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_MMS    Master mode selection
: TIM15_CR2_CCDS   %1 3 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_CCDS    Capture/compare DMA  selection
: TIM15_CR2_CCUS   %1 2 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_CCUS    Capture/compare control update  selection
: TIM15_CR2_CCPC   %1 0 lshift TIM15_CR2 bis! ;  \ TIM15_CR2_CCPC    Capture/compare preloaded  control

\ TIM15_SMCR (read-write)
: TIM15_SMCR_MSM   %1 7 lshift TIM15_SMCR bis! ;  \ TIM15_SMCR_MSM    Master/Slave mode
: TIM15_SMCR_TS   ( %XXX -- ) 4 lshift TIM15_SMCR bis! ;  \ TIM15_SMCR_TS    Trigger selection
: TIM15_SMCR_SMS   ( %XXX -- ) 0 lshift TIM15_SMCR bis! ;  \ TIM15_SMCR_SMS    Slave mode selection

\ TIM15_DIER (read-write)
: TIM15_DIER_TDE   %1 14 lshift TIM15_DIER bis! ;  \ TIM15_DIER_TDE    Trigger DMA request enable
: TIM15_DIER_CC2DE   %1 10 lshift TIM15_DIER bis! ;  \ TIM15_DIER_CC2DE    Capture/Compare 2 DMA request  enable
: TIM15_DIER_CC1DE   %1 9 lshift TIM15_DIER bis! ;  \ TIM15_DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM15_DIER_UDE   %1 8 lshift TIM15_DIER bis! ;  \ TIM15_DIER_UDE    Update DMA request enable
: TIM15_DIER_BIE   %1 7 lshift TIM15_DIER bis! ;  \ TIM15_DIER_BIE    Break interrupt enable
: TIM15_DIER_TIE   %1 6 lshift TIM15_DIER bis! ;  \ TIM15_DIER_TIE    Trigger interrupt enable
: TIM15_DIER_COMIE   %1 5 lshift TIM15_DIER bis! ;  \ TIM15_DIER_COMIE    COM interrupt enable
: TIM15_DIER_CC2IE   %1 2 lshift TIM15_DIER bis! ;  \ TIM15_DIER_CC2IE    Capture/Compare 2 interrupt  enable
: TIM15_DIER_CC1IE   %1 1 lshift TIM15_DIER bis! ;  \ TIM15_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM15_DIER_UIE   %1 0 lshift TIM15_DIER bis! ;  \ TIM15_DIER_UIE    Update interrupt enable

\ TIM15_SR (read-write)
: TIM15_SR_CC2OF   %1 10 lshift TIM15_SR bis! ;  \ TIM15_SR_CC2OF    Capture/compare 2 overcapture  flag
: TIM15_SR_CC1OF   %1 9 lshift TIM15_SR bis! ;  \ TIM15_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM15_SR_BIF   %1 7 lshift TIM15_SR bis! ;  \ TIM15_SR_BIF    Break interrupt flag
: TIM15_SR_TIF   %1 6 lshift TIM15_SR bis! ;  \ TIM15_SR_TIF    Trigger interrupt flag
: TIM15_SR_COMIF   %1 5 lshift TIM15_SR bis! ;  \ TIM15_SR_COMIF    COM interrupt flag
: TIM15_SR_CC2IF   %1 2 lshift TIM15_SR bis! ;  \ TIM15_SR_CC2IF    Capture/Compare 2 interrupt  flag
: TIM15_SR_CC1IF   %1 1 lshift TIM15_SR bis! ;  \ TIM15_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM15_SR_UIF   %1 0 lshift TIM15_SR bis! ;  \ TIM15_SR_UIF    Update interrupt flag

\ TIM15_EGR (write-only)
: TIM15_EGR_BG   %1 7 lshift TIM15_EGR bis! ;  \ TIM15_EGR_BG    Break generation
: TIM15_EGR_TG   %1 6 lshift TIM15_EGR bis! ;  \ TIM15_EGR_TG    Trigger generation
: TIM15_EGR_COMG   %1 5 lshift TIM15_EGR bis! ;  \ TIM15_EGR_COMG    Capture/Compare control update  generation
: TIM15_EGR_CC2G   %1 2 lshift TIM15_EGR bis! ;  \ TIM15_EGR_CC2G    Capture/compare 2  generation
: TIM15_EGR_CC1G   %1 1 lshift TIM15_EGR bis! ;  \ TIM15_EGR_CC1G    Capture/compare 1  generation
: TIM15_EGR_UG   %1 0 lshift TIM15_EGR bis! ;  \ TIM15_EGR_UG    Update generation

\ TIM15_CCMR1_Output (read-write)
: TIM15_CCMR1_Output_OC2M   ( %XXX -- ) 12 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC2M    Output Compare 2 mode
: TIM15_CCMR1_Output_OC2PE   %1 11 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC2PE    Output Compare 2 preload  enable
: TIM15_CCMR1_Output_OC2FE   %1 10 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC2FE    Output Compare 2 fast  enable
: TIM15_CCMR1_Output_CC2S   ( %XX -- ) 8 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_CC2S    Capture/Compare 2  selection
: TIM15_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC1M    Output Compare 1 mode
: TIM15_CCMR1_Output_OC1PE   %1 3 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM15_CCMR1_Output_OC1FE   %1 2 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM15_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM15_CCMR1_Output bis! ;  \ TIM15_CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM15_CCMR1_Input (read-write)
: TIM15_CCMR1_Input_IC2F   ( %XXXX -- ) 12 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_IC2F    Input capture 2 filter
: TIM15_CCMR1_Input_IC2PSC   ( %XX -- ) 10 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_IC2PSC    Input capture 2 prescaler
: TIM15_CCMR1_Input_CC2S   ( %XX -- ) 8 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_CC2S    Capture/Compare 2  selection
: TIM15_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_IC1F    Input capture 1 filter
: TIM15_CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM15_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM15_CCMR1_Input bis! ;  \ TIM15_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM15_CCER (read-write)
: TIM15_CCER_CC2NP   %1 7 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC2NP    Capture/Compare 2 output  Polarity
: TIM15_CCER_CC2P   %1 5 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC2P    Capture/Compare 2 output  Polarity
: TIM15_CCER_CC2E   %1 4 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC2E    Capture/Compare 2 output  enable
: TIM15_CCER_CC1NP   %1 3 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM15_CCER_CC1NE   %1 2 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM15_CCER_CC1P   %1 1 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM15_CCER_CC1E   %1 0 lshift TIM15_CCER bis! ;  \ TIM15_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM15_CNT (read-write)
: TIM15_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_CNT bis! ;  \ TIM15_CNT_CNT    counter value

\ TIM15_PSC (read-write)
: TIM15_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_PSC bis! ;  \ TIM15_PSC_PSC    Prescaler value

\ TIM15_ARR (read-write)
: TIM15_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_ARR bis! ;  \ TIM15_ARR_ARR    Auto-reload value

\ TIM15_RCR (read-write)
: TIM15_RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM15_RCR bis! ;  \ TIM15_RCR_REP    Repetition counter value

\ TIM15_CCR1 (read-write)
: TIM15_CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_CCR1 bis! ;  \ TIM15_CCR1_CCR1    Capture/Compare 1 value

\ TIM15_CCR2 (read-write)
: TIM15_CCR2_CCR2   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_CCR2 bis! ;  \ TIM15_CCR2_CCR2    Capture/Compare 2 value

\ TIM15_BDTR (read-write)
: TIM15_BDTR_MOE   %1 15 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_MOE    Main output enable
: TIM15_BDTR_AOE   %1 14 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_AOE    Automatic output enable
: TIM15_BDTR_BKP   %1 13 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_BKP    Break polarity
: TIM15_BDTR_BKE   %1 12 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_BKE    Break enable
: TIM15_BDTR_OSSR   %1 11 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_OSSR    Off-state selection for Run  mode
: TIM15_BDTR_OSSI   %1 10 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_OSSI    Off-state selection for Idle  mode
: TIM15_BDTR_LOCK   ( %XX -- ) 8 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_LOCK    Lock configuration
: TIM15_BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM15_BDTR bis! ;  \ TIM15_BDTR_DTG    Dead-time generator setup

\ TIM15_DCR (read-write)
: TIM15_DCR_DBL   ( %XXXXX -- ) 8 lshift TIM15_DCR bis! ;  \ TIM15_DCR_DBL    DMA burst length
: TIM15_DCR_DBA   ( %XXXXX -- ) 0 lshift TIM15_DCR bis! ;  \ TIM15_DCR_DBA    DMA base address

\ TIM15_DMAR (read-write)
: TIM15_DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM15_DMAR bis! ;  \ TIM15_DMAR_DMAB    DMA register for burst  accesses

\ TIM16_CR1 (read-write)
: TIM16_CR1_CKD   ( %XX -- ) 8 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_CKD    Clock division
: TIM16_CR1_ARPE   %1 7 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_ARPE    Auto-reload preload enable
: TIM16_CR1_OPM   %1 3 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_OPM    One-pulse mode
: TIM16_CR1_URS   %1 2 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_URS    Update request source
: TIM16_CR1_UDIS   %1 1 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_UDIS    Update disable
: TIM16_CR1_CEN   %1 0 lshift TIM16_CR1 bis! ;  \ TIM16_CR1_CEN    Counter enable

\ TIM16_CR2 (read-write)
: TIM16_CR2_OIS1N   %1 9 lshift TIM16_CR2 bis! ;  \ TIM16_CR2_OIS1N    Output Idle state 1
: TIM16_CR2_OIS1   %1 8 lshift TIM16_CR2 bis! ;  \ TIM16_CR2_OIS1    Output Idle state 1
: TIM16_CR2_CCDS   %1 3 lshift TIM16_CR2 bis! ;  \ TIM16_CR2_CCDS    Capture/compare DMA  selection
: TIM16_CR2_CCUS   %1 2 lshift TIM16_CR2 bis! ;  \ TIM16_CR2_CCUS    Capture/compare control update  selection
: TIM16_CR2_CCPC   %1 0 lshift TIM16_CR2 bis! ;  \ TIM16_CR2_CCPC    Capture/compare preloaded  control

\ TIM16_DIER (read-write)
: TIM16_DIER_TDE   %1 14 lshift TIM16_DIER bis! ;  \ TIM16_DIER_TDE    Trigger DMA request enable
: TIM16_DIER_CC1DE   %1 9 lshift TIM16_DIER bis! ;  \ TIM16_DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM16_DIER_UDE   %1 8 lshift TIM16_DIER bis! ;  \ TIM16_DIER_UDE    Update DMA request enable
: TIM16_DIER_BIE   %1 7 lshift TIM16_DIER bis! ;  \ TIM16_DIER_BIE    Break interrupt enable
: TIM16_DIER_TIE   %1 6 lshift TIM16_DIER bis! ;  \ TIM16_DIER_TIE    Trigger interrupt enable
: TIM16_DIER_COMIE   %1 5 lshift TIM16_DIER bis! ;  \ TIM16_DIER_COMIE    COM interrupt enable
: TIM16_DIER_CC1IE   %1 1 lshift TIM16_DIER bis! ;  \ TIM16_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM16_DIER_UIE   %1 0 lshift TIM16_DIER bis! ;  \ TIM16_DIER_UIE    Update interrupt enable

\ TIM16_SR (read-write)
: TIM16_SR_CC1OF   %1 9 lshift TIM16_SR bis! ;  \ TIM16_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM16_SR_BIF   %1 7 lshift TIM16_SR bis! ;  \ TIM16_SR_BIF    Break interrupt flag
: TIM16_SR_TIF   %1 6 lshift TIM16_SR bis! ;  \ TIM16_SR_TIF    Trigger interrupt flag
: TIM16_SR_COMIF   %1 5 lshift TIM16_SR bis! ;  \ TIM16_SR_COMIF    COM interrupt flag
: TIM16_SR_CC1IF   %1 1 lshift TIM16_SR bis! ;  \ TIM16_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM16_SR_UIF   %1 0 lshift TIM16_SR bis! ;  \ TIM16_SR_UIF    Update interrupt flag

\ TIM16_EGR (write-only)
: TIM16_EGR_BG   %1 7 lshift TIM16_EGR bis! ;  \ TIM16_EGR_BG    Break generation
: TIM16_EGR_TG   %1 6 lshift TIM16_EGR bis! ;  \ TIM16_EGR_TG    Trigger generation
: TIM16_EGR_COMG   %1 5 lshift TIM16_EGR bis! ;  \ TIM16_EGR_COMG    Capture/Compare control update  generation
: TIM16_EGR_CC1G   %1 1 lshift TIM16_EGR bis! ;  \ TIM16_EGR_CC1G    Capture/compare 1  generation
: TIM16_EGR_UG   %1 0 lshift TIM16_EGR bis! ;  \ TIM16_EGR_UG    Update generation

\ TIM16_CCMR1_Output (read-write)
: TIM16_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM16_CCMR1_Output bis! ;  \ TIM16_CCMR1_Output_OC1M    Output Compare 1 mode
: TIM16_CCMR1_Output_OC1PE   %1 3 lshift TIM16_CCMR1_Output bis! ;  \ TIM16_CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM16_CCMR1_Output_OC1FE   %1 2 lshift TIM16_CCMR1_Output bis! ;  \ TIM16_CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM16_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM16_CCMR1_Output bis! ;  \ TIM16_CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM16_CCMR1_Input (read-write)
: TIM16_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM16_CCMR1_Input bis! ;  \ TIM16_CCMR1_Input_IC1F    Input capture 1 filter
: TIM16_CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM16_CCMR1_Input bis! ;  \ TIM16_CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM16_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM16_CCMR1_Input bis! ;  \ TIM16_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM16_CCER (read-write)
: TIM16_CCER_CC1NP   %1 3 lshift TIM16_CCER bis! ;  \ TIM16_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM16_CCER_CC1NE   %1 2 lshift TIM16_CCER bis! ;  \ TIM16_CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM16_CCER_CC1P   %1 1 lshift TIM16_CCER bis! ;  \ TIM16_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM16_CCER_CC1E   %1 0 lshift TIM16_CCER bis! ;  \ TIM16_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM16_CNT (read-write)
: TIM16_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16_CNT bis! ;  \ TIM16_CNT_CNT    counter value

\ TIM16_PSC (read-write)
: TIM16_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16_PSC bis! ;  \ TIM16_PSC_PSC    Prescaler value

\ TIM16_ARR (read-write)
: TIM16_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16_ARR bis! ;  \ TIM16_ARR_ARR    Auto-reload value

\ TIM16_RCR (read-write)
: TIM16_RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM16_RCR bis! ;  \ TIM16_RCR_REP    Repetition counter value

\ TIM16_CCR1 (read-write)
: TIM16_CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16_CCR1 bis! ;  \ TIM16_CCR1_CCR1    Capture/Compare 1 value

\ TIM16_BDTR (read-write)
: TIM16_BDTR_MOE   %1 15 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_MOE    Main output enable
: TIM16_BDTR_AOE   %1 14 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_AOE    Automatic output enable
: TIM16_BDTR_BKP   %1 13 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_BKP    Break polarity
: TIM16_BDTR_BKE   %1 12 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_BKE    Break enable
: TIM16_BDTR_OSSR   %1 11 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_OSSR    Off-state selection for Run  mode
: TIM16_BDTR_OSSI   %1 10 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_OSSI    Off-state selection for Idle  mode
: TIM16_BDTR_LOCK   ( %XX -- ) 8 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_LOCK    Lock configuration
: TIM16_BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM16_BDTR bis! ;  \ TIM16_BDTR_DTG    Dead-time generator setup

\ TIM16_DCR (read-write)
: TIM16_DCR_DBL   ( %XXXXX -- ) 8 lshift TIM16_DCR bis! ;  \ TIM16_DCR_DBL    DMA burst length
: TIM16_DCR_DBA   ( %XXXXX -- ) 0 lshift TIM16_DCR bis! ;  \ TIM16_DCR_DBA    DMA base address

\ TIM16_DMAR (read-write)
: TIM16_DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM16_DMAR bis! ;  \ TIM16_DMAR_DMAB    DMA register for burst  accesses

\ TIM17_CR1 (read-write)
: TIM17_CR1_CKD   ( %XX -- ) 8 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_CKD    Clock division
: TIM17_CR1_ARPE   %1 7 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_ARPE    Auto-reload preload enable
: TIM17_CR1_OPM   %1 3 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_OPM    One-pulse mode
: TIM17_CR1_URS   %1 2 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_URS    Update request source
: TIM17_CR1_UDIS   %1 1 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_UDIS    Update disable
: TIM17_CR1_CEN   %1 0 lshift TIM17_CR1 bis! ;  \ TIM17_CR1_CEN    Counter enable

\ TIM17_CR2 (read-write)
: TIM17_CR2_OIS1N   %1 9 lshift TIM17_CR2 bis! ;  \ TIM17_CR2_OIS1N    Output Idle state 1
: TIM17_CR2_OIS1   %1 8 lshift TIM17_CR2 bis! ;  \ TIM17_CR2_OIS1    Output Idle state 1
: TIM17_CR2_CCDS   %1 3 lshift TIM17_CR2 bis! ;  \ TIM17_CR2_CCDS    Capture/compare DMA  selection
: TIM17_CR2_CCUS   %1 2 lshift TIM17_CR2 bis! ;  \ TIM17_CR2_CCUS    Capture/compare control update  selection
: TIM17_CR2_CCPC   %1 0 lshift TIM17_CR2 bis! ;  \ TIM17_CR2_CCPC    Capture/compare preloaded  control

\ TIM17_DIER (read-write)
: TIM17_DIER_TDE   %1 14 lshift TIM17_DIER bis! ;  \ TIM17_DIER_TDE    Trigger DMA request enable
: TIM17_DIER_CC1DE   %1 9 lshift TIM17_DIER bis! ;  \ TIM17_DIER_CC1DE    Capture/Compare 1 DMA request  enable
: TIM17_DIER_UDE   %1 8 lshift TIM17_DIER bis! ;  \ TIM17_DIER_UDE    Update DMA request enable
: TIM17_DIER_BIE   %1 7 lshift TIM17_DIER bis! ;  \ TIM17_DIER_BIE    Break interrupt enable
: TIM17_DIER_TIE   %1 6 lshift TIM17_DIER bis! ;  \ TIM17_DIER_TIE    Trigger interrupt enable
: TIM17_DIER_COMIE   %1 5 lshift TIM17_DIER bis! ;  \ TIM17_DIER_COMIE    COM interrupt enable
: TIM17_DIER_CC1IE   %1 1 lshift TIM17_DIER bis! ;  \ TIM17_DIER_CC1IE    Capture/Compare 1 interrupt  enable
: TIM17_DIER_UIE   %1 0 lshift TIM17_DIER bis! ;  \ TIM17_DIER_UIE    Update interrupt enable

\ TIM17_SR (read-write)
: TIM17_SR_CC1OF   %1 9 lshift TIM17_SR bis! ;  \ TIM17_SR_CC1OF    Capture/Compare 1 overcapture  flag
: TIM17_SR_BIF   %1 7 lshift TIM17_SR bis! ;  \ TIM17_SR_BIF    Break interrupt flag
: TIM17_SR_TIF   %1 6 lshift TIM17_SR bis! ;  \ TIM17_SR_TIF    Trigger interrupt flag
: TIM17_SR_COMIF   %1 5 lshift TIM17_SR bis! ;  \ TIM17_SR_COMIF    COM interrupt flag
: TIM17_SR_CC1IF   %1 1 lshift TIM17_SR bis! ;  \ TIM17_SR_CC1IF    Capture/compare 1 interrupt  flag
: TIM17_SR_UIF   %1 0 lshift TIM17_SR bis! ;  \ TIM17_SR_UIF    Update interrupt flag

\ TIM17_EGR (write-only)
: TIM17_EGR_BG   %1 7 lshift TIM17_EGR bis! ;  \ TIM17_EGR_BG    Break generation
: TIM17_EGR_TG   %1 6 lshift TIM17_EGR bis! ;  \ TIM17_EGR_TG    Trigger generation
: TIM17_EGR_COMG   %1 5 lshift TIM17_EGR bis! ;  \ TIM17_EGR_COMG    Capture/Compare control update  generation
: TIM17_EGR_CC1G   %1 1 lshift TIM17_EGR bis! ;  \ TIM17_EGR_CC1G    Capture/compare 1  generation
: TIM17_EGR_UG   %1 0 lshift TIM17_EGR bis! ;  \ TIM17_EGR_UG    Update generation

\ TIM17_CCMR1_Output (read-write)
: TIM17_CCMR1_Output_OC1M   ( %XXX -- ) 4 lshift TIM17_CCMR1_Output bis! ;  \ TIM17_CCMR1_Output_OC1M    Output Compare 1 mode
: TIM17_CCMR1_Output_OC1PE   %1 3 lshift TIM17_CCMR1_Output bis! ;  \ TIM17_CCMR1_Output_OC1PE    Output Compare 1 preload  enable
: TIM17_CCMR1_Output_OC1FE   %1 2 lshift TIM17_CCMR1_Output bis! ;  \ TIM17_CCMR1_Output_OC1FE    Output Compare 1 fast  enable
: TIM17_CCMR1_Output_CC1S   ( %XX -- ) 0 lshift TIM17_CCMR1_Output bis! ;  \ TIM17_CCMR1_Output_CC1S    Capture/Compare 1  selection

\ TIM17_CCMR1_Input (read-write)
: TIM17_CCMR1_Input_IC1F   ( %XXXX -- ) 4 lshift TIM17_CCMR1_Input bis! ;  \ TIM17_CCMR1_Input_IC1F    Input capture 1 filter
: TIM17_CCMR1_Input_IC1PSC   ( %XX -- ) 2 lshift TIM17_CCMR1_Input bis! ;  \ TIM17_CCMR1_Input_IC1PSC    Input capture 1 prescaler
: TIM17_CCMR1_Input_CC1S   ( %XX -- ) 0 lshift TIM17_CCMR1_Input bis! ;  \ TIM17_CCMR1_Input_CC1S    Capture/Compare 1  selection

\ TIM17_CCER (read-write)
: TIM17_CCER_CC1NP   %1 3 lshift TIM17_CCER bis! ;  \ TIM17_CCER_CC1NP    Capture/Compare 1 output  Polarity
: TIM17_CCER_CC1NE   %1 2 lshift TIM17_CCER bis! ;  \ TIM17_CCER_CC1NE    Capture/Compare 1 complementary output  enable
: TIM17_CCER_CC1P   %1 1 lshift TIM17_CCER bis! ;  \ TIM17_CCER_CC1P    Capture/Compare 1 output  Polarity
: TIM17_CCER_CC1E   %1 0 lshift TIM17_CCER bis! ;  \ TIM17_CCER_CC1E    Capture/Compare 1 output  enable

\ TIM17_CNT (read-write)
: TIM17_CNT_CNT   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17_CNT bis! ;  \ TIM17_CNT_CNT    counter value

\ TIM17_PSC (read-write)
: TIM17_PSC_PSC   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17_PSC bis! ;  \ TIM17_PSC_PSC    Prescaler value

\ TIM17_ARR (read-write)
: TIM17_ARR_ARR   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17_ARR bis! ;  \ TIM17_ARR_ARR    Auto-reload value

\ TIM17_RCR (read-write)
: TIM17_RCR_REP   ( %XXXXXXXX -- ) 0 lshift TIM17_RCR bis! ;  \ TIM17_RCR_REP    Repetition counter value

\ TIM17_CCR1 (read-write)
: TIM17_CCR1_CCR1   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17_CCR1 bis! ;  \ TIM17_CCR1_CCR1    Capture/Compare 1 value

\ TIM17_BDTR (read-write)
: TIM17_BDTR_MOE   %1 15 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_MOE    Main output enable
: TIM17_BDTR_AOE   %1 14 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_AOE    Automatic output enable
: TIM17_BDTR_BKP   %1 13 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_BKP    Break polarity
: TIM17_BDTR_BKE   %1 12 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_BKE    Break enable
: TIM17_BDTR_OSSR   %1 11 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_OSSR    Off-state selection for Run  mode
: TIM17_BDTR_OSSI   %1 10 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_OSSI    Off-state selection for Idle  mode
: TIM17_BDTR_LOCK   ( %XX -- ) 8 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_LOCK    Lock configuration
: TIM17_BDTR_DTG   ( %XXXXXXXX -- ) 0 lshift TIM17_BDTR bis! ;  \ TIM17_BDTR_DTG    Dead-time generator setup

\ TIM17_DCR (read-write)
: TIM17_DCR_DBL   ( %XXXXX -- ) 8 lshift TIM17_DCR bis! ;  \ TIM17_DCR_DBL    DMA burst length
: TIM17_DCR_DBA   ( %XXXXX -- ) 0 lshift TIM17_DCR bis! ;  \ TIM17_DCR_DBA    DMA base address

\ TIM17_DMAR (read-write)
: TIM17_DMAR_DMAB   ( %XXXXXXXXXXXXXXXX -- ) 0 lshift TIM17_DMAR bis! ;  \ TIM17_DMAR_DMAB    DMA register for burst  accesses

\ Flash_ACR ()
: Flash_ACR_LATENCY   ( %XXX -- ) 0 lshift Flash_ACR bis! ;  \ Flash_ACR_LATENCY    LATENCY
: Flash_ACR_PRFTBE   %1 4 lshift Flash_ACR bis! ;  \ Flash_ACR_PRFTBE    PRFTBE
: Flash_ACR_PRFTBS   %1 5 lshift Flash_ACR bis! ;  \ Flash_ACR_PRFTBS    PRFTBS

\ Flash_KEYR (write-only)
: Flash_KEYR_FKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash_KEYR bis! ;  \ Flash_KEYR_FKEYR    Flash Key

\ Flash_OPTKEYR (write-only)
: Flash_OPTKEYR_OPTKEYR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash_OPTKEYR bis! ;  \ Flash_OPTKEYR_OPTKEYR    Option byte key

\ Flash_SR ()
: Flash_SR_EOP   %1 5 lshift Flash_SR bis! ;  \ Flash_SR_EOP    End of operation
: Flash_SR_WRPRT   %1 4 lshift Flash_SR bis! ;  \ Flash_SR_WRPRT    Write protection error
: Flash_SR_PGERR   %1 2 lshift Flash_SR bis! ;  \ Flash_SR_PGERR    Programming error
: Flash_SR_BSY   %1 0 lshift Flash_SR bis! ;  \ Flash_SR_BSY    Busy

\ Flash_CR (read-write)
: Flash_CR_FORCE_OPTLOAD   %1 13 lshift Flash_CR bis! ;  \ Flash_CR_FORCE_OPTLOAD    Force option byte loading
: Flash_CR_EOPIE   %1 12 lshift Flash_CR bis! ;  \ Flash_CR_EOPIE    End of operation interrupt  enable
: Flash_CR_ERRIE   %1 10 lshift Flash_CR bis! ;  \ Flash_CR_ERRIE    Error interrupt enable
: Flash_CR_OPTWRE   %1 9 lshift Flash_CR bis! ;  \ Flash_CR_OPTWRE    Option bytes write enable
: Flash_CR_LOCK   %1 7 lshift Flash_CR bis! ;  \ Flash_CR_LOCK    Lock
: Flash_CR_STRT   %1 6 lshift Flash_CR bis! ;  \ Flash_CR_STRT    Start
: Flash_CR_OPTER   %1 5 lshift Flash_CR bis! ;  \ Flash_CR_OPTER    Option byte erase
: Flash_CR_OPTPG   %1 4 lshift Flash_CR bis! ;  \ Flash_CR_OPTPG    Option byte programming
: Flash_CR_MER   %1 2 lshift Flash_CR bis! ;  \ Flash_CR_MER    Mass erase
: Flash_CR_PER   %1 1 lshift Flash_CR bis! ;  \ Flash_CR_PER    Page erase
: Flash_CR_PG   %1 0 lshift Flash_CR bis! ;  \ Flash_CR_PG    Programming

\ Flash_AR (write-only)
: Flash_AR_FAR   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash_AR bis! ;  \ Flash_AR_FAR    Flash address

\ Flash_OBR (read-only)
: Flash_OBR_Data1   ( %XXXXXXXX -- ) 24 lshift Flash_OBR bis! ;  \ Flash_OBR_Data1    Data1
: Flash_OBR_Data0   ( %XXXXXXXX -- ) 16 lshift Flash_OBR bis! ;  \ Flash_OBR_Data0    Data0
: Flash_OBR_VDDA_MONITOR   %1 13 lshift Flash_OBR bis! ;  \ Flash_OBR_VDDA_MONITOR    VDDA_MONITOR
: Flash_OBR_BOOT1   %1 12 lshift Flash_OBR bis! ;  \ Flash_OBR_BOOT1    BOOT1
: Flash_OBR_nRST_STDBY   %1 10 lshift Flash_OBR bis! ;  \ Flash_OBR_nRST_STDBY    nRST_STDBY
: Flash_OBR_nRST_STOP   %1 9 lshift Flash_OBR bis! ;  \ Flash_OBR_nRST_STOP    nRST_STOP
: Flash_OBR_WDG_SW   %1 8 lshift Flash_OBR bis! ;  \ Flash_OBR_WDG_SW    WDG_SW
: Flash_OBR_LEVEL2_PROT   %1 2 lshift Flash_OBR bis! ;  \ Flash_OBR_LEVEL2_PROT    Level 2 protection status
: Flash_OBR_LEVEL1_PROT   %1 1 lshift Flash_OBR bis! ;  \ Flash_OBR_LEVEL1_PROT    Level 1 protection status
: Flash_OBR_OPTERR   %1 0 lshift Flash_OBR bis! ;  \ Flash_OBR_OPTERR    Option byte error

\ Flash_WRPR (read-only)
: Flash_WRPR_WRP   ( %XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX -- ) 0 lshift Flash_WRPR bis! ;  \ Flash_WRPR_WRP    Write protect

\ DBGMCU_IDCODE (read-only)
: DBGMCU_IDCODE_DEV_ID   ( %XXXXXXXXXXX -- ) 0 lshift DBGMCU_IDCODE bis! ;  \ DBGMCU_IDCODE_DEV_ID    Device Identifier
: DBGMCU_IDCODE_DIV_ID   ( %XXXX -- ) 12 lshift DBGMCU_IDCODE bis! ;  \ DBGMCU_IDCODE_DIV_ID    Division Identifier
: DBGMCU_IDCODE_REV_ID   ( %XXXXXXXXXXXXXXXX -- ) 16 lshift DBGMCU_IDCODE bis! ;  \ DBGMCU_IDCODE_REV_ID    Revision Identifier

\ DBGMCU_CR (read-write)
: DBGMCU_CR_DBG_STOP   %1 1 lshift DBGMCU_CR bis! ;  \ DBGMCU_CR_DBG_STOP    Debug Stop Mode
: DBGMCU_CR_DBG_STANDBY   %1 2 lshift DBGMCU_CR bis! ;  \ DBGMCU_CR_DBG_STANDBY    Debug Standby Mode

\ DBGMCU_APBLFZ (read-write)
: DBGMCU_APBLFZ_DBG_TIMER2_STOP   %1 0 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_TIMER2_STOP    Debug Timer 2 stopped when Core is  halted
: DBGMCU_APBLFZ_DBG_TIMER3_STOP   %1 1 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_TIMER3_STOP    Debug Timer 3 stopped when Core is  halted
: DBGMCU_APBLFZ_DBG_TIMER6_STOP   %1 4 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_TIMER6_STOP    Debug Timer 6 stopped when Core is  halted
: DBGMCU_APBLFZ_DBG_TIMER14_STOP   %1 8 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_TIMER14_STOP    Debug Timer 14 stopped when Core is  halted
: DBGMCU_APBLFZ_DBG_RTC_STOP   %1 10 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_RTC_STOP    Debug RTC stopped when Core is  halted
: DBGMCU_APBLFZ_DBG_WWDG_STOP   %1 11 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_WWDG_STOP    Debug Window Wachdog stopped when Core  is halted
: DBGMCU_APBLFZ_DBG_IWDG_STOP   %1 12 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_DBG_IWDG_STOP    Debug Independent Wachdog stopped when  Core is halted
: DBGMCU_APBLFZ_I2C1_SMBUS_TIMEOUT   %1 21 lshift DBGMCU_APBLFZ bis! ;  \ DBGMCU_APBLFZ_I2C1_SMBUS_TIMEOUT    SMBUS timeout mode stopped when Core is  halted

\ DBGMCU_APBHFZ (read-write)
: DBGMCU_APBHFZ_DBG_TIMER1_STOP   %1 11 lshift DBGMCU_APBHFZ bis! ;  \ DBGMCU_APBHFZ_DBG_TIMER1_STOP    Debug Timer 1 stopped when Core is  halted
: DBGMCU_APBHFZ_DBG_TIMER15_STO   %1 16 lshift DBGMCU_APBHFZ bis! ;  \ DBGMCU_APBHFZ_DBG_TIMER15_STO    Debug Timer 15 stopped when Core is  halted
: DBGMCU_APBHFZ_DBG_TIMER16_STO   %1 17 lshift DBGMCU_APBHFZ bis! ;  \ DBGMCU_APBHFZ_DBG_TIMER16_STO    Debug Timer 16 stopped when Core is  halted
: DBGMCU_APBHFZ_DBG_TIMER17_STO   %1 18 lshift DBGMCU_APBHFZ bis! ;  \ DBGMCU_APBHFZ_DBG_TIMER17_STO    Debug Timer 17 stopped when Core is  halted
