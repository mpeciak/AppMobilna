using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMobileZamowieniaFirma.Services
{
    public class TowarDataStore : ItemDataStore<Towar>
    {
        public TowarDataStore()
        {
            items = zamowieniaServices.GetTowary(null).GetTowaryResult.Select(k => new Towar
            {
                IdTowaru = k.IdTowaru,
                NazwaTowaru = k.NazwaTowaru,
                NrKatalogowy= k.NrKatalogowy,
                Ilosc= k.Ilosc,
                Cena=k.Cena,
                Kod=k.Kod,
                Opis=k.Opis

            }).ToList();
        }
        public override Towar Find(Towar item)
        {
            return items.Where((Towar arg) => arg.IdTowaru == item.IdTowaru).FirstOrDefault();
        }
        public override Towar Find(int id)
        {
            return items.Where((Towar arg) => arg.IdTowaru == id).FirstOrDefault();
        }
    }
}