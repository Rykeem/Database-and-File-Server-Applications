namespace Software_2_Rykeem
{
    partial class ModifyAppointment
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
            this.CustomerIDCB1 = new System.Windows.Forms.ComboBox();
            this.UserIDCB1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveB1 = new System.Windows.Forms.Button();
            this.CancelB1 = new System.Windows.Forms.Button();
            this.nameTB1 = new System.Windows.Forms.TextBox();
            this.ScheduleTimeLB1 = new System.Windows.Forms.Label();
            this.UserIDLB1 = new System.Windows.Forms.Label();
            this.CustomerIDLB1 = new System.Windows.Forms.Label();
            this.typeLB1 = new System.Windows.Forms.Label();
            this.AppointmentIDTB = new System.Windows.Forms.TextBox();
            this.AppointmentIDLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerIDCB1
            // 
            this.CustomerIDCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerIDCB1.FormattingEnabled = true;
            this.CustomerIDCB1.Location = new System.Drawing.Point(104, 133);
            this.CustomerIDCB1.Name = "CustomerIDCB1";
            this.CustomerIDCB1.Size = new System.Drawing.Size(121, 21);
            this.CustomerIDCB1.TabIndex = 45;
            // 
            // UserIDCB1
            // 
            this.UserIDCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB1.FormattingEnabled = true;
            this.UserIDCB1.Location = new System.Drawing.Point(104, 325);
            this.UserIDCB1.Name = "UserIDCB1";
            this.UserIDCB1.Size = new System.Drawing.Size(121, 21);
            this.UserIDCB1.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(86, 234);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "End Time";
            // 
            // SaveB1
            // 
            this.SaveB1.Location = new System.Drawing.Point(257, 490);
            this.SaveB1.Name = "SaveB1";
            this.SaveB1.Size = new System.Drawing.Size(75, 23);
            this.SaveB1.TabIndex = 40;
            this.SaveB1.Text = "Save";
            this.SaveB1.UseVisualStyleBackColor = true;
            this.SaveB1.Click += new System.EventHandler(this.SaveB1_Click);
            // 
            // CancelB1
            // 
            this.CancelB1.Location = new System.Drawing.Point(150, 490);
            this.CancelB1.Name = "CancelB1";
            this.CancelB1.Size = new System.Drawing.Size(75, 23);
            this.CancelB1.TabIndex = 39;
            this.CancelB1.Text = "Cancel";
            this.CancelB1.UseVisualStyleBackColor = true;
            this.CancelB1.Click += new System.EventHandler(this.CancelB1_Click);
            // 
            // nameTB1
            // 
            this.nameTB1.Location = new System.Drawing.Point(104, 61);
            this.nameTB1.Name = "nameTB1";
            this.nameTB1.Size = new System.Drawing.Size(121, 20);
            this.nameTB1.TabIndex = 38;
            // 
            // ScheduleTimeLB1
            // 
            this.ScheduleTimeLB1.AutoSize = true;
            this.ScheduleTimeLB1.Location = new System.Drawing.Point(15, 215);
            this.ScheduleTimeLB1.Name = "ScheduleTimeLB1";
            this.ScheduleTimeLB1.Size = new System.Drawing.Size(55, 13);
            this.ScheduleTimeLB1.TabIndex = 37;
            this.ScheduleTimeLB1.Text = "Start Time";
            // 
            // UserIDLB1
            // 
            this.UserIDLB1.AutoSize = true;
            this.UserIDLB1.Location = new System.Drawing.Point(15, 325);
            this.UserIDLB1.Name = "UserIDLB1";
            this.UserIDLB1.Size = new System.Drawing.Size(43, 13);
            this.UserIDLB1.TabIndex = 36;
            this.UserIDLB1.Text = "User ID";
            // 
            // CustomerIDLB1
            // 
            this.CustomerIDLB1.AutoSize = true;
            this.CustomerIDLB1.Location = new System.Drawing.Point(15, 136);
            this.CustomerIDLB1.Name = "CustomerIDLB1";
            this.CustomerIDLB1.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLB1.TabIndex = 35;
            this.CustomerIDLB1.Text = "Customer ID";
            // 
            // typeLB1
            // 
            this.typeLB1.AutoSize = true;
            this.typeLB1.Location = new System.Drawing.Point(15, 61);
            this.typeLB1.Name = "typeLB1";
            this.typeLB1.Size = new System.Drawing.Size(31, 13);
            this.typeLB1.TabIndex = 34;
            this.typeLB1.Text = "Type";
            // 
            // AppointmentIDTB
            // 
            this.AppointmentIDTB.Location = new System.Drawing.Point(104, 26);
            this.AppointmentIDTB.Name = "AppointmentIDTB";
            this.AppointmentIDTB.ReadOnly = true;
            this.AppointmentIDTB.Size = new System.Drawing.Size(121, 20);
            this.AppointmentIDTB.TabIndex = 47;
            // 
            // AppointmentIDLB
            // 
            this.AppointmentIDLB.AutoSize = true;
            this.AppointmentIDLB.Location = new System.Drawing.Point(15, 26);
            this.AppointmentIDLB.Name = "AppointmentIDLB";
            this.AppointmentIDLB.Size = new System.Drawing.Size(80, 13);
            this.AppointmentIDLB.TabIndex = 46;
            this.AppointmentIDLB.Text = "Appointment ID";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 514);
            this.Controls.Add(this.AppointmentIDTB);
            this.Controls.Add(this.AppointmentIDLB);
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
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerIDCB1;
        private System.Windows.Forms.ComboBox UserIDCB1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveB1;
        private System.Windows.Forms.Button CancelB1;
        private System.Windows.Forms.TextBox nameTB1;
        private System.Windows.Forms.Label ScheduleTimeLB1;
        private System.Windows.Forms.Label UserIDLB1;
        private System.Windows.Forms.Label CustomerIDLB1;
        private System.Windows.Forms.Label typeLB1;
        private System.Windows.Forms.TextBox AppointmentIDTB;
        private System.Windows.Forms.Label AppointmentIDLB;
    }
}