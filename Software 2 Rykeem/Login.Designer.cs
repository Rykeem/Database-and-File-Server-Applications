namespace Software_2_Rykeem
{
    partial class Login
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
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.languageLB = new System.Windows.Forms.Label();
            this.langaugeTB = new System.Windows.Forms.TextBox();
            this.regionTB = new System.Windows.Forms.TextBox();
            this.regionLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(129, 89);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(100, 20);
            this.userNameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(129, 134);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // userNameLB
            // 
            this.userNameLB.AutoSize = true;
            this.userNameLB.Location = new System.Drawing.Point(62, 95);
            this.userNameLB.Name = "userNameLB";
            this.userNameLB.Size = new System.Drawing.Size(57, 13);
            this.userNameLB.TabIndex = 2;
            this.userNameLB.Text = "UserName";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(65, 140);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(53, 13);
            this.passwordLB.TabIndex = 3;
            this.passwordLB.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(129, 183);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // languageLB
            // 
            this.languageLB.AutoSize = true;
            this.languageLB.Location = new System.Drawing.Point(65, 34);
            this.languageLB.Name = "languageLB";
            this.languageLB.Size = new System.Drawing.Size(58, 13);
            this.languageLB.TabIndex = 5;
            this.languageLB.Text = "Language ";
            // 
            // langaugeTB
            // 
            this.langaugeTB.Location = new System.Drawing.Point(129, 34);
            this.langaugeTB.Name = "langaugeTB";
            this.langaugeTB.ReadOnly = true;
            this.langaugeTB.Size = new System.Drawing.Size(37, 20);
            this.langaugeTB.TabIndex = 6;
            // 
            // regionTB
            // 
            this.regionTB.Location = new System.Drawing.Point(129, 227);
            this.regionTB.Name = "regionTB";
            this.regionTB.ReadOnly = true;
            this.regionTB.Size = new System.Drawing.Size(100, 20);
            this.regionTB.TabIndex = 7;
            // 
            // regionLB
            // 
            this.regionLB.AutoSize = true;
            this.regionLB.Location = new System.Drawing.Point(65, 227);
            this.regionLB.Name = "regionLB";
            this.regionLB.Size = new System.Drawing.Size(41, 13);
            this.regionLB.TabIndex = 8;
            this.regionLB.Text = "Region";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 268);
            this.Controls.Add(this.regionLB);
            this.Controls.Add(this.regionTB);
            this.Controls.Add(this.langaugeTB);
            this.Controls.Add(this.languageLB);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordLB);
            this.Controls.Add(this.userNameLB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label userNameLB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label languageLB;
        private System.Windows.Forms.TextBox langaugeTB;
        private System.Windows.Forms.TextBox regionTB;
        private System.Windows.Forms.Label regionLB;
    }
}

