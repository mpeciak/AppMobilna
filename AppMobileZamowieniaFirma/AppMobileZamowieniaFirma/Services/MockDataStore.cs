using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMobileZamowieniaFirma.Services
{
    public class MockDataStore : ItemDataStore<Item>
    {
        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = 1, Text = "First item", Description="This is an item description." },
                new Item { Id = 2, Text = "Second item", Description="This is an item description." },
                new Item { Id = 3, Text = "Third item", Description="This is an item description." },
                new Item { Id = 4, Text = "Fourth item", Description="This is an item description." },
                new Item { Id = 5, Text = "Fifth item", Description="This is an item description." },
                new Item { Id = 6, Text = "Sixth item", Description="This is an item description." }
            };
        }
        public override Item Find(Item item)
        {
            return items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
        }
        public override Item Find(int id)
        {
            return items.Where((Item arg) => arg.Id == id).FirstOrDefault();
        }
    }
}