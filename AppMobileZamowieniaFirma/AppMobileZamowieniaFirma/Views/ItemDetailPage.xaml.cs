using AppMobileZamowieniaFirma.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppMobileZamowieniaFirma.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}