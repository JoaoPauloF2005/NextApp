using NextApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace NextApp.View.Area_Pix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pix : ContentPage
	{
		public Pix ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void LerQRCode_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new PixLerQrCode());

        }

        private void ReceberViaQRCode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReceberViaQRCode());

        }

        private void TransferirPix_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ReceberViaQRCode());
        }
    }

    
}