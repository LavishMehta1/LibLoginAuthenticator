using LibLoginAuthenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginAuthenticator str = new LoginAuthenticator();
            string userName;
            string password;
            bool? val;

            while (true)
            {
                Console.Write("Username: ");
                userName = Console.ReadLine();
                if (userName == "")
                {
                    str.Username = null;
                }
                //  str.Username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();
                if (password == "")
                {
                    str.Password = null;
                }
                //  str.Password = Console.ReadLine();
                if (userName != "" && password != "")
                {
                    str.Username = userName;
                    str.Password = password;

                }

                if (str.Authenticate() == null)
                {
                    Console.WriteLine("Both username and password are required.\n");
                }

                if (str.Authenticate() == false)
                {
                    Console.WriteLine("Authentication has failed.\n");
                }

                if (str.Authenticate() == true)
                {
                    Console.WriteLine("Authentication was successful.\nPress any key to exit\n");
                    break;
                }
                
            }
            Console.ReadKey();
        }



        
    }
}
