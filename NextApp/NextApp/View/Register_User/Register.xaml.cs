using NextApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NextApp.View.Register_User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked_Cadastrar(object sender, EventArgs e)
        {
            string[] cpf_pontuado = txt_cpf.Text.Split('.', '-');
            string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];
            try
            {
                Models.Correntista c = await DataServiceCorrentista.SaveAsync(new Models.Correntista
                {
                    Nome = txt_nome.Text,
                    Email = txt_email.Text,
                    Cpf = cpf_digitado,
                    Data_Nascimento = data_nasc.Date,
                    Senha = txt_senha.Text,
                });

                if (c.Id != null)
                {
                    /**
                     * Vá no arquivo App.xaml.cs e veja que declarei uma propriedade chamada
                     * DadosCorrentista, que irá armazenar os dados do correntista após o cadastro ou
                     * login, enquanto ele estiver usando o App.
                     */
                    App.DadosCorrentista = c;

                    /**
                     * Navegando para a Tela Inicial após cadastrar e definir os dados do Correntista.
                     */
                    await Navigation.PushAsync(new View.Login.Login());
                }
                else
                    throw new Exception("Ocorreu um erro ao salvar seu cadastro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}