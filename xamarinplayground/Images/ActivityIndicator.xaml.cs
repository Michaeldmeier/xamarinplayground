using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground.Images
{
    public partial class ActivityIndicator : ContentPage
    {
        public ActivityIndicator()
        {
            InitializeComponent();

            var webImage = new UriImageSource
            {
                Uri = new Uri("https://lorempixel.com/400/200/sports/")
            };
            webImage.CachingEnabled = false;
            image.Source = webImage;
        }
    }
}
