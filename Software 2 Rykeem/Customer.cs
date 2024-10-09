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


                string ID = CustomerDGV.Rows[index].Cells[0].Value.ToString();
                string name = CustomerDGV.Rows[index].Cells[1].Value.ToString();
                string address = CustomerDGV.Rows[index].Cells[2].Value.ToString();
                string phone = CustomerDGV.Rows[index].Cells[3].Value.ToString();
                string city = CustomerDGV.Rows[index].Cells[4].Value.ToString();
                string country = CustomerDGV.Rows[index].Cells[5].Value.ToString();

            this.Hide();
            ModifyCustomer modify = new ModifyCustomer(ID, name, address, phone, city, country, CustomerDGV);
            modify.Show();








            
            

        }
    }
}
