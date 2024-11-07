﻿using Software_2_Rykeem.Database;
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
        public Report()
        {

            InitializeComponent();
            Connection.Report1(report1DGV);
            Connection.Report3(Row3DGV);
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
            
            Connection.Report2(Report2DV, UserIDCB1.Text);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
