using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground.Navigation.Popups
{
    public partial class ActionSheet : ContentPage
    {
        public ActionSheet()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy", "Send", "Email");
            await DisplayAlert("Response", response, "Ok");
        }
    }
}
