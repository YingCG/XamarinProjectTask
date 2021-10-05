using System.IO;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;

namespace HikoiArt.Views
{
    public partial class PlannerPage : ContentPage
    {
        string _dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "resourcedb");
        Model.ClassEvent classEvent = new Model.ClassEvent();
        
        public PlannerPage()
        {
            InitializeComponent();
            
        }

        
        private async void AddEvent_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbpath);
            db.CreateTable<Model.ClassEvent>();

            var maxpk = db.Table<Model.ClassEvent>().OrderByDescending(c => c.Id).FirstOrDefault();

            Model.ClassEvent classEvent = new Model.ClassEvent
            {
                Id = maxpk == null ? 1 : maxpk.Id + 1,
                Title = _titleInput.Text,
                Purpose = _purposeInput.Text,
                Theme = _themeInput.Text,
                MaterialList = _materialInput.Text,
                References = _referencesInput.Text,
                Promotion = _promotionInput.Text
            };

            db.Insert(classEvent);
            await DisplayAlert(null, classEvent.Title + " " + "saved successfully", "ok");
            await Navigation.PopAsync();
        }

        private async void getClassDetails_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.EventClassDetails());
        }

        public async void homeBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HomePage());
        }

    }
}
