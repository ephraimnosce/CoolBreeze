using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CoolBreeze
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;
        public static string RegistrationCode = "XBWW63199CCA79B09F4382D613C67AA2 or XBWWA1A0D6CC1D5C77B239BC0B274844";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
