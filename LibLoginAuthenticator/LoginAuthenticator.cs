using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibLoginAuthenticator
{
    public class LoginAuthenticator
    {
        private string username;
        private string password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            private get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public LoginAuthenticator()
            {
                Username = null;
                Password = null;
            }

        public bool? Authenticate()
        {
            if (username == null || password == null)
            {
                return null;
            }

            else if(username == "john" && password == "doe")
            {
                return true;
            }

            else if(username == "lavish" && password == "mehta")
            {
                return true;
            }

            else if(username == "captain" && password == "jack")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
