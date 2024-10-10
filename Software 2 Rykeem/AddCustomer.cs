using MySql.Data.MySqlClient;
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
    public partial class AddCustomer : Form
    {
        private DataGridView datagrid;
        
        public AddCustomer(DataGridView data)
        {
            InitializeComponent();
            datagrid = data;
            SaveButton();
        }

        private void CancelB1_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer.Instance.Show();
        }

        private void SaveB1_Click(object sender, EventArgs e)
        {
            
            



                string name = nameTB1.Text.Trim();
                string address = addressTB1.Text.Trim();
                string phone = numberTB1.Text.Trim();
                string city = cityTB1.Text.Trim();
                string country = countryTB1.Text.Trim();
            
            Connection.CustomerAdd(name, address, phone, city, country);
    
            Connection.CustomerDatabase(datagrid);
            Customer.Instance.Show();
            this.Close();



        }
        private void SaveButton()
        {
            if (nameTB1.BackColor == Color.White && 
                addressTB1.BackColor == Color.White &&
                numberTB1.BackColor == Color.White &&
                cityTB1.BackColor == Color.White &&
                countryTB1.BackColor == Color.White)
            {
                SaveB1.Enabled = true;
            }
            else { SaveB1.Enabled = false; }

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

        private void addressTB1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTB1.Text) || int.TryParse(addressTB1.Text, out int name))
            {
                addressTB1.BackColor = Color.Red;
                SaveB1.Enabled = false;
            }
            else
            {
                addressTB1.BackColor = Color.White;
            }
            SaveButton();
        }

        private void numberTB1_TextChanged(object sender, EventArgs e)
        {
            string onlynumbers = @"^[0-9-]+$";
            

           
            
            if (Regex.IsMatch(numberTB1.Text, onlynumbers))
            {
                numberTB1.BackColor = Color.White;
            }
            else
            {
                numberTB1.BackColor = Color.Red;
                SaveB1.Enabled = false;
            }
            SaveButton();
        }

        private void cityTB1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTB1.Text) || int.TryParse(cityTB1.Text, out int name))
            {
                cityTB1.BackColor = Color.Red;
                SaveB1.Enabled = false;
            }
            else
            {
                cityTB1.BackColor = Color.White;
            }
            SaveButton();
        }

        private void countryTB1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryTB1.Text) || int.TryParse(countryTB1.Text, out int name))
            {
                countryTB1.BackColor = Color.Red;
                SaveB1.Enabled = false;
            }
            else
            {
                countryTB1.BackColor = Color.White;
            }
            SaveButton();
        }
    }
}
