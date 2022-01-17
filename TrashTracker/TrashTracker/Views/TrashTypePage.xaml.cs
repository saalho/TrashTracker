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
    public partial class TrashTypePage : ContentPage
    {
        TrashTypeVM trashTypeVM;
        public TrashTypePage()
        {
            trashTypeVM = new TrashTypeVM();
            InitializeComponent();
            BindingContext = trashTypeVM;
        }
    }
}