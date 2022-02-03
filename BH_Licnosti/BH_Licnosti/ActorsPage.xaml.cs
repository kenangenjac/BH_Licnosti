using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BH_Licnosti.Actors;

namespace BH_Licnosti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActorsPage : ContentPage
    {
        public ActorsPage()
        {
            InitializeComponent();
        }

        async void actorsBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void mustafaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actor1Page());
        }

        async void mirvadPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actor2Page());
        }

        async void admirPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actor3Page());
        }

        async void emirPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actor4Page());
        }
    }
}