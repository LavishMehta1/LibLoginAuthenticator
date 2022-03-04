using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLoginAuthenticator;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginAuthenticator str = new LoginAuthenticator();
            string userName;
            string password;
            bool? val;

                userName = textUser.Text;
                if (userName == "")
                {
                    str.Username = null;
                }
                //  str.Username = Console.ReadLine();

                password = textPass.Text;
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
                    MessageBox.Show("Username and password must be provided.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (str.Authenticate() == false)
                {
                MessageBox.Show("Authentication was not successful.", "WARNING ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                if (str.Authenticate() == true)
                {
                MessageBox.Show("Authentication was successful.", "INFORMATION ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }
    }
}
