using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HikoiArt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "resourcedb");
        Model.Resource resource = new Model.Resource();
        public EditPage()
        {
            InitializeComponent();
            var db = new SQLiteConnection(_dbpath);
            listview.ItemsSource = db.Table<Model.Resource>().OrderBy(x => x.ItemName).ToList();
            listview.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            resource = (Model.Resource)e.SelectedItem;
            ID.Text = resource.Id.ToString();
            name.Text = resource.ItemName.ToString();
            inventory.Text = resource.Inventory.ToString();
        }

        private async void update_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbpath);
            Model.Resource resource = new Model.Resource
            {
                Id = Convert.ToInt32(ID.Text),
                ItemName = name.Text,
                Inventory = inventory.Text
            };
            db.Update(resource);
            await DisplayAlert(null, " Your data has been successfully updated", "OK");
            await Navigation.PopAsync();
        }
    }
}