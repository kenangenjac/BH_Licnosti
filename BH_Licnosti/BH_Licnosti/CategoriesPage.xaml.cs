using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BH_Licnosti.Models;

namespace BH_Licnosti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
        }

        bool isLoggedIn = false;
        User user;
        public CategoriesPage(User u)
        {
            InitializeComponent();
            usernameLabel.Text = u.UserFirstName;
            isLoggedIn = true;
            user = u;
        }

        async void ActorsForwardBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActorsPage());
        }

        async void WritersForwardBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WritersPage());
        }

        async void AthletesForwardBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AthletesPage());
        }

        async void loginBtn_Clicked(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                await Navigation.PushAsync(new Profile(user));
            }
            else
            {
                await Navigation.PushAsync(new Login());
            }
        }
    }
}