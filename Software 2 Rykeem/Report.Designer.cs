﻿namespace Software_2_Rykeem
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.report1DGV = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BackB = new System.Windows.Forms.Button();
            this.Report2DV = new System.Windows.Forms.DataGridView();
            this.ReportLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserIDCB1 = new System.Windows.Forms.ComboBox();
            this.UserIDLB1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.report1DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report2DV)).BeginInit();
            this.SuspendLayout();
            // 
            // report1DGV
            // 
            this.report1DGV.AllowUserToAddRows = false;
            this.report1DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report1DGV.Location = new System.Drawing.Point(48, 365);
            this.report1DGV.MultiSelect = false;
            this.report1DGV.Name = "report1DGV";
            this.report1DGV.ReadOnly = true;
            this.report1DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report1DGV.Size = new System.Drawing.Size(344, 193);
            this.report1DGV.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(804, 365);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(294, 193);
            this.dataGridView1.TabIndex = 7;
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(1206, 522);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(103, 36);
            this.BackB.TabIndex = 14;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // Report2DV
            // 
            this.Report2DV.AllowUserToAddRows = false;
            this.Report2DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report2DV.Location = new System.Drawing.Point(27, 91);
            this.Report2DV.MultiSelect = false;
            this.Report2DV.Name = "Report2DV";
            this.Report2DV.ReadOnly = true;
            this.Report2DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report2DV.Size = new System.Drawing.Size(567, 193);
            this.Report2DV.TabIndex = 15;
            // 
            // ReportLB
            // 
            this.ReportLB.AutoSize = true;
            this.ReportLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLB.Location = new System.Drawing.Point(45, 27);
            this.ReportLB.Name = "ReportLB";
            this.ReportLB.Size = new System.Drawing.Size(365, 37);
            this.ReportLB.TabIndex = 16;
            this.ReportLB.Text = "Schedule For Each User";
            this.ReportLB.Click += new System.EventHandler(this.ReportLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Appointment By Month";
            // 
            // UserIDCB1
            // 
            this.UserIDCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB1.FormattingEnabled = true;
            this.UserIDCB1.Location = new System.Drawing.Point(544, 43);
            this.UserIDCB1.Name = "UserIDCB1";
            this.UserIDCB1.Size = new System.Drawing.Size(121, 21);
            this.UserIDCB1.TabIndex = 34;
            this.UserIDCB1.SelectedIndexChanged += new System.EventHandler(this.UserIDCB1_SelectedIndexChanged);
            // 
            // UserIDLB1
            // 
            this.UserIDLB1.AutoSize = true;
            this.UserIDLB1.Location = new System.Drawing.Point(455, 43);
            this.UserIDLB1.Name = "UserIDLB1";
            this.UserIDLB1.Size = new System.Drawing.Size(43, 13);
            this.UserIDLB1.TabIndex = 33;
            this.UserIDLB1.Text = "User ID";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 621);
            this.Controls.Add(this.UserIDCB1);
            this.Controls.Add(this.UserIDLB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportLB);
            this.Controls.Add(this.Report2DV);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.report1DGV);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.report1DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report2DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView report1DGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.DataGridView Report2DV;
        private System.Windows.Forms.Label ReportLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UserIDCB1;
        private System.Windows.Forms.Label UserIDLB1;
    }
}