
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SWIGTYPE_p_unsigned_char ucBackBuf = new SWIGTYPE_p_unsigned_char(new IntPtr(), true);
//HandleRef ref = SWIGTYPE_p_unsigned_char.getCPtr(ucBackBuf);

SSOLED ssoled = new SSOLED();
int result = ss_oled.oledInit(ssoled, ss_oledPINVOKE.OLED_128x64_get(), -1, 1, 0, 1, 1, -1, -1, 400000);

Console.WriteLine(result);

if (result != -1) {
    Console.WriteLine("We are connected");

    ss_oled.oledSetBackBuffer(ssoled, ucBackBuf);
    ss_oled.oledFill(ssoled, 1, 1);


    Console.Beep();
    Console.WriteLine("Shutting down in 10 seconds");
    Thread.Sleep(10000);
    ss_oled.oledPower(ssoled, 0);

}

Console.WriteLine("Bye");
