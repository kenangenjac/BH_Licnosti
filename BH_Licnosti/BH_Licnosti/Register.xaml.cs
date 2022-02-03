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
    public partial class Register : ContentPage
    {
        List<User> users = new List<User>();
        public Register()
        {
            InitializeComponent();
            dateOfBirth.MaximumDate = DateTime.Today;
        }

        private bool CheckEntry()
        {
            string firstName = firstName_Register.Text;
            string lastName = lastName_Register.Text;
            string email = email_Register.Text;
            DateTime birthDate = dateOfBirth.Date;
            string password = password_Register.Text;

            if(firstName == null || lastName == null || email == null || dateOfBirth == null || password == null)
            {
                return false;
            }

            return true;
        }

        private User createUser(){
            string firstName = firstName_Register.Text;
            string lastName = lastName_Register.Text;
            string email = email_Register.Text;
            DateTime birthDate = dateOfBirth.Date;
            string password = password_Register.Text;

            return new User(firstName, lastName, email, birthDate, password);
        }

        async void register_Btn_Clicked(object sender, EventArgs e)
        {
            if (CheckEntry())
            {
                users.Add(createUser());
                await Navigation.PushAsync(new Login(users));
            }
            else
            {
                await DisplayAlert("Warning", "Molimo unesite podatke", "OK");
            }
            
        }
    }
}