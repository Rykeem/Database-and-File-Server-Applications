using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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


        public static void CustomerDatabase(DataGridView datagrid)
        {
            try
            {
                string sql = @"SELECT customerId, customerName, address, phone, city, country
                    FROM address, customer , city, country
                    WHERE  address.addressId = customer.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId ";

               MySqlDataAdapter data = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                datagrid.DataSource = dataTable;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CustomerAdd(string name, string address, string number, string city, string country)
        {
            try
            {
                string sql1 = "INSERT INTO customer(customerName,addressId,active, createDate,createdBy,lastUpdate,lastUpdateBy) VALUES(@name,@addressId,1,NOW(),'test', NOW(),'test')";
                string sql2 = "INSERT INTO address(address,address2,cityId, postalcode, phone, createDate,createdBy,lastUpdate,lastUpdateBy) VALUES(@address,'',@cityId,'11111', @number, NOW(),'test',NOW(),'test')";
                string sql3 = "INSERT INTO city(city,countryId, createDate,createdBy,lastUpdate,lastUpdateBy) VALUES(@city,@countryId, NOW(), 'test', NOW(), 'test')";  
                string sql4 = "INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@country, NOW(), 'test', NOW(), 'test')";
               


                using (MySqlCommand command4 = new MySqlCommand(sql4, conn)) // starting with Country because its independent 
                {
                    command4.Parameters.AddWithValue("@country", country); //4
                    command4.ExecuteNonQuery();
                }



                string CountryId = "SELECT LAST_INSERT_ID()"; //getting country ID to add to city 
                int countryId;

                using (MySqlCommand command4_5 = new MySqlCommand(CountryId, conn)) // starting with Country because its independent 
                {
                    countryId = Convert.ToInt32(command4_5.ExecuteScalar()); // gets country Id into int 
                }




                string CityId = "SELECT LAST_INSERT_ID()"; //getting city ID to add to address 
                int cityId;

                using (MySqlCommand command3 = new MySqlCommand(sql3, conn))
                {
                    command3.Parameters.AddWithValue("@city", city);// 3
                    command3.Parameters.AddWithValue("@countryId", countryId); // adds countryid to city table 
                    command3.ExecuteNonQuery();
                };

                using (MySqlCommand command3_5 = new MySqlCommand(CityId, conn)) 
                {
                    cityId = Convert.ToInt32(command3_5.ExecuteScalar()); // gets city Id
                }





                using (MySqlCommand command2 = new MySqlCommand(sql2, conn))
                {
                    command2.Parameters.AddWithValue("@address", address);
                    command2.Parameters.AddWithValue("@number", number);// adds city id to address table
                    command2.Parameters.AddWithValue("@cityId", cityId);
                    command2.ExecuteNonQuery();
                };


                string AddressId = "SELECT LAST_INSERT_ID()";
                int addressId;

                using (MySqlCommand command2_5 = new MySqlCommand(AddressId, conn))
                {
                    addressId = Convert.ToInt32(command2_5.ExecuteScalar()); // gets address Id
                }








                using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                {
                    command1.Parameters.AddWithValue("@name", name);/// adds address id to customer 
                    command1.Parameters.AddWithValue("@addressId", addressId);
                    command1.ExecuteNonQuery();
                };

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //public static void DatabaseRelationship()
        //{
        //    try
        //    { //Adding ID to required database tables
        //        //string sql1 = "ALTER TABLE customer MODIFY COLUMN customerId INT NOT NULL";
        //        string sql2 = "ALTER TABLE address ADD COLUMN customerId INT";
        //        string sql3 = "ALTER TABLE city ADD COLUMN customerId INT";
        //        string sql4 = "ALTER TABLE country ADD COLUMN customerId INT";



        //        //using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
        //        //{
                   
        //        //    command1.ExecuteNonQuery();
        //        //}
               


        //        using (MySqlCommand command2 = new MySqlCommand(sql2, conn))
        //        {
                    
        //            command2.ExecuteNonQuery();
        //        };



        //        using (MySqlCommand command3 = new MySqlCommand(sql3, conn))
        //        {
        //            command3.ExecuteNonQuery();
        //        };



        //        using (MySqlCommand command4 = new MySqlCommand(sql4, conn))
        //        {
                   
        //            command4.ExecuteNonQuery();
        //        };


        //        //Connecting all IDs or making them the same across all tables for each row 

        //        string sql5 = @"UPDATE address ad
        //                        JOIN customer c ON ad.addressId = c.addressId 
        //                        SET ad.customerId = c.customerId "; // updates addressID is based on customer ID 
        //        string sql6 = @"UPDATE city ct
        //                        JOIN address ad ON ct.cityId = ad.cityId
        //                        SET ct.customerId = ad.customerId "; // cityID based on addressID
        //        string sql7 = @"UPDATE country co
        //                        JOIN city ct ON co.countryId = ct.countryId
        //                        SET co.customerId = ct.customerId "; //countryID based on cityID

        //        using (MySqlCommand command5 = new MySqlCommand(sql5, conn))
        //        {

        //            command5.ExecuteNonQuery();
        //        }



        //        using (MySqlCommand command6 = new MySqlCommand(sql6, conn))
        //        {

        //            command6.ExecuteNonQuery();
        //        };



        //        using (MySqlCommand command7 = new MySqlCommand(sql7, conn))
        //        {
        //            command7.ExecuteNonQuery();
        //        };


        //        //adding foreign keys Makes sure that table wont be filled without the ID 
        //        string sql8 = @"ALTER TABLE address ADD CONSTRAINT address_Id FOREIGN KEY (customerId) REFERENCES customer(customerId)";
        //        string sql9 = @"ALTER TABLE city ADD CONSTRAINT city_Id FOREIGN KEY (customerId) REFERENCES customer(customerId)";
        //        string sql10 = @"ALTER TABLE country ADD CONSTRAINT country_Id FOREIGN KEY (customerId) REFERENCES customer(customerId)";




        //        using (MySqlCommand command8 = new MySqlCommand(sql8, conn))
        //        {

        //            command8.ExecuteNonQuery();
        //        }



        //        using (MySqlCommand command9 = new MySqlCommand(sql9, conn))
        //        {

        //            command9.ExecuteNonQuery();
        //        };



        //        using (MySqlCommand command10 = new MySqlCommand(sql10, conn))
        //        {
        //            command10.ExecuteNonQuery();
        //        };
        //    }


        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

    }
}
