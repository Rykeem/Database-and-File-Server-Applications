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
    public partial class ModifyCustomer : Form
    {
        
        private DataGridView datagrid;
        public ModifyCustomer(string id, string name, string address, string phone, string city, string country, DataGridView data)
        {
            InitializeComponent();

            IDTB.Text = id;
            nameTB2.Text = name;
            addressTB2.Text = address;
            numberTB2.Text = phone;
            cityTB2.Text = city;
            countryTB2.Text = country;


            datagrid = data;

        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelB2_Click(object sender, EventArgs e)
        {
            
            Customer.Instance.Show();
            this.Close();
        }

        private void SaveB2_Click(object sender, EventArgs e)
        {



            Connection.ModifyCustomer(IDTB.Text, nameTB2.Text, addressTB2.Text, numberTB2.Text,cityTB2.Text, countryTB2.Text);
            Connection.CustomerDatabase(datagrid);
            Customer.Instance.Show();
            this.Close();
        }
    }
}
