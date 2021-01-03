using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using AppMobileZamowieniaFirma.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class ItemsViewModel : ItemsViewModel<Item>
    {
        public ItemsViewModel()
            :base()
        {
            Title = "Items";
        }
        public override void GoToPage()
        {
            Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }
}