using AppMovil2.ViewModels;
using AppMovil2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMovil2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
            Routing.RegisterRoute(nameof(SchoolPage), typeof(SchoolPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
