using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.Services
{
    public class KlientDataStore : ItemDataStore<Klient>
    {
        public KlientDataStore()
        {
            items = zamowieniaServices.GetKlienci(null).GetKlienciResult.Select(k => new Klient
            {
                IdKlienta = k.IdKlienta,
                Nazwa = k.Nazwa,
                Nip=k.Nip,
                Adres = k.Adres,
                Telefon = k.Telefon,
                Miejscowosc=k.Miejscowosc,
                KodPocztowy=k.KodPocztowy
            }).ToList();
        }
        public override Klient Find(Klient item)
        {
            return items.Where((Klient arg) => arg.IdKlienta == item.IdKlienta).FirstOrDefault();
        }
        public override Klient Find(int id)
        {
            return items.Where((Klient arg) => arg.IdKlienta == id).FirstOrDefault();
        }
    }
}