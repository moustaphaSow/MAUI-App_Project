package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MoustaphaSyPhoneWord.MainApplication, MoustaphaSyPhoneWord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc648e4c93c8e37b4e63.MainApplication.class, crc648e4c93c8e37b4e63.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
