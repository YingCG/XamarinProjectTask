using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HikoiArt.Views
{
    public partial class MyWalkPage : ContentPage
    {
        public MyWalkPage()
        {
            InitializeComponent();
        }

        async private void KeepTrack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.LoginPage());
        }

        async private void Profile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ProfilePage());
        }

        async private void NewsFeed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }

        async private void MyActivity_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MyActivityPage());
        }
    }
}
