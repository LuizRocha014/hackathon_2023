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
    public partial class AnimalDetalhePage : ContentPage
    {
        private Animal Animal;
        public AnimalDetalhePage(Animal animal)
        {
            InitializeComponent();
            Animal = animal;
        }
    }
}