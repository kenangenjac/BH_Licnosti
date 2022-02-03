using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BH_Licnosti.Athletes;

namespace BH_Licnosti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AthletesPage : ContentPage
    {
        public AthletesPage()
        {
            InitializeComponent();
        }

        async void edinPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Athlete3Page());
        }

        async void amelPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Athlete2Page());
        }

        async void mirzaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Athlete1Page());
        }

        async void safetPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Athlete4Page());
        }

        async void athletesBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}