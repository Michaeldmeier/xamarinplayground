using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarinplayground
{
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = String.Format("Wert: {0:F2}", e.NewValue);
        }
    }
}
