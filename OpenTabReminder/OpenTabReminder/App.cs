using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTabReminder.Views;
using Xamarin.Forms;

namespace OpenTabReminder
{
    public class App : Application
    {
        public App()
        {
            ContentPage mike = new LandingPage();
            MainPage = mike;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
