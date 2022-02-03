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
    public partial class Writer2Page : ContentPage
    {
        public Writer2Page()
        {
            InitializeComponent();
        }

        async void Nazad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}