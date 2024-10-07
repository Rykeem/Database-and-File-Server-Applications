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
    }
}
