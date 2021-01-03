using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class NowyTowarViewModel : NewItemViewModel<Towar>
    {
        private string nazwaTowaru;
        private string opis;
        private decimal? cena;
        private string nrKatalogowy;
        private decimal? ilosc;
        private string kod; 
        public NowyTowarViewModel()
            : base()
        {
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwaTowaru);
        }
        public string NazwaTowaru
        {
            get => nazwaTowaru;
            set => SetProperty(ref nazwaTowaru, value);
        }
        public string Opis
        {
            get => opis;
            set => SetProperty(ref opis, value);
        }
        public decimal? Cena 
        {
            get => cena;
            set => SetProperty(ref cena, value);
        }
        public string NrKatalogowy
        {
            get => nrKatalogowy;
            set => SetProperty(ref nrKatalogowy, value);
        }
        public string Kod
        {
            get => kod;
            set => SetProperty(ref kod, value);
        }
        public decimal? Ilosc
        {
            get => ilosc;
            set => SetProperty(ref ilosc, value);
        }
        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        public override Towar SetItem()
        {
            Towar newItem = new Towar()
            {
                IdTowaru = 1,
                NazwaTowaru = NazwaTowaru,
                NrKatalogowy = NrKatalogowy,
                Cena =Cena,
                Ilosc = Ilosc,
                Opis = Opis,
                Kod = Kod               
            };
            return newItem;
        }
    }
}
