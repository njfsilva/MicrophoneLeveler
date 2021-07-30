If you have an audio interface you likely enjoy setting you audio levels in the hardware itself and would like to retain those setting system wide.

Windows has the unfurtunate habit of not retaining those setting, even when you don't allow individual applications to take control of your input device, and instead allows applications to set their own gain level.

This is unbelievably frustrating when you spend time adjusting your levels carefully on your hardware, or EqualizerAPO, and would like to always sound the same on every application other than your DAW, regardless of what that application "feels" is the correct level and adjusts itself.

This is expecially frustrating on web conferencing apps such as skype/zoom/bluejeans which constantly mess with your sound settings.


You can use MicrophoneLeveler to keep your microphone gain level at a set value forever, regardless of windows/apps settings so that you always sound the same on every app.


Suggested Use:

Set whatever level (in dB) you want on the application code (if your use case is like mine, this will always be 0) and use Windows TaskScheduler to start the application in the background during startup.


You will never need to set audio levels again for non-ASIO applications.


Was this useful? 

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=YPFFEYR92DXHL)
