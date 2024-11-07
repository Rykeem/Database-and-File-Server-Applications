using MySql.Data.MySqlClient;
using Software_2_Rykeem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            int userId = Connection.GetUserID(userNameTB.Text, passwordTB.Text);

            string currentTime = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd:HH:mm:ss tt");
            string successfulLogin = $"User {userNameTB.Text} has logged in at {currentTime}\n";
            string failedLogin = $"Failed Login Attempt with {userNameTB.Text} at {currentTime}\n";


            string filez = Path.Combine(Environment.CurrentDirectory, "Login_History.txt");


            if (languageCode == "en")
            {

                if (Connection.Login(userName, password))
                {
                    MessageBox.Show("Login Successfull");
                    Customer customer = new Customer(userId);

                    

                    try
                    {
                        using (StreamWriter file = new StreamWriter(filez, true))
                        {
                            file.WriteLine(successfulLogin);
                        }
                        
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message);
                        using (StreamWriter file = new StreamWriter(filez, true))
                        {
                            file.WriteLine(failedLogin);
                        }
                    }

                    customer.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                    using (StreamWriter file = new StreamWriter(filez, true))
                    {
                        file.WriteLine(failedLogin);
                    }
                }
            }
            else if (languageCode == "zh")
            {
                if (Connection.Login(userName, password))
                {
                    MessageBox.Show("登录成功");
                    Customer customer = new Customer(userId);
                    
                    



                    try
                    {
                        using (StreamWriter file = new StreamWriter(filez, true))
                        {
                            file.WriteLine(successfulLogin);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        using (StreamWriter file = new StreamWriter(filez, true))
                        {
                            file.WriteLine(failedLogin);
                        }
                    }



                    customer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                    using (StreamWriter file = new StreamWriter(filez, true))
                    {
                        file.WriteLine(failedLogin);
                    }
                }
            }

            
            

        }
    }
}
