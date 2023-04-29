using Hackathon_2.ViewModels;
using Hackathon_2.Views;
using Hackathon_2.Views.PagesAdicionadas;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Hackathon_2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
