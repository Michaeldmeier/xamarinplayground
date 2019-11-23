using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinplayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculator.MainPage(new Calculator.Calculator());
            // MainPage = new NavigationPage(new Navigation.Hierarchical.WelcomePage());
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
