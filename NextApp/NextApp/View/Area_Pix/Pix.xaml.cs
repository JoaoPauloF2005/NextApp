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

        private void Button_Clicked(object sender, EventArgs e)
        {
        }

        private void OnLabelTapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.Area_Pix.Pix());
        }

    }
}