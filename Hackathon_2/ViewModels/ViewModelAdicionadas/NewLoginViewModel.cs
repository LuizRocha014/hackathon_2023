using Hackathon_2.Views.PagesAdicionadas;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Hackathon_2.ViewModels.ViewModelAdicionadas
{
    public class NewLoginViewModel
    {
        private Command _loginCommand;
        private Command _entrarCommand;

        public NewLoginViewModel()
        {
        }

        public  Command EntrarCommand => _entrarCommand ?? (_entrarCommand = new Command(async () =>  ExecutaLogin()));
        public  Command CriarContaCommand => _loginCommand ?? (_loginCommand = new Command(async () => OnLoginClicked()));

        private async void OnLoginClicked()
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            App.Current.MainPage.Navigation.PushAsync(new CriaContaPage());
        }

        public async void ExecutaLogin()
        {
         await App.Current.MainPage.DisplayAlert("Sucesso","Logado com sucesso!","ok");
        } 
    }
}
