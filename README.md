# Example programs with mecrisp-stellaris forth on an STM32F030F4

1. blink.fs uses a blocking delay.
 Also shows use of the INIT word to launch a program on boot.
1. btnled.fs demonstrates the use of GPIO input.
1. blink-systick.fs uses the systick timer for non-blocking
 cooperative multitasking.
1. blink-tim3-pwm.fs demonstrates PWM.
1. clockspeed.fs shows how to change clock speed between 8MHz and 48MHz.
1. ledTgl.fs shows the use of debounce state machine.
 Also demonstrates use of mecrisp-stellaris case word.
1. 1msSystick.fs is a reusable module to provide the initSystick word.
1. adc.fs provides ADC related routines.
 Also shows use of buffer: forth word, sequential DMA conversion and
 DMA transfers.
1. extIntr.fs demonstates the use of the External Interrupt feature.
1. usonic.fs has routines for the HC-SR04 ultrasonic range finder.
1. rtc.fs demonstrates use of the RealTime Clock.
1. wd.fs and wd-trig.fs demonstrate use of the watchdog timer.
 First load wd.fs to install a blink on reset routine.
 Then load wd-trig.fs to start the watchdog for a 3s timeout.

## Hardware
1. VDDA (pin 5) and VDD (pin 16) must both be connected to 3.3V .
1. VSS (pin 15) connected to 0V .
1. NRST (pin 4) connected via a push button switch to 0V .
1. BOOT0 (pin 1) connected to 0V .
1. PA9 / TxD (pin 17) connected to RxD on USB/TTL UART.
1. PA10 / RxD (pin 18) connected to TxD on USB/TTL UART.

## Serial Terminal
I use e4thcom to communicate with and program the STM32F030.
This is done via the USB/TTL UART.

```
e4thcom -d ttyUSB0 -b B115200 -t mecrisp-st
```

ttyUSB0 is the device name of my USB/TTL UART.
