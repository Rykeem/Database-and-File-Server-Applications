using MySql.Data.MySqlClient;
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
    public partial class AddCustomer : Form
    {
        private DataGridView datagrid;
        
        public AddCustomer(DataGridView data)
        {
            InitializeComponent();
            datagrid = data;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void CancelB1_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer.Instance.Show();
        }

        private void SaveB1_Click(object sender, EventArgs e)
        {
            
            



                string name = nameTB1.Text;
                string address = addressTB1.Text;
                string phone = numberTB1.Text;
                string city = cityTB1.Text;
                string country = countryTB1.Text;
            
            Connection.CustomerAdd(name, address, phone, city, country);
            Connection.CustomerDatabase(datagrid);
            Customer.Instance.Show();
            this.Close();



        }
    }
}
