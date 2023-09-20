using NextApp.Models;
using NextApp.Services;
using System;

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NextApp.View.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Pix(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.Area_Pix.Pix());

        }

        /*protected async override void OnAppearing()
        {
            Conta c = await DataServiceConta.GetDataOfConta(new Conta()
            {
                id_correntista = idCorrentista,
            }, "/conta/dados");

            if (c != null)
            {
                lbl_saldo.Text = c.saldo.ToString("C", new CultureInfo("pt-BR"));
            }
            else
            {
                await DisplayAlert("Erro", "Houve um problema ao ler os dados de sua conta!", "OK");
            }
        }*/

    }


}
