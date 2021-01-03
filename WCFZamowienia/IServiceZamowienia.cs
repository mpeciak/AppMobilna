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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceZamowienia
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        List<TowarForView> GetTowary();
        [OperationContract]
        List<KlientForView> GetKlienci();
        [OperationContract]
        List<KategorieForView> GetKategorie();
        [OperationContract]
        List<ZamowieniaForView> GetZamowienia();
        [OperationContract]
        List<PracownikForView> GetPracownicy();
        [OperationContract]
        List<PozycjaZamowieniaForView> GetPozycjeZamowienia(int idZamowienia);//pobiera wszystkie pozycje danego zamowienia
        [OperationContract]
        void AddKlient(Klient klient);
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class TowarForView
    {
        [DataMember]
        public int IdTowaru { get; set; }
        [DataMember]
        public string NazwaTowaru { get; set; }
        [DataMember]
        public string Opis { get; set; }
        [DataMember]
        public string NrKatalogowy { get; set; }
        [DataMember]
        public int? IdKategorii { get; set; }
        [DataMember]
        public string KategoriaNazwa { get; set; } //to jest pole zamiast klucza obcego IdKaegorii
        [DataMember]
        public decimal? Cena { get; set; }
        [DataMember]
        public decimal? Ilosc { get; set; }
        [DataMember]
        public int? IdJednostkiMiary { get; set; }
        [DataMember]
        public string JednostkaMiaryNazwa { get; set; }
        [DataMember]
        public string Kod { get; set; }
    }
    [DataContract]
    public class KlientForView
    {
        [DataMember]
        public int IdKlienta { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public string Nip { get; set; }
        [DataMember]
        public string Adres { get; set; }
        [DataMember]
        public string Miejscowosc { get; set; }
        [DataMember]
        public string KodPocztowy { get; set; }
        [DataMember]
        public string Telefon { get; set; }
    }
    [DataContract]
    public class PracownikForView
    {
        [DataMember]
        public int IdPracownika { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Imie { get; set; }
        [DataMember]
        public string Nazwisko { get; set; }
     }

    [DataContract]
    public class KategorieForView
    {
        [DataMember]
        public int IdKategorii { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public string Opis { get; set; }
    }
    [DataContract]
    public class ZamowieniaForView
    {
        [DataMember]
        public int IdZamowienia { get; set; }
        [DataMember]
        public string NrZamowienia { get; set; }
        [DataMember]
        public DateTime? DataZamowienia { get; set; }
        [DataMember]
        public DateTime? DataRealizacji { get; set; }
        [DataMember]
        public string Opis { get; set; }
        [DataMember]
        public string Nazwa { get; set; }
        [DataMember]
        public string Cena { get; set; }
        [DataMember]
        public int? IdPracownika { get; set; }
        [DataMember]
        public string PracownikDane { get; set; }
        [DataMember]
        public int? IdPozycjiZamowienia { get; set; }
        [DataMember]
        public string PozycjaZamowienia { get; set; }
        [DataMember]
        public int? IdKlienta { get; set; }
        [DataMember]
        public string KlientDane { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
    [DataContract]
    public class PozycjaZamowieniaForView
    {
        [DataMember]
        public int IdPozycjiZamowienia { get; set; }
        [DataMember]
        public int? IdZamowienia { get; set; }
        [DataMember]
        public decimal? Ilosc { get; set; }
        [DataMember]
        public int? IdTowaru { get; set; }
        [DataMember]
        public string TowarNazwa { get; set; }
        [DataMember]
        public int? IdKategorii { get; set; }
        [DataMember]
        public string KategoriaNazwa { get; set; }
        [DataMember]
        public decimal? Cena { get; set; }
        [DataMember]
        public decimal? Wartosc { get; set; }
    }
}
