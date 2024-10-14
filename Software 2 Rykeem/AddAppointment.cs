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
            Connection.UserIDComboBox(UserIDCB1);
            Connection.CustomerIDComboBox(CustomerIDCB1);
            dataXX = data;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            Connection.AppointmentAdd(CustomerIDCB1.Text, UserIDCB1.Text, nameTB1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            Connection.AppointmentDatabase(dataXX);
        }
    }
}
