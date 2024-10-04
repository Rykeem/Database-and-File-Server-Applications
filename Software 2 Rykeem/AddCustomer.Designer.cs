namespace Software_2_Rykeem
{
    partial class AddCustomer
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
            this.nameLB1 = new System.Windows.Forms.Label();
            this.addressLB1 = new System.Windows.Forms.Label();
            this.numberLB1 = new System.Windows.Forms.Label();
            this.cityLB1 = new System.Windows.Forms.Label();
            this.countryLB1 = new System.Windows.Forms.Label();
            this.nameTB1 = new System.Windows.Forms.TextBox();
            this.addressTB1 = new System.Windows.Forms.TextBox();
            this.numberTB1 = new System.Windows.Forms.TextBox();
            this.cityTB1 = new System.Windows.Forms.TextBox();
            this.countryTB1 = new System.Windows.Forms.TextBox();
            this.CancelB1 = new System.Windows.Forms.Button();
            this.SaveB1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLB1
            // 
            this.nameLB1.AutoSize = true;
            this.nameLB1.Location = new System.Drawing.Point(24, 42);
            this.nameLB1.Name = "nameLB1";
            this.nameLB1.Size = new System.Drawing.Size(35, 13);
            this.nameLB1.TabIndex = 0;
            this.nameLB1.Text = "Name";
            // 
            // addressLB1
            // 
            this.addressLB1.AutoSize = true;
            this.addressLB1.Location = new System.Drawing.Point(24, 117);
            this.addressLB1.Name = "addressLB1";
            this.addressLB1.Size = new System.Drawing.Size(45, 13);
            this.addressLB1.TabIndex = 1;
            this.addressLB1.Text = "Address";
            // 
            // numberLB1
            // 
            this.numberLB1.AutoSize = true;
            this.numberLB1.Location = new System.Drawing.Point(24, 196);
            this.numberLB1.Name = "numberLB1";
            this.numberLB1.Size = new System.Drawing.Size(78, 13);
            this.numberLB1.TabIndex = 3;
            this.numberLB1.Text = "Phone Number";
            // 
            // cityLB1
            // 
            this.cityLB1.AutoSize = true;
            this.cityLB1.Location = new System.Drawing.Point(24, 263);
            this.cityLB1.Name = "cityLB1";
            this.cityLB1.Size = new System.Drawing.Size(24, 13);
            this.cityLB1.TabIndex = 2;
            this.cityLB1.Text = "City";
            // 
            // countryLB1
            // 
            this.countryLB1.AutoSize = true;
            this.countryLB1.Location = new System.Drawing.Point(24, 323);
            this.countryLB1.Name = "countryLB1";
            this.countryLB1.Size = new System.Drawing.Size(43, 13);
            this.countryLB1.TabIndex = 4;
            this.countryLB1.Text = "Country";
            // 
            // nameTB1
            // 
            this.nameTB1.Location = new System.Drawing.Point(134, 42);
            this.nameTB1.Name = "nameTB1";
            this.nameTB1.Size = new System.Drawing.Size(100, 20);
            this.nameTB1.TabIndex = 5;
            // 
            // addressTB1
            // 
            this.addressTB1.Location = new System.Drawing.Point(134, 114);
            this.addressTB1.Name = "addressTB1";
            this.addressTB1.Size = new System.Drawing.Size(100, 20);
            this.addressTB1.TabIndex = 6;
            // 
            // numberTB1
            // 
            this.numberTB1.Location = new System.Drawing.Point(134, 196);
            this.numberTB1.Name = "numberTB1";
            this.numberTB1.Size = new System.Drawing.Size(100, 20);
            this.numberTB1.TabIndex = 7;
            // 
            // cityTB1
            // 
            this.cityTB1.Location = new System.Drawing.Point(134, 263);
            this.cityTB1.Name = "cityTB1";
            this.cityTB1.Size = new System.Drawing.Size(100, 20);
            this.cityTB1.TabIndex = 8;
            // 
            // countryTB1
            // 
            this.countryTB1.Location = new System.Drawing.Point(134, 315);
            this.countryTB1.Name = "countryTB1";
            this.countryTB1.Size = new System.Drawing.Size(100, 20);
            this.countryTB1.TabIndex = 9;
            // 
            // CancelB1
            // 
            this.CancelB1.Location = new System.Drawing.Point(159, 471);
            this.CancelB1.Name = "CancelB1";
            this.CancelB1.Size = new System.Drawing.Size(75, 23);
            this.CancelB1.TabIndex = 10;
            this.CancelB1.Text = "Cancel";
            this.CancelB1.UseVisualStyleBackColor = true;
            // 
            // SaveB1
            // 
            this.SaveB1.Location = new System.Drawing.Point(266, 471);
            this.SaveB1.Name = "SaveB1";
            this.SaveB1.Size = new System.Drawing.Size(75, 23);
            this.SaveB1.TabIndex = 11;
            this.SaveB1.Text = "Save";
            this.SaveB1.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 514);
            this.Controls.Add(this.SaveB1);
            this.Controls.Add(this.CancelB1);
            this.Controls.Add(this.countryTB1);
            this.Controls.Add(this.cityTB1);
            this.Controls.Add(this.numberTB1);
            this.Controls.Add(this.addressTB1);
            this.Controls.Add(this.nameTB1);
            this.Controls.Add(this.countryLB1);
            this.Controls.Add(this.numberLB1);
            this.Controls.Add(this.cityLB1);
            this.Controls.Add(this.addressLB1);
            this.Controls.Add(this.nameLB1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLB1;
        private System.Windows.Forms.Label addressLB1;
        private System.Windows.Forms.Label numberLB1;
        private System.Windows.Forms.Label cityLB1;
        private System.Windows.Forms.Label countryLB1;
        private System.Windows.Forms.TextBox nameTB1;
        private System.Windows.Forms.TextBox addressTB1;
        private System.Windows.Forms.TextBox numberTB1;
        private System.Windows.Forms.TextBox cityTB1;
        private System.Windows.Forms.TextBox countryTB1;
        private System.Windows.Forms.Button CancelB1;
        private System.Windows.Forms.Button SaveB1;
    }
}