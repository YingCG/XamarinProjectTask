using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HikoiArt.Views
{
    public partial class MyActivityPage : ContentPage
    {
        public MyActivityPage()
        {
            InitializeComponent();
        }

        async private void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ProfilePage());
        }

        async private void MyBooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MyBookingPage());
        }

        async private void MyActivity_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MyActivityPage());
         }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}
