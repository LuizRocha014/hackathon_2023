using Hackathon_2.ViewModels.ViewModelAdicionadas;
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
    public partial class Login_CriaContaPage : ContentPage
    {
        private NewLoginViewModel _newLoginViewModel;
        public Login_CriaContaPage()
        {
            InitializeComponent();
            _newLoginViewModel= new NewLoginViewModel();
            BindingContext = _newLoginViewModel;
            
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            _newLoginViewModel._login = e.NewTextValue;
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            _newLoginViewModel._senha = e.NewTextValue;
        }
    }
}