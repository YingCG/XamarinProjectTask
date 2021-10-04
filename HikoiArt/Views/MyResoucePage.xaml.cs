using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HikoiArt.Views
{
    public partial class MyResoucePage : ContentPage
    {
        public MyResoucePage()
        {
            InitializeComponent();
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}
