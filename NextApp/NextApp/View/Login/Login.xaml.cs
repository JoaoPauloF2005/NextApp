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

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pagina_Inicial.Inicio());

        }
    }
}