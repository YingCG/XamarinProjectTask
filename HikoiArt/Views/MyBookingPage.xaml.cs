using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HikoiArt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyBookingPage : ContentPage
    {
        public MyBookingPage()
        {
            InitializeComponent();
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}