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
    public partial class KlienciPage : ContentPage
    {
        KlienciViewModel _viewModel;
        public KlienciPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new KlienciViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}