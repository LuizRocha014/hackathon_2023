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
        public string _login;
        public string _senha;

        public NewLoginViewModel()
        {
        }

        public Command EntrarCommand => _entrarCommand ?? (_entrarCommand = new Command(async () => ExecutaLogin()));
        public Command CriarContaCommand => _loginCommand ?? (_loginCommand = new Command(async () => OnLoginClicked()));

        private async void OnLoginClicked()
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await App.Current.MainPage.Navigation.PushAsync(new CriaContaPage());
        }

        public async void ExecutaLogin()
        {
            try
            {
                if (string.IsNullOrEmpty(_login))
                    throw new Exception("Preencha o usuário");
                if (string.IsNullOrEmpty(_senha))
                    throw new Exception("Preencha a senha");

                if (_login.ToUpper().Trim().Equals(App.Login.ToUpper().Trim()) && _senha.ToUpper().Trim().Equals(App.Senha.ToUpper().Trim()))
                    App.Current.MainPage = new AppShell();
                else
                    throw new Exception("Usuário e/ou senha incorretos");
            }
            catch (Exception e)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", e.Message, "Ok");       
            }
        }
    }
}
