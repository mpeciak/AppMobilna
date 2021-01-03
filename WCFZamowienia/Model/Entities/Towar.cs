//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFZamowienia.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Towar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Towar()
        {
            this.PozycjaZamowienia = new HashSet<PozycjaZamowienia>();
        }
    
        public int IdTowaru { get; set; }
        public string NazwaTowaru { get; set; }
        public string Opis { get; set; }
        public string NrKatalogowy { get; set; }
        public Nullable<decimal> Cena { get; set; }
        public Nullable<decimal> Ilosc { get; set; }
        public Nullable<int> IdJednostkiMiary { get; set; }
        public string Kod { get; set; }
        public Nullable<bool> CzyAktywny { get; set; }
        public Nullable<int> IdKategori { get; set; }
    
        public virtual JednostkaMiary JednostkaMiary { get; set; }
        public virtual Kategorie Kategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozycjaZamowienia> PozycjaZamowienia { get; set; }
    }
}
