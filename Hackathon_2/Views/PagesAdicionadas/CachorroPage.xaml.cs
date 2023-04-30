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
    public partial class CachorroPage : ContentPage
    {
        public CachorroPage()
        {
            InitializeComponent();
            var list = new List<Animal>();
            for (int i = 0; i < 10; i++)
            {
                var item = new Animal {
                Nome = "teste"};
                list.Add(item);
            }
            ListaCachorros.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new AnimalDetalhePage()) ;
        }
    }
}