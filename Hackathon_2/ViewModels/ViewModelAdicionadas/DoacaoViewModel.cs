using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Hackathon_2.ViewModels.ViewModelAdicionadas
{
    public class DoacaoViewModel
    {
        private Command _doarCommand;

        public DoacaoViewModel()
        {

        }

        public Command DoarCommand => _doarCommand ?? (_doarCommand = new Command(async () => DoarAnimal()));

        public void DoarAnimal()
        {
             App.Current.MainPage.DisplayAlert("Atenção", "Solicitação de doação enviada! Entraremos em contato.", "OK");
        }
    }
}
