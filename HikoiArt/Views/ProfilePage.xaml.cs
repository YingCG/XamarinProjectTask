using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HikoiArt.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        async private void ProfileSetting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
         }
        async private void MyBooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MyBookingPage());
        }

        async private void MyActivity_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.TodoList());
        }

        async private void MyResource_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.GetDetailsPage());
        }
    }
}
