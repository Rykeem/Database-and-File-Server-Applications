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
    public partial class ModifyAppointment : Form
    {
        private DataGridView dataX;
        public ModifyAppointment(string type, string appointmentId, string customerId, string userId, DateTime start, DateTime end, DataGridView data)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
           

            Connection.UserIDComboBox(UserIDCB1);
            Connection.CustomerIDComboBox(CustomerIDCB1);
           
            dataX = data;

            
            AppointmentIDTB.Text = appointmentId;
            UserIDCB1.Text = userId;
            CustomerIDCB1.Text = customerId;
            nameTB1.Text = type;
            dateTimePicker1.Value = start;
            dateTimePicker2.Value = end;
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
                        foreach (DataGridViewRow row in dataX.Rows)
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
                            Connection.ModifyAppointment(AppointmentIDTB.Text, CustomerIDCB1.Text, UserIDCB1.Text, nameTB1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                            Connection.AppointmentDatabase(dataX);
                            
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

        private void CancelB1_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer.Instance.Show();
        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}


