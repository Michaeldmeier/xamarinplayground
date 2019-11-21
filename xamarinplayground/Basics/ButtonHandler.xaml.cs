using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground.Basics
{
    public partial class ButtonHandler : ContentPage
    {
        public ButtonHandler()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => await DisplayAlert("Hello", "You clicked me", "Go away"));
        }
    }
}
