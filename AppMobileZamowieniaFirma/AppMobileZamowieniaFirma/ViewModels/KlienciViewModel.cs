using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using AppMobileZamowieniaFirma.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class KlienciViewModel : ItemsViewModel<Klient>
    {
        public KlienciViewModel()
            :base()
        {
            Title = "Klienci";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NowyKlientPage));
        }
    }
}