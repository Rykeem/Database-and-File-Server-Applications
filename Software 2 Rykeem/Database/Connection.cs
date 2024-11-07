using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
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
                //MessageBox.Show("Connection Successfull");
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
        public static int GetUserID(string username,string password)
        {
            int userId = 0;
            try
            {
                string sql = "SELECT userId FROM user WHERE userName = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return userId;


        }
        public static void Report1(DataGridView dataGrid)
        {
            string sql = @"SELECT type AS `Type`, DATE_FORMAT(start, '%M') AS `Month`, COUNT(*) AS `Appointment Count`
                           FROM appointment
                           GROUP BY DATE_FORMAT(start, '%M'), type";



            using (MySqlCommand command = new MySqlCommand(sql, conn)) 
            {
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    dataGrid.DataSource = dataTable;
                    dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                
            }

        }

        public static void Report2(DataGridView dataGrid, string userId)
        {

            string sql = @"SELECT appointmentId, appointment.customerId, userId, appointment.type, appointment.start, appointment.end 
                              FROM appointment, customer 
                              WHERE customer.customerId = appointment.customerId AND userId = @userId";

            using (MySqlCommand command = new MySqlCommand(sql, conn))
            {
                command.Parameters.AddWithValue("@userId",userId);


                MySqlDataAdapter data = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                dataGrid.DataSource = dataTable;
                dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
        public static void Alert(int userId) //working
        {
           DateTime localtime = DateTime.Now;
           DateTime currentTime = localtime.ToUniversalTime();
           DateTime targetTime = currentTime.AddMinutes(15);


            string sql = @"SELECT appointment.start
                              FROM appointment 
                              WHERE appointment.userId = @userId";

            try
            {


                MySqlCommand command = new MySqlCommand(sql, conn); //execute the sql query 
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime start = reader.GetDateTime("start");

                            if (start >= currentTime && start <= targetTime)
                            {
                                MessageBox.Show("You have an upcomming appointment within the next 15 minutes");
                                break;
                            }
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public static void Refresh(bool week, bool month, bool all, DataGridView datagrid) 
        {

            try
            {
                if (week)
                {
                    DateTime now = DateTime.Today;
                    DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek + 1);
                    DateTime endOfWeek = startOfWeek.AddDays(6);

                    string thisweek = @"SELECT appointmentId, appointment.customerId, userId, appointment.type, appointment.start, appointment.end  
                                        FROM appointment, customer 
                                        WHERE customer.customerId = appointment.customerId 
                                        AND appointment.start >= @startOfWeek 
                                        AND appointment.end <= @endOfWeek";

                    using (MySqlCommand data = new MySqlCommand(thisweek, conn))
                    {
                        data.Parameters.AddWithValue("@startOfWeek", startOfWeek);
                        data.Parameters.AddWithValue("@endOfWeek", endOfWeek);
                        

                        MySqlDataAdapter datax = new MySqlDataAdapter(data);
                        DataTable dataTable = new DataTable();
                        datax.Fill(dataTable);

                        datagrid.DataSource = dataTable;
                        datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }

                }
                else if (month)
                {
                    DateTime now = DateTime.Today;
                    DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                    string thismonth = @"SELECT appointmentId, appointment.customerId, userId, appointment.type, appointment.start, appointment.end  
                                        FROM appointment, customer 
                                        WHERE customer.customerId = appointment.customerId 
                                        AND appointment.start >= @startOfMonth 
                                        AND appointment.end <= @endOfMonth";

                    using (MySqlCommand data = new MySqlCommand(thismonth, conn))
                    {
                        data.Parameters.AddWithValue("@startOfMonth", startOfMonth);
                        data.Parameters.AddWithValue("@endOfMonth", endOfMonth);
                        

                        MySqlDataAdapter datax = new MySqlDataAdapter(data);
                        DataTable dataTable = new DataTable();
                        datax.Fill(dataTable);

                        datagrid.DataSource = dataTable;
                        datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                }
                else
                {
                    string sql = @"SELECT appointmentId, appointment.customerId, userId, appointment.type, appointment.start, appointment.end 
                              FROM appointment, customer 
                              WHERE customer.customerId = appointment.customerId";

                    MySqlDataAdapter data = new MySqlDataAdapter(sql, conn);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    datagrid.DataSource = dataTable;
                    datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }




        public static void CustomerDatabase(DataGridView datagrid)
        {
            try
            {
                string sql = @"SELECT customerId,address.addressId,city.cityId,country.countryId, customerName, address, phone, city, country
                    FROM address, customer , city, country
                    WHERE  address.addressId = customer.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId ";

                MySqlDataAdapter data = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                datagrid.DataSource = dataTable;
                datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void AppointmentDatabase(DataGridView datagrid) //working on 
        {
            try
            {
                string sql = @"SELECT appointmentId, appointment.customerId, userId, appointment.type, appointment.start, appointment.end 
                              FROM appointment, customer 
                              WHERE customer.customerId = appointment.customerId";

                MySqlDataAdapter data = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                datagrid.DataSource = dataTable;
                datagrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UserIDComboBox(ComboBox comboBox)
        {
            try
            {
                string sql = @"SELECT userId FROM user";
                using (MySqlCommand datax = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter data = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        data.Fill(dataTable);
                        comboBox.DataSource = dataTable;
                        comboBox.DisplayMember = "userId";


                    }
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public static void CustomerIDComboBox(ComboBox comboBox)
        {
            try
            {
                string sql = @"SELECT customerId FROM customer";
                using (MySqlCommand datax = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataAdapter data = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        data.Fill(dataTable);
                        comboBox.DataSource = dataTable;
                        comboBox.DisplayMember = "customerId";
                    }
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ModifyAppointment(string appointmentId, string customerId, string userId, string type, DateTime start, DateTime end)
        {
            try
            {

                DateTime utcStartTime = start.ToUniversalTime(); //converts user input to UTC 
                DateTime utcEndTime = end.ToUniversalTime(); // to store in the database

                string sql = "UPDATE appointment SET customerId = @customerId, userId = @userId, type = @type, start = @start, end = @end WHERE appointmentId = @appointmentId";
                using (MySqlCommand data = new MySqlCommand(sql, conn))
                {
                    data.Parameters.AddWithValue("appointmentId", appointmentId);
                    data.Parameters.AddWithValue("@customerId", customerId);
                    data.Parameters.AddWithValue("@userId", userId);
                    data.Parameters.AddWithValue("@type", type);
                    data.Parameters.AddWithValue("@start", utcStartTime);
                    data.Parameters.AddWithValue("@end", utcEndTime);
                    data.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public static void ModifyCustomer(string customerid, string addressid, string cityid, string countryid, string name, string address, string number, string city, string country)
        {
            try
            {




                string customer = @"UPDATE customer SET customerName = @name WHERE customerId = @customerid";
                string addressX = @"UPDATE address SET address.address = @address, phone = @number WHERE address.addressId = @addressid";
                string cityX = @"UPDATE city SET city.city = @city WHERE city.cityId = @cityid";
                string countryX = @"UPDATE country SET country.country = @country WHERE country.countryId = @countryid ";


                using (MySqlCommand data = new MySqlCommand(customer, conn))
                {
                    data.Parameters.AddWithValue("@name", name);
                    data.Parameters.AddWithValue("@customerId", customerid);
                    data.ExecuteNonQuery();

                }


                using (MySqlCommand data = new MySqlCommand(addressX, conn))
                {
                    data.Parameters.AddWithValue("@address", address);
                    data.Parameters.AddWithValue("@number", number);
                    data.Parameters.AddWithValue("@addressId", addressid);
                    data.ExecuteNonQuery();

                }

                using (MySqlCommand data = new MySqlCommand(cityX, conn))
                {
                    data.Parameters.AddWithValue("@city", city);
                    data.Parameters.AddWithValue("@cityId", cityid);
                    data.ExecuteNonQuery();

                }

                using (MySqlCommand data = new MySqlCommand(countryX, conn))
                {
                    data.Parameters.AddWithValue("@country", country);
                    data.Parameters.AddWithValue("@countryId", countryid);
                    data.ExecuteNonQuery();

                }





            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void DeleteAppointment(string appointmentId)
        {
            try
            {
                string sql = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                using (MySqlCommand data = new MySqlCommand(sql, conn))
                {
                    data.Parameters.AddWithValue("appointmentId", appointmentId);
                    data.ExecuteNonQuery();
                }



            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void DeleteCustomer(string customerid, string addressid, string cityid, string countryid, string name, string address, string number, string city, string country)
        {




            try
            {
                string customer = @"DELETE FROM customer  WHERE customerId = @customerid";
                string addressX = @"DELETE FROM address WHERE addressId = @addressid;";
                string cityX = @"DELETE FROM city WHERE cityId = @cityid";
                string countryX = @"DELETE FROM country WHERE countryId = @countryid";








                using (MySqlCommand data = new MySqlCommand(customer, conn))//1
                {

                    data.Parameters.AddWithValue("@customerId", customerid);
                    data.ExecuteNonQuery();

                }


                using (MySqlCommand data = new MySqlCommand(addressX, conn))//2
                {

                    data.Parameters.AddWithValue("@addressId", addressid);
                    data.ExecuteNonQuery();

                }

                using (MySqlCommand data = new MySqlCommand(cityX, conn)) //3
                {

                    data.Parameters.AddWithValue("@cityId", cityid);
                    data.ExecuteNonQuery();

                }

                using (MySqlCommand data = new MySqlCommand(countryX, conn)) // 4
                {

                    data.Parameters.AddWithValue("@countryId", countryid);
                    data.ExecuteNonQuery();
                }






            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void AppointmentAdd(string customerId, string userId, string type, DateTime start, DateTime end)
        {
            try
            {
                DateTime utcStartTime = start.ToUniversalTime(); //converts user input to UTC 
                DateTime utcEndTime = end.ToUniversalTime(); // to store in the database 

                string sql = @"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                               VALUES(@customerId,@userId,'not needed', 'not needed', 'not needed','not needed',@type,'not needed',@start,@end,NOW(),'test',NOW(),'test')";


                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@start", utcStartTime);
                    command.Parameters.AddWithValue("@end", utcEndTime);
                    command.ExecuteNonQuery();
                }
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



                using (MySqlCommand command4 = new MySqlCommand(sql4, conn))
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

    }
}
