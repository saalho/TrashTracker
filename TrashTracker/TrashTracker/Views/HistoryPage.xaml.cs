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
    public partial class HistoryPage : ContentPage
    {
        HistoryVM historyVM;
        public HistoryPage()
        {
            historyVM = new HistoryVM();
            InitializeComponent();
            BindingContext = historyVM;
        }

        //Navigates to a new page where all logs are displayed
        private void ShowAll(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ShowAllPage));
        }

        //An event that fires when user wants to refresh data.
        //Works by creating a new instance of HistoryViewModel and making that the binding context
        //TODO: Make this not idiotic.
        private void Refresh(object sender, EventArgs e)
        {
            historyVM = new HistoryVM();
            BindingContext = historyVM;
        }
    }
}