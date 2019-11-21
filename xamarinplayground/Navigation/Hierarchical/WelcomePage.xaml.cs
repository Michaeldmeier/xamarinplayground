using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground.Navigation.Hierarchical
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage());
            // In App.xaml.cs set:
            // MainPage = new NavigationPage(new Navigation.Hierarchical.WelcomePage());
        }
    }
}
