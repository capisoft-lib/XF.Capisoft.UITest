using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Utils;

namespace XF.Capisoft.UITest
{
    public class AppInitializer
    {

        const string IpaPath = "../../../Binaries/TestingTest.ipa";
        const string DeviceUDID = "743B1E5D-6677-4267-A024-9369B2DA2A38";
        const string AppBundle = "com.ubp.TestingTest";


        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        public static IApp StartApp()
        {
            if (platform == Platform.Android)
            {
                app = ConfigureApp.Android.StartApp();
            }
            else if (platform == Platform.iOS)
            {
                var config = ConfigureApp.iOS;
                config = config.Debug();
                config = config.PreferIdeSettings();
                config = config.DeviceIdentifier(DeviceUDID);
                config = config.AppBundle(AppBundle);
                config = config.WaitTimes(new WaitTimes());
                app = config.StartApp();
            }
            return app;
        }
    }
}