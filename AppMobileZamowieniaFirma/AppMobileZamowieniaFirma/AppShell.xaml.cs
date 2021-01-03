using AppMobileZamowieniaFirma.ViewModels;
using AppMobileZamowieniaFirma.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(NowyKlientPage), typeof(NowyKlientPage));
            Routing.RegisterRoute(nameof(NowyTowarPage), typeof(NowyTowarPage));
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
