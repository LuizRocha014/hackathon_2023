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
    public partial class GatoPage : ContentPage
    {
        private List<Animal> Lista;
        private List<string> Nomes;
        public GatoPage()
        {
            InitializeComponent();
            try
            {
                Lista = new List<Animal>();
                Nomes = new List<string>() { "", "Amy", "Jagger", "Lennon", "Ringo", "Bichento", "Hermione", "Cookie", "Fubá", "Torrada", "Café" };
                for (int i = 1; i < 11; i++)
                {
                    var item = new Animal
                    {
                        Nome = Nomes[i],
                        Foto = "cat" + i,
                    };
                    Lista.Add(item);
                }
                ListaGatos.ItemsSource = Lista;
            }
            catch (Exception e)
            {

            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var pesquisa = e.NewTextValue;
            ListaGatos.ItemsSource = Lista.Where(i => i.Nome.ToUpper().Contains(pesquisa.ToUpper()));
        }

        private void ListaCachorros_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new AnimalDetalhePage((Animal)e.ItemData));
        }
    }
}