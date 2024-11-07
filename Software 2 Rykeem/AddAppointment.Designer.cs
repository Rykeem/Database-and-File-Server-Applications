namespace Software_2_Rykeem
{
    partial class AddAppointment
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
            this.SaveB1 = new System.Windows.Forms.Button();
            this.CancelB1 = new System.Windows.Forms.Button();
            this.nameTB1 = new System.Windows.Forms.TextBox();
            this.ScheduleTimeLB1 = new System.Windows.Forms.Label();
            this.UserIDLB1 = new System.Windows.Forms.Label();
            this.CustomerIDLB1 = new System.Windows.Forms.Label();
            this.typeLB1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.UserIDCB1 = new System.Windows.Forms.ComboBox();
            this.CustomerIDCB1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveB1
            // 
            this.SaveB1.Location = new System.Drawing.Point(260, 460);
            this.SaveB1.Name = "SaveB1";
            this.SaveB1.Size = new System.Drawing.Size(75, 23);
            this.SaveB1.TabIndex = 23;
            this.SaveB1.Text = "Save";
            this.SaveB1.UseVisualStyleBackColor = true;
            this.SaveB1.Click += new System.EventHandler(this.SaveB1_Click);
            // 
            // CancelB1
            // 
            this.CancelB1.Location = new System.Drawing.Point(153, 460);
            this.CancelB1.Name = "CancelB1";
            this.CancelB1.Size = new System.Drawing.Size(75, 23);
            this.CancelB1.TabIndex = 22;
            this.CancelB1.Text = "Cancel";
            this.CancelB1.UseVisualStyleBackColor = true;
            this.CancelB1.Click += new System.EventHandler(this.CancelB1_Click);
            // 
            // nameTB1
            // 
            this.nameTB1.Location = new System.Drawing.Point(128, 31);
            this.nameTB1.Name = "nameTB1";
            this.nameTB1.Size = new System.Drawing.Size(100, 20);
            this.nameTB1.TabIndex = 17;
            this.nameTB1.TextChanged += new System.EventHandler(this.nameTB1_TextChanged);
            // 
            // ScheduleTimeLB1
            // 
            this.ScheduleTimeLB1.AutoSize = true;
            this.ScheduleTimeLB1.Location = new System.Drawing.Point(18, 185);
            this.ScheduleTimeLB1.Name = "ScheduleTimeLB1";
            this.ScheduleTimeLB1.Size = new System.Drawing.Size(55, 13);
            this.ScheduleTimeLB1.TabIndex = 15;
            this.ScheduleTimeLB1.Text = "Start Time";
            // 
            // UserIDLB1
            // 
            this.UserIDLB1.AutoSize = true;
            this.UserIDLB1.Location = new System.Drawing.Point(18, 295);
            this.UserIDLB1.Name = "UserIDLB1";
            this.UserIDLB1.Size = new System.Drawing.Size(43, 13);
            this.UserIDLB1.TabIndex = 14;
            this.UserIDLB1.Text = "User ID";
            // 
            // CustomerIDLB1
            // 
            this.CustomerIDLB1.AutoSize = true;
            this.CustomerIDLB1.Location = new System.Drawing.Point(18, 106);
            this.CustomerIDLB1.Name = "CustomerIDLB1";
            this.CustomerIDLB1.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLB1.TabIndex = 13;
            this.CustomerIDLB1.Text = "Customer ID";
            // 
            // typeLB1
            // 
            this.typeLB1.AutoSize = true;
            this.typeLB1.Location = new System.Drawing.Point(18, 31);
            this.typeLB1.Name = "typeLB1";
            this.typeLB1.Size = new System.Drawing.Size(31, 13);
            this.typeLB1.TabIndex = 12;
            this.typeLB1.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(89, 204);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // UserIDCB1
            // 
            this.UserIDCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB1.FormattingEnabled = true;
            this.UserIDCB1.Location = new System.Drawing.Point(107, 295);
            this.UserIDCB1.Name = "UserIDCB1";
            this.UserIDCB1.Size = new System.Drawing.Size(121, 21);
            this.UserIDCB1.TabIndex = 32;
            this.UserIDCB1.SelectedIndexChanged += new System.EventHandler(this.UserIDCB1_SelectedIndexChanged);
            // 
            // CustomerIDCB1
            // 
            this.CustomerIDCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerIDCB1.FormattingEnabled = true;
            this.CustomerIDCB1.Location = new System.Drawing.Point(107, 103);
            this.CustomerIDCB1.Name = "CustomerIDCB1";
            this.CustomerIDCB1.Size = new System.Drawing.Size(121, 21);
            this.CustomerIDCB1.TabIndex = 33;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 514);
            this.Controls.Add(this.CustomerIDCB1);
            this.Controls.Add(this.UserIDCB1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveB1);
            this.Controls.Add(this.CancelB1);
            this.Controls.Add(this.nameTB1);
            this.Controls.Add(this.ScheduleTimeLB1);
            this.Controls.Add(this.UserIDLB1);
            this.Controls.Add(this.CustomerIDLB1);
            this.Controls.Add(this.typeLB1);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveB1;
        private System.Windows.Forms.Button CancelB1;
        private System.Windows.Forms.TextBox nameTB1;
        private System.Windows.Forms.Label ScheduleTimeLB1;
        private System.Windows.Forms.Label UserIDLB1;
        private System.Windows.Forms.Label CustomerIDLB1;
        private System.Windows.Forms.Label typeLB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox UserIDCB1;
        private System.Windows.Forms.ComboBox CustomerIDCB1;
    }
}