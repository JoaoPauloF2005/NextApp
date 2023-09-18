using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NextApp.View.Area_Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceberViaQRCode : ContentPage
    {
        public ReceberViaQRCode()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Area_Pix.PixLerQrCode());
        }
    }
}