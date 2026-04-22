namespace _04_ProductmanagementApplication
{
    partial class SignUpForm
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
            this.panelSignupDetails = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerGmail = new System.Windows.Forms.Label();
            this.txtCustomerGmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.panelSignupDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignupDetails
            // 
            this.panelSignupDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelSignupDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSignupDetails.Controls.Add(this.btnSignup);
            this.panelSignupDetails.Controls.Add(this.label1);
            this.panelSignupDetails.Controls.Add(this.txtConfirmPassword);
            this.panelSignupDetails.Controls.Add(this.lblConfirmPassword);
            this.panelSignupDetails.Controls.Add(this.txtPassword);
            this.panelSignupDetails.Controls.Add(this.lblPassword);
            this.panelSignupDetails.Controls.Add(this.txtUserName);
            this.panelSignupDetails.Controls.Add(this.lblUserName);
            this.panelSignupDetails.Controls.Add(this.txtCustomerGmail);
            this.panelSignupDetails.Controls.Add(this.lblCustomerGmail);
            this.panelSignupDetails.Controls.Add(this.txtCustomerName);
            this.panelSignupDetails.Controls.Add(this.lblCustomerName);
            this.panelSignupDetails.Location = new System.Drawing.Point(40, 27);
            this.panelSignupDetails.Name = "panelSignupDetails";
            this.panelSignupDetails.Size = new System.Drawing.Size(325, 380);
            this.panelSignupDetails.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Silver;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(19, 32);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(2);
            this.lblCustomerName.Size = new System.Drawing.Size(55, 22);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerName.Location = new System.Drawing.Point(98, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(203, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerGmail
            // 
            this.lblCustomerGmail.AutoSize = true;
            this.lblCustomerGmail.BackColor = System.Drawing.Color.Silver;
            this.lblCustomerGmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerGmail.Location = new System.Drawing.Point(19, 76);
            this.lblCustomerGmail.Name = "lblCustomerGmail";
            this.lblCustomerGmail.Padding = new System.Windows.Forms.Padding(2);
            this.lblCustomerGmail.Size = new System.Drawing.Size(61, 22);
            this.lblCustomerGmail.TabIndex = 2;
            this.lblCustomerGmail.Text = "G-mail";
            // 
            // txtCustomerGmail
            // 
            this.txtCustomerGmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerGmail.Location = new System.Drawing.Point(98, 77);
            this.txtCustomerGmail.Name = "txtCustomerGmail";
            this.txtCustomerGmail.Size = new System.Drawing.Size(203, 20);
            this.txtCustomerGmail.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Silver;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(19, 121);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(2);
            this.lblUserName.Size = new System.Drawing.Size(201, 22);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Generate your UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(98, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 27);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "Create Username Here ";
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Silver;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(19, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(2);
            this.lblPassword.Size = new System.Drawing.Size(158, 22);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Generate Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(98, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConfirmPassword.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(98, 284);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(203, 27);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.Text = "Match the Password";
            this.txtConfirmPassword.Click += new System.EventHandler(this.txtConfirmPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Silver;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(19, 259);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Padding = new System.Windows.Forms.Padding(2);
            this.lblConfirmPassword.Size = new System.Drawing.Size(148, 22);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 338);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Complete all the fields";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(181, 334);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(106, 26);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_04_ProductmanagementApplication.Properties.Resources.resized_signup_background;
            this.ClientSize = new System.Drawing.Size(636, 434);
            this.Controls.Add(this.panelSignupDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.panelSignupDetails.ResumeLayout(false);
            this.panelSignupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSignupDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerGmail;
        private System.Windows.Forms.Label lblCustomerGmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSignup;

    }
}