using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BH_Licnosti
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void toCategories_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoriesPage());
        }
    }
}
