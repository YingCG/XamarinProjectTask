using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HikoiArt.Views
{
    public partial class TodoList : ContentPage
    {
        public TodoList()
        {
            InitializeComponent();
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}