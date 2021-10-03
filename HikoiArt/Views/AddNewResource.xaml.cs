using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HikoiArt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewResource : ContentPage
    {
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "resourcedb");
        public AddNewResource()
        {
            InitializeComponent();
        }

        private async void addBtn_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Model.Resource>();

            var maxpk = db.Table<Model.Resource>().OrderByDescending(c => c.Id).FirstOrDefault();

            Model.Resource resource =new Model.Resource{
                Id = maxpk == null?1:maxpk.Id + 1,
                ItemName = _nameEntry.Text,
                Inventory = _numberEntry.Text
            };

            db.Insert(resource);
            await DisplayAlert(null, resource.ItemName + " " +"saved successfully","ok");
            await Navigation.PopAsync();
        }
    }
}