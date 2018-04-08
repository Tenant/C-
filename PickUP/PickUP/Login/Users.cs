using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickUP.Login
{
    public class Users
    {
        private string userName, password;

        public Users(string userName, string password)
        {
            this.userName=userName;
            this.password=password;
        }

        public string getUserName()
        {
            return userName;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
