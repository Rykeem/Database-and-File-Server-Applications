using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_Rykeem.Database
{
    public class Connection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {

            try
            {
                string connect = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(connect);

                //opens the connection
                conn.Open();
                MessageBox.Show("Connection Successfull");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void stopConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static bool Login(string username, string password)
        {
            try
            {
                string sql = "SELECT * FROM user WHERE userName = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        return true;
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
