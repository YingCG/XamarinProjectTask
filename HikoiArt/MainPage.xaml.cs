using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HikoiArt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BrowseBtn_Clicked(Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }  
}
