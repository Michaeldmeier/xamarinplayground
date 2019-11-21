using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground
{
    public partial class BindingContext : ContentPage
    {
        public BindingContext()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }
    }
}
