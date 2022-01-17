using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashTracker.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrashTracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogPage : ContentPage
    {
        LogVM logVM;
        private int trashIndex = -1;
        private float weight = 0;

        public LogPage()
        {
            logVM = new LogVM();
            InitializeComponent();
            BindingContext = logVM;
        }

        // An event that fires whenever the chosen trash type changes
        private void TypePickChanged(object sender, EventArgs e)
        {
            var _picker = sender as Picker;
            trashIndex = _picker.SelectedIndex;
        }

        // An event that fires whenever a new weight value is typed
        private void WeightChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                weight = float.Parse(e.NewTextValue);
            }
            catch{}
            
        }

        // An event that fires when the add button is clicked. Saves the values to a local database.
        //TODO: Reload HistoryPage data after click
        async void AddClick(object sender, EventArgs e)
        {
            if (trashIndex == -1 || weight == 0)
            {
                await DisplayAlert("Virhe", "Annetut arvot eivät kelpaa", "OK");
            }
            else if (await DisplayAlert("Lisätäänkö kirjaus?", "Jätetyyppi: " + logVM.TrashTypes[trashIndex].Name + " | Paino: " + weight, "OK", "Peruuta"))
            {
                var response = logVM.InsertTrash(weight * int.Parse(logVM.UnitValue), logVM.TrashTypes[trashIndex].Name);
                await DisplayAlert("Jätteen kirjaus", response, "OK");
            }
        }
    }
}