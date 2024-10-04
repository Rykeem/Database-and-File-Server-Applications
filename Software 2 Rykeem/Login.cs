using MySql.Data.MySqlClient;
using Software_2_Rykeem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_Rykeem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.Local;
            regionTB.Text = timeZone.DisplayName;
                    }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string languageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            langaugeTB.Text = languageCode;
            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            
            //Connection.startConnection();



            if (languageCode == "en")
            {

                if (Connection.Login(userName, password))
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            else if (languageCode == "zh")
            {
                if (Connection.Login(userName, password))
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }

            
            Customer customer = new Customer();
            customer.Show();
            this.Hide();

        }
    }
}
