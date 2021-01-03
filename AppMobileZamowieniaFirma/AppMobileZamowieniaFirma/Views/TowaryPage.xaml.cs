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
    public partial class TowaryPage : ContentPage
    {
        TowaryViewModel _viewModel;
        public TowaryPage()
        {
            InitializeComponent(); BindingContext = _viewModel = new TowaryViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}