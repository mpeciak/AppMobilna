using ServiceReferenceZamowienia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.Services.Abstract
{
    public abstract class ItemDataStore<T> : IDataStore<T>
    {
        public IServiceZamowienia zamowieniaServices { get; set; }
        public List<T> items;
        public ItemDataStore()
        {
           zamowieniaServices = DependencyService.Get<ServiceReferenceZamowienia.IServiceZamowienia>();
        }
        public async Task<bool> AddItemAsync(T item)
        {
            zamowieniaServices.AddKlient(new AddKlientRequest(new Klient { Nazwa = "11",  Nip="2215155", Adres = "22", Miejscowosc="Przydonica",KodPocztowy="33-318", Telefon = "55", CzyAktywny = true }));
            items.Add(item);
            return await Task.FromResult(true);
        }
        public abstract T Find(T item);
        public abstract T Find(int id);
        public async Task<bool> UpdateItemAsync(T item)
        {
            var oldItem = Find(item);
            //var oldItem = items.Where((T arg) => arg.IdKlienta == item.IdKlienta).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = Find(id); 
                //items.Where((Klient arg) => arg.IdKlienta == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }
        public async Task<T> GetItemAsync(int id)
        {
            return await Task.FromResult(Find(id));
        }
        public async Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}