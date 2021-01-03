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
    public partial class NowyTowarPage : ContentPage
    {
        public Towar Item { get; set; }
        public NowyTowarPage()
        {
            InitializeComponent();
            BindingContext = new NowyTowarViewModel();
        }
    }
}