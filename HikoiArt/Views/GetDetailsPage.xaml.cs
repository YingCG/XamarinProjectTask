using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HikoiArt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetDetailsPage : ContentPage
    {
        public GetDetailsPage()
        {
            InitializeComponent();
            try
            {
                string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "resourcedb");

                var db = new SQLiteConnection(_dbpath);
                db.CreateTable<Model.Resource>();

                listview.ItemsSource = db.Table<Model.Resource>().OrderBy(x => x.ItemName).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}