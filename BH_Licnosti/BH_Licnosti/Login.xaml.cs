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
    public partial class Login : ContentPage
    {
        List<User> users = new List<User>();
        User user;
        //bool isSingleUser;
        public Login(List<User> u)
        {
            InitializeComponent();
            users = u;
        }

        public Login(User u)
        {
            InitializeComponent();
            user = u;
        }

        public Login()
        {
            InitializeComponent();
        }

        private bool CheckEntry()
        {
            string email = email_Login.Text;
            string password = password_Login.Text;

            if (email == null || password == null)
            {
                return false;
            }

            return true;
        }

        async void loginBtn_Clicked(object sender, EventArgs e)
        {
            if (CheckEntry())
            {
                bool isFound = false;
                int index = 0;
                
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (email_Login.Text == users[i].UserEmail && password_Login.Text == users[i].UserPassword)
                        {
                            isFound = true;
                            index = i;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        await DisplayAlert("Warning", "Netačan email ili password", "OK");
                    }
                    else
                    {
                        await Navigation.PushAsync(new CategoriesPage(users[index]));
                    }
            }
            else
            {
                await DisplayAlert("Warning", "Molimo unesite podatke", "OK");
            }
        }

        async void registerBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}