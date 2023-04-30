﻿using Hackathon_2.ViewModels.ViewModelAdicionadas;
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
    public partial class DoacaoAnimaisPage : ContentPage
    {
        private DoacaoViewModel _DoacaoViewModel;
        public DoacaoAnimaisPage()
        {
            InitializeComponent();
            _DoacaoViewModel= new DoacaoViewModel();
            BindingContext = _DoacaoViewModel;
        }
    }
}