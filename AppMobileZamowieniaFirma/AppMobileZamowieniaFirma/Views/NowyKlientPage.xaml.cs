using AppMobileZamowieniaFirma.Models;
using AppMobileZamowieniaFirma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobileZamowieniaFirma.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyKlientPage : ContentPage
    {
        public Klient Item { get; set; }
        public NowyKlientPage()
        {
            InitializeComponent();
            BindingContext = new NowyKlientViewModel();
        }
    }
}