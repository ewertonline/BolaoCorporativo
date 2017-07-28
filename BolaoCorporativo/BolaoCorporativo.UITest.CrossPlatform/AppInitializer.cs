using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BolaoCorporativo.UITest.CrossPlatform
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("../../../BolaoCorporativo.Android/bin/Release/br.com.squadra.bolaocorporativo.android.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                //.AppBundle("/path/to/iosapp.app")
                .StartApp();
        }
    }
}

