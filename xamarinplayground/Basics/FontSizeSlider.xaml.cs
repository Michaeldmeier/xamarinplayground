using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinplayground
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontSizeSlider : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };

        public FontSizeSlider()
        {
            InitializeComponent();
            slider.Value = 0.5;
            quote.Text = _quotes[_index];
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            quote.Text = _quotes[_index];
        }
    }
}
