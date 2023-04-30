using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hackathon_2.Views.PagesAdicionadas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InicioAdocao : ContentPage
	{
		public InicioAdocao (Animal animal)
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			App.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}