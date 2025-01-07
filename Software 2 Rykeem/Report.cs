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
    public partial class Report : Form
    {
        public static Customer Instance { get; set; }
        private MySqlConnection _connection;
        public Report( MySqlConnection connection)
        {

            InitializeComponent();
            _connection = connection;
            
            var report1 = new Report1(_connection);
            report1.CreateReport(report1DGV);

            var report3 = new Report3(_connection);
            report3.CreateReport(Row3DGV);

            Connection.UserIDComboBox(UserIDCB1);
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer.Instance.Show();
        }

        private void ReportLB_Click(object sender, EventArgs e)
        {

        }

        private void UserIDCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (UserIDCB1.SelectedIndex != null)
            {
                var UserId = UserIDCB1.Text;
                var report2 = new Report2(_connection, UserId);
                report2.CreateReport(Report2DV);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userInput = textBox1.Text.Trim();
            if(string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Entry can not be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var report4 = new Report4(_connection); 
            report4.CreateReport2(Report2DV, userInput);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
