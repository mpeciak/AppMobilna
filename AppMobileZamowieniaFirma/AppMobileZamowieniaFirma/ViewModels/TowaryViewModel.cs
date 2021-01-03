using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using AppMobileZamowieniaFirma.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class TowaryViewModel : ItemsViewModel<Towar>
    {
        public TowaryViewModel()
            : base()
        {
            Title = "Towary";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowyTowarPage));
        }
    }
}