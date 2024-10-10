using Software_2_Rykeem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_2_Rykeem
{
    public partial class ModifyCustomer : Form
    {
        
        private DataGridView datagrid;
        private string customerid;
        private string addressid;
        private string cityid;
        private string countryid;
        
        public ModifyCustomer(string customerId, string addressId, string cityId, string countryId, string name, string address, string phone, string city, string country, DataGridView data)
        {
            InitializeComponent();

            IDTB.Text = customerId;
            nameTB2.Text = name;
            addressTB2.Text = address;
            numberTB2.Text = phone;
            cityTB2.Text = city;
            countryTB2.Text = country;


            datagrid = data;
            string customerid = customerId;
            string addressid = addressId;
            string cityid = cityId;
            string countryid = countryId;


            SaveButton();
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



            Connection.ModifyCustomer(IDTB.Text, addressid, cityid, countryid, nameTB2.Text.Trim(), addressTB2.Text.Trim(), numberTB2.Text.Trim(), cityTB2.Text.Trim(), countryTB2.Text.Trim());

            Connection.CustomerDatabase(datagrid);
            Customer.Instance.Show();
            this.Close();
        }

        private void SaveButton()
        {
            if (nameTB2.BackColor == Color.White &&
                addressTB2.BackColor == Color.White &&
                numberTB2.BackColor == Color.White &&
                cityTB2.BackColor == Color.White &&
                countryTB2.BackColor == Color.White)
            {
                SaveB2.Enabled = true;
            }
            else { SaveB2.Enabled = false; }

        }









        private void nameTB2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB2.Text) || int.TryParse(nameTB2.Text, out int name))
            {
                nameTB2.BackColor = Color.Red;
                SaveB2.Enabled = false;
            }
            else
            {
                nameTB2.BackColor = Color.White;
            }
            SaveButton();
        }

        private void addressTB2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTB2.Text) || int.TryParse(addressTB2.Text, out int name))
            {
                addressTB2.BackColor = Color.Red;
                SaveB2.Enabled = false;
            }
            else
            {
                addressTB2.BackColor = Color.White;
            }
            SaveButton();
        }

        private void numberTB2_TextChanged(object sender, EventArgs e)
        {
            string onlynumbers = @"^[0-9-]+$";




            if (Regex.IsMatch(numberTB2.Text, onlynumbers))
            {
                numberTB2.BackColor = Color.White;
            }
            else
            {
                numberTB2.BackColor = Color.Red;
                SaveB2.Enabled = false;
            }
            SaveButton();
        }

        private void cityTB2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTB2.Text) || int.TryParse(addressTB2.Text, out int name))
            {
                cityTB2.BackColor = Color.Red;
                SaveB2.Enabled = false;
            }
            else
            {
                cityTB2.BackColor = Color.White;
            }
            SaveButton();
        }

        private void countryTB2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTB2.Text) || int.TryParse(addressTB2.Text, out int name))
            {
                countryTB2.BackColor = Color.Red;
                SaveB2.Enabled = false;
            }
            else
            {
                countryTB2.BackColor = Color.White;
            }
            SaveButton();
        }
    }
}
