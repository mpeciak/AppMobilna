using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class NowyKlientViewModel : NewItemViewModel<Klient>
    {
        private string nazwa;
        private string nip;
        private string miejscowosc;
        private string adres;
        private string kodpocztowy;
        private string telefon;
        public NowyKlientViewModel()
            :base()
        {
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwa);
        }

        public string Nazwa
        {
            get => nazwa;
            set => SetProperty(ref nazwa, value);
        }
        public string Nip
        {
            get => nip;
            set => SetProperty(ref nip, value);
        }
        public string Adres
        {
            get => adres;
            set => SetProperty(ref adres, value);
        }
        public string Miejscowosc
        {
            get => miejscowosc;
            set => SetProperty(ref miejscowosc, value);
        }

        public string KodPocztowy
        {
            get => kodpocztowy;
            set => SetProperty(ref kodpocztowy, value);
        }

        public string Telefon
        {
            get => telefon;
            set => SetProperty(ref telefon, value);
        }
        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        public override Klient SetItem()
        {
            Klient newItem = new Klient()
            {
                IdKlienta = 1,
                Nazwa = Nazwa,
                Nip = Nip,
                Adres = Adres, 
                Miejscowosc = Miejscowosc,
                KodPocztowy = KodPocztowy,
                Telefon = Telefon
            };
            return newItem;
        }
    }
}
