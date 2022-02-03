using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BH_Licnosti.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Writer4Page : ContentPage
    {
        public Writer4Page()
        {
            InitializeComponent();
        }

        async void Nazad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}