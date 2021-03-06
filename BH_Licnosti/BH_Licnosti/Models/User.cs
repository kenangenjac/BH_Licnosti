using System;
using System.Collections.Generic;
using System.Text;

namespace BH_Licnosti.Models
{
    public class User
    {
        private string userFirstName { get; set; }
        public string UserFirstName { get => userFirstName; set { } }
        private string userLastName { get; set; }
        public string UserLastName { get => userLastName; set { } }
        private string userEmail { get; set; }
        public string UserEmail { get => userEmail; set { } }
        private DateTime userBirthDate { get; set; }
        public DateTime UserBirthDAte { get => userBirthDate; set { } }
        private string userPassword { get; set; }
        public string UserPassword { get => userPassword; set { } }

        public User(string userFirstName, string userLastName, string userEmail, DateTime userBirthDate, string userPassword)
        {
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
            this.userEmail = userEmail;
            this.userBirthDate = userBirthDate;
            this.userPassword = userPassword;
        }

        public User()
        {
        }
    }
}
