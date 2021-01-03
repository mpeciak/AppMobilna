using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.Services;
using AppMobileZamowieniaFirma.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.ViewModels
{
    public class NewItemViewModel : NewItemViewModel<Item>
    {
        private string text;
        private string description;

        public NewItemViewModel()
            :base()
        {
        }

        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description);
        }
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public override Item SetItem()
        {
            Item newItem = new Item()
            {
                Id = 1,
                Text = Text,
                Description = Description
            };
            return newItem;
        }
    }
}
