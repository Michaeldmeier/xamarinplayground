using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace xamarinplayground.MVVM
{
    [DesignTimeVisible(false)]
    public partial class MyPage : ContentPage
    {
        private int counter = 0;

        public MyPage(MyPageViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}
