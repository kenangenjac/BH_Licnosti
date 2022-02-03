using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BH_Licnosti.NewFolder;

namespace BH_Licnosti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WritersPage : ContentPage
    {
        public WritersPage()
        {
            InitializeComponent();
        }

        
        async void writersBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void mehmedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Writer1Page());
        }

        async void aleksaPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Writer2Page());
        }

        async void isakPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Writer3Page());
        }

        async void brankoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Writer4Page());
        }
    }
}