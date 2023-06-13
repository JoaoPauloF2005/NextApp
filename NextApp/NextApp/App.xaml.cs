using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NextApp
{
    public partial class App : Application
    {
        public static Models.Correntista DadosCorrentista { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Login.Login());
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
