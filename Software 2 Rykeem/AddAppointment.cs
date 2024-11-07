using Software_2_Rykeem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_Rykeem
{

    public partial class AddAppointment : Form
    {
        private DataGridView dataXX;
        public AddAppointment(DataGridView data)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            Connection.UserIDComboBox(UserIDCB1);
            Connection.CustomerIDComboBox(CustomerIDCB1);
            dataXX = data;
            SaveB1.Enabled = false;
        }

       

        private void CancelB1_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer.Instance.Show();
        }

        private void UserIDCB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveB1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value; //start time 
            DateTime dateTime2 = dateTimePicker2.Value; // end time 

            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo est2 = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            DateTime datetimeEST = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local, est); //start est 
            DateTime datetimeEST2 = TimeZoneInfo.ConvertTime(dateTime2, TimeZoneInfo.Local, est2); // end est
            
           
            if (dateTime < dateTime2)
            {
                if (datetimeEST.DayOfWeek >= DayOfWeek.Monday && datetimeEST.DayOfWeek <= DayOfWeek.Friday && datetimeEST2.DayOfWeek >= DayOfWeek.Monday && datetimeEST2.DayOfWeek <= DayOfWeek.Friday)
                {
                    if (datetimeEST.TimeOfDay >= new TimeSpan(9, 0, 0) && datetimeEST.TimeOfDay <= new TimeSpan(17, 0, 0) && datetimeEST2.TimeOfDay >= new TimeSpan(9, 0, 0) && datetimeEST2.TimeOfDay <= new TimeSpan(17, 0, 0))
                    {
                        bool boool = true;
                        foreach (DataGridViewRow row in dataXX.Rows)
                        {
                            DateTime startTime = Convert.ToDateTime(row.Cells["start"].Value); //start times
                            DateTime endTime = Convert.ToDateTime(row.Cells["end"].Value); // end times


                            DateTime startTimeEST = TimeZoneInfo.ConvertTime(startTime, TimeZoneInfo.Local, est); // Appointment time local time to est
                            DateTime endTimeEST = TimeZoneInfo.ConvertTime(endTime, TimeZoneInfo.Local, est2); // Appointment time to est

                            if (datetimeEST < endTimeEST && datetimeEST2 > startTimeEST)
                            {
                                MessageBox.Show("Your appointment cannot overlap with an existing one");
                                boool = false;
                                break;
                            }
                        }


                        if (boool)
                        {
                            Connection.AppointmentAdd(CustomerIDCB1.Text, UserIDCB1.Text, nameTB1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                            Connection.AppointmentDatabase(dataXX);
                            this.Close();
                            Customer.Instance.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("The times must be between 9AM through 5PM EST");
                    }


                }
                else
                {
                    MessageBox.Show("The date has to be between Monday through Friday");
                }


            }
            else
            {
                MessageBox.Show("Start time must be before end time");
            }





           



        }

        private void SaveButton()
        {
            SaveB1.Enabled = nameTB1.BackColor == Color.White ? true : false;
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void nameTB1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB1.Text) || int.TryParse(nameTB1.Text, out int name))
            {
                nameTB1.BackColor = Color.Red;
                SaveB1.Enabled = false;
            }
            else
            {
                nameTB1.BackColor = Color.White;
            }
            SaveButton();
        }
    }
}

        
 
