using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFZamowienia.Model.Entities;

namespace WCFZamowienia
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceZamowienia : IServiceZamowienia
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public List<TowarForView> GetTowary()
        {
            //two
            //
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
            (
                from towar in db.Towar
                where towar.CzyAktywny == true
                select new TowarForView
                {
                    IdTowaru = towar.IdTowaru,
                    NazwaTowaru = towar.NazwaTowaru,
                    NrKatalogowy = towar.NrKatalogowy,
                    Opis = towar.Opis,
                    IdKategorii = towar.IdKategori,
                    KategoriaNazwa = towar.Kategorie.Nazwa,
                    Cena = towar.Cena,
                    Ilosc = towar.Ilosc,
                    IdJednostkiMiary = towar.IdJednostkiMiary,
                    JednostkaMiaryNazwa = towar.JednostkaMiary.Nazwa,
                    Kod = towar.Kod
                }
            ).ToList();
        }
        public List<KlientForView> GetKlienci()
        {
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
                (
                    from klient in db.Klient
                    where klient.CzyAktywny == true
                    select new KlientForView
                    {
                        IdKlienta = klient.IdKlienta,
                        Nazwa = klient.Nazwa,
                        Nip = klient.Nip,
                        KodPocztowy = klient.KodPocztowy,
                        Miejscowosc = klient.Miejscowosc,
                        Adres = klient.Adres,
                        Telefon = klient.Telefon
                    }
                ).ToList();
        }
        public void AddKlient(Klient klient)
        {
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            db.Klient.Add(klient);
            db.SaveChanges();
        }
        public List<PracownikForView> GetPracownicy()
        { 
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
                (
                    from pracownik in db.Pracownicy
                    where pracownik.CzyAktywny == true
                    select new PracownikForView
                    {
                        IdPracownika = pracownik.IdPracownika,
                        Nazwa = pracownik.Nazwa,
                        Login = pracownik.Login,
                        Imie = pracownik.Imie,
                        Nazwisko = pracownik.Nazwisko
                    }
                ).ToList();
        }
        public List<KategorieForView> GetKategorie()
        {
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
            (
                from kategorie in db.Kategorie
                where kategorie.CzyAktywny == true
                select new KategorieForView
                {
                    IdKategorii = kategorie.IdKategorii,
                    Nazwa = kategorie.Nazwa,
                    Opis = kategorie.Opis,
                }
            ).ToList();
        }
        public List<ZamowieniaForView> GetZamowienia()
        {
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
            (
                from zamowienie in db.Zamowienia
                select new ZamowieniaForView
                {
                    IdZamowienia = zamowienie.IdZamowienia,
                    NrZamowienia = zamowienie.NrZamowienia,
                    IdKlienta = zamowienie.IdKlienta,
                    KlientDane = zamowienie.Klient.Nazwa,
                    IdPracownika = zamowienie.IdPracownika,
                    PracownikDane = zamowienie.Pracownicy.Imie + " " + zamowienie.Pracownicy.Nazwisko,
                    DataZamowienia = zamowienie.DataZamowienia,
                    DataRealizacji = zamowienie.DataRealizacji,
                    Opis = zamowienie.Opis,
                    Status = zamowienie.Status,
                }
            ).ToList();
        }
        public List<PozycjaZamowieniaForView> GetPozycjeZamowienia(int idZamowienia)
        {
            ZamowieniaFirmaEntities db = new ZamowieniaFirmaEntities();
            return
                (
                    from pozycja in db.PozycjaZamowienia
                    where pozycja.IdZamowienia == idZamowienia
                    select new PozycjaZamowieniaForView()
                    {
                        IdPozycjiZamowienia = pozycja.IdPozycjiZamowienia,
                        IdZamowienia = pozycja.IdZamowienia,
                        Ilosc = pozycja.Ilosc,
                        IdTowaru = pozycja.IdTowaru,
                        TowarNazwa = pozycja.Towar.NazwaTowaru,
                        IdKategorii = pozycja.Towar.IdKategori,
                        KategoriaNazwa = pozycja.Towar.Kategorie.Nazwa,
                        Cena = pozycja.Cena,
                    }
                  ).ToList();
        }
    }
}