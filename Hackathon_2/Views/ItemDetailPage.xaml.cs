using Hackathon_2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Hackathon_2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}