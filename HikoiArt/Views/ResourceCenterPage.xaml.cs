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
    public partial class ResourceCenterPage : ContentPage
    {
        public ResourceCenterPage()
        {
            InitializeComponent();
        }

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AddNewResource());
        }

        private async void getDetails_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.GetDetailsPage());
        }

        private async void editDetails_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.EditPage());
        }

        private async void manageEvent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PlannerPage());
        }

        
        private async void manageTask_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.MyResoucePage());
        }
    }
} 