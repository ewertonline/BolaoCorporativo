using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace BolaoCorporativo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BolaoCorporativo.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            MobileCenter.Start(
                   "android=2b5ee3db-07c3-406c-aa34-9c311347ab4a;" +
                   "ios=3fa79e98-d61a-452d-a950-a77cdf688745;",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
