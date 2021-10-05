using System.IO;
using SQLite;
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
   

    public partial class EventClassDetails : ContentPage
    {
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "resourcedb");
        Model.ClassEvent classEvent = new Model.ClassEvent();
        public EventClassDetails()
        {
            InitializeComponent();
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Model.ClassEvent>();
            listview.ItemsSource = db.Table<Model.ClassEvent>().OrderBy(x => x.Title).ToList();
            listview.ItemSelected += listview_ItemSelected;
        }

        private async void updateClassDetails_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbpath);
            Model.ClassEvent classEvent = new Model.ClassEvent
            {
                Id = Convert.ToInt32(ID.Text),
                Title = _titleInput.Text,
                Purpose = _purposeInput.Text,
                Theme = _themeInput.Text,
                MaterialList = _materialInput.Text,
                References = _referencesInput.Text,
                Promotion = _promotionInput.Text
            };
            db.Update(classEvent);
            await DisplayAlert(null, " Your data has been successfully updated", "OK");
            await Navigation.PopAsync();
        }

        private void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            classEvent = (Model.ClassEvent)e.SelectedItem;
            ID.Text = classEvent.Id.ToString();
            _titleInput.Text = classEvent.Title;
            _purposeInput.Text = classEvent.Purpose;
            _themeInput.Text = classEvent.Theme;
            _materialInput.Text = classEvent.MaterialList;
            _referencesInput.Text = classEvent.References;
            _promotionInput.Text = classEvent.Promotion;
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }
    }
}