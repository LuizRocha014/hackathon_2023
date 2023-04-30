using Hackathon_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hackathon_2.Views.PagesAdicionadas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetalhePage : ContentPage
    {
        private Animal Animal;
        private List<string> Fotos;
        public AnimalDetalhePage(Animal animal)
        {
            InitializeComponent();
            Animal = animal;
            NomeAnimal.Text = Animal.Nome;
            ImagenAnimal.Source = Animal.Foto;
            Fotos = new List<string> { Animal.Foto, Animal.Foto, Animal.Foto, Animal.Foto, Animal.Foto, Animal.Foto, Animal.Foto };
            countFoto.Text = "<1/" + Fotos.Count + ">";
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new ListaDeFotos(Fotos));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (App.UsuarioLogado)
                await App.Current.MainPage.Navigation.PushAsync(new InicioAdocao(Animal));
            else
            {
                var result = await App.Current.MainPage.DisplayAlert("Atenção", "Para continuar é necessário estar logado! \n Já possui é cadastrado?", "SIM", "NAO");
                if (result)
                    await App.Current.MainPage.Navigation.PushAsync(new Login_CriaContaPage());
                else
                    await App.Current.MainPage.Navigation.PushAsync(new CriaContaPage());
            }
        }
    }
}