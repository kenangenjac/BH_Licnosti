﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BH_Licnosti.Athletes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Athlete4Page : ContentPage
    {
        public Athlete4Page()
        {
            InitializeComponent();
        }

        async void Nazad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}