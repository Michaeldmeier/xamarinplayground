using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground.Navigation.Popups
{
    public partial class Alert : ContentPage
    {
        public Alert()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
                await DisplayAlert("Success", "Done", "Ok");
        }
    }
}
