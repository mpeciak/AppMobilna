using AppMobileZamowieniaFirma.Services;
using AppMobileZamowieniaFirma.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobileZamowieniaFirma
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<KlientDataStore>();
            DependencyService.Register<TowarDataStore>();
            DependencyService.Register<ServiceReferenceZamowienia.ServiceZamowieniaClient>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
