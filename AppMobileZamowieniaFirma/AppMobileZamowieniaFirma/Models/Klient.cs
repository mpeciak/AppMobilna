using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobileZamowieniaFirma.Models
{
    public class Klient
    {
        public int IdKlienta { get; set; }
        public string Nazwa { get; set; }
        public string Nip { get; set; }
        public string Adres { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Telefon { get; set; }

    }
}
