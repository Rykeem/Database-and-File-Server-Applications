using Org.BouncyCastle.Asn1.BC;
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
    public partial class Customer : Form
    {
        public static Customer Instance { get; set; }
        public Customer()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

            Connection.CustomerDatabase(CustomerDGV);
            Connection.AppointmentDatabase(AppointmentDGV);
            AppointmentDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            UserTime(AppointmentDGV);

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddCustomer add = new AddCustomer(CustomerDGV);
            add.Show();
            CustomerDGV.Refresh();
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (CustomerDGV.CurrentRow == null || !CustomerDGV.CurrentRow.Selected)
            {
                MessageBox.Show("No row has been selected.");
                return;
            }
            int index = CustomerDGV.CurrentCell.RowIndex;


            string customerID = CustomerDGV.Rows[index].Cells[0].Value.ToString();//customerId
            string addressID = CustomerDGV.Rows[index].Cells[1].Value.ToString();//address
            string cityID = CustomerDGV.Rows[index].Cells[2].Value.ToString();//city
            string countryID = CustomerDGV.Rows[index].Cells[3].Value.ToString();//country


            string name = CustomerDGV.Rows[index].Cells[4].Value.ToString();
            string address = CustomerDGV.Rows[index].Cells[5].Value.ToString();
            string phone = CustomerDGV.Rows[index].Cells[6].Value.ToString();
            string city = CustomerDGV.Rows[index].Cells[7].Value.ToString();
            string country = CustomerDGV.Rows[index].Cells[8].Value.ToString();

            this.Hide();
            ModifyCustomer modify = new ModifyCustomer(customerID, addressID, cityID, countryID, name, address, phone, city, country, CustomerDGV);
            modify.Show();











        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CustomerDGV.CurrentRow == null || !CustomerDGV.CurrentRow.Selected)
            {
                MessageBox.Show("No row has been selected.");
                return;
            }
            int index = CustomerDGV.CurrentCell.RowIndex;








            string customerID = CustomerDGV.Rows[index].Cells[0].Value.ToString();//customerId
            string addressID = CustomerDGV.Rows[index].Cells[1].Value.ToString();//address
            string cityID = CustomerDGV.Rows[index].Cells[2].Value.ToString();//city
            string countryID = CustomerDGV.Rows[index].Cells[3].Value.ToString();//country


            string name = CustomerDGV.Rows[index].Cells[4].Value.ToString();
            string address = CustomerDGV.Rows[index].Cells[5].Value.ToString();
            string phone = CustomerDGV.Rows[index].Cells[6].Value.ToString();
            string city = CustomerDGV.Rows[index].Cells[7].Value.ToString();
            string country = CustomerDGV.Rows[index].Cells[8].Value.ToString();


            Connection.DeleteCustomer(customerID, addressID, cityID, countryID, name, address, phone, city, country);
            Connection.CustomerDatabase(CustomerDGV);





        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment(AppointmentDGV);
            addAppointment.Show();
            this.Hide();
        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {

            if (AppointmentDGV.CurrentRow == null || !AppointmentDGV.CurrentRow.Selected)
            {
                MessageBox.Show("No row has been selected.");
                return;
            }
            int index = AppointmentDGV.CurrentCell.RowIndex;


            string appointmentId = AppointmentDGV.Rows[index].Cells[0].Value.ToString();//appointmentId
            string customerId = AppointmentDGV.Rows[index].Cells[1].Value.ToString();//customerId
            string userId = AppointmentDGV.Rows[index].Cells[2].Value.ToString();//userId
            string type = AppointmentDGV.Rows[index].Cells[3].Value.ToString();//type
            DateTime start = (DateTime)AppointmentDGV.Rows[index].Cells[4].Value; // start time
            DateTime end = (DateTime)AppointmentDGV.Rows[index].Cells[5].Value;// end time 





            ModifyAppointment modifyAppointment = new ModifyAppointment(type, appointmentId, customerId, userId, start, end, AppointmentDGV);
            modifyAppointment.Show();
            this.Hide();
        }



        private void deleteButton2_Click_1(object sender, EventArgs e)
        {
            if (AppointmentDGV.CurrentRow == null || !AppointmentDGV.CurrentRow.Selected)
            {
                MessageBox.Show("No row has been selected.");
                return;
            }
            int index = AppointmentDGV.CurrentCell.RowIndex;


            string appointmentId = AppointmentDGV.Rows[index].Cells[0].Value.ToString();//appointmentId
            Connection.DeleteAppointment(appointmentId);
            Connection.AppointmentDatabase(AppointmentDGV);
        }

        public void refresh()
        {
            bool week = radioButton1.Checked == true;
            bool month = radioButton2.Checked == true;
            bool year = radioButton3.Checked == true;
            Connection.Refresh(week, month, year, AppointmentDGV);
        }
        public void UserTime(DataGridView data)
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                DateTime utcStart = (DateTime)row.Cells["start"].Value;
                DateTime utcEnd = (DateTime)row.Cells["end"].Value;

                row.Cells["start"].Value = utcStart.ToLocalTime();
                row.Cells["end"].Value = utcEnd.ToLocalTime();
               
            }
            data.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
            UserTime(AppointmentDGV);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
            UserTime(AppointmentDGV);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            refresh();
            UserTime(AppointmentDGV);
            
        }

        private void Customer_VisibleChanged(object sender, EventArgs e)
        {
            refresh();
            UserTime(AppointmentDGV);

        }
    }
}

