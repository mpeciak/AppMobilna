using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobileZamowieniaFirma.Models
{
    public class Towar
    {
        public int IdTowaru { get; set; }
        public string NazwaTowaru { get; set; }
        public string Opis { get; set; }
        public decimal? Cena { get; set; }

        public string NrKatalogowy{ get; set; }
        public decimal? Ilosc { get; set; }
        public string Kod { get; set; }

    }
}
