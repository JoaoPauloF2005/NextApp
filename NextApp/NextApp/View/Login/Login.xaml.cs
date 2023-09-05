using NextApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NextApp.View.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked_Cadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Register_User.Register());
        }

        private async void Button_Clicked_Login(object sender, EventArgs e)
        {
            try
            {
                string[] cpf_pontuado = txt_cpf.Text.Split('.', '-');
                string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];

                Console.WriteLine("================================");
                Console.WriteLine(cpf_digitado);
                Console.WriteLine("================================");

                Models.Correntista c = await DataServiceCorrentista.LoginAsync(new Models.Correntista
                {
                    Cpf = cpf_digitado,
                    Senha = txt_senha.Text,
                });

                if (c != null)
                {
                    App.DadosCorrentista = c;
                    App.Current.MainPage = new NavigationPage(new View.Home.Inicio());
                    //App.Current.MainPage = new View.TelaInicial();
                }
                else
                    throw new Exception("Dados de login inválidos.");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Register_User.Register());

        }
    }


}

