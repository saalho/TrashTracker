using System;
using System.Collections.Generic;
using TrashTracker.Views;
using Xamarin.Forms;

namespace TrashTracker
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
            Routing.RegisterRoute(nameof(LogPage), typeof(LogPage));
            Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
            Routing.RegisterRoute(nameof(ShowAllPage), typeof(ShowAllPage));
            Routing.RegisterRoute(nameof(TrashTypePage), typeof(TrashTypePage));
        }
    }
}
