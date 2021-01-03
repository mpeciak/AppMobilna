using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMobileZamowieniaFirma.Services
{
    public class PracownikDataStore : ItemDataStore<Pracownik>
    {
        public PracownikDataStore()
        {
        }
        public override Pracownik Find(Pracownik item)
        {
            return items.Where((Pracownik arg) => arg.IdPracownika == item.IdPracownika).FirstOrDefault();
        }
        public override Pracownik Find(int id)
        {
            return items.Where((Pracownik arg) => arg.IdPracownika == id).FirstOrDefault();
        }
    }
}

