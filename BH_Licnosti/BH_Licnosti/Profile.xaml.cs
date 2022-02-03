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
    public partial class Profile : ContentPage
    {
        User user;
        public Profile(User u)
        {
            InitializeComponent();
            user = u;
            firstNameLabel.Text = user.UserFirstName;
            lastNameLabel.Text = user.UserLastName;
            dateLabel.Text = user.UserBirthDAte.ToString().Substring(0, 9);
            mailLabel.Text = user.UserEmail;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Clicked_Logout(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Logout", "Are You sure You want to Log Out?", "Yes", "No");

            if (answer)
            {
                //await Navigation.PopToRootAsync();
                await Navigation.PushAsync(new CategoriesPage());
            }
        }
    }
}