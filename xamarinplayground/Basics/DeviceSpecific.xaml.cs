using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinplayground
{

    public partial class DeviceSpecific : ContentPage
    {
        public DeviceSpecific()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }
    }
}
