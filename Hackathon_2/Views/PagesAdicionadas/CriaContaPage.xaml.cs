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
    public partial class CriaContaPage : ContentPage
    {
        public CriaContaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new CriaContaPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.UsuarioLogado = true;
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}