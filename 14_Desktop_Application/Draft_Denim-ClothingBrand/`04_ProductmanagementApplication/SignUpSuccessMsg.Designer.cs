namespace _04_ProductmanagementApplication
{
    partial class SignUpSuccessMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpSuccessMsg));
            this.panelMassegeSignUpSuccess = new System.Windows.Forms.Panel();
            this.lblshowMassegetoLogIN = new System.Windows.Forms.Label();
            this.btnSinAfterSup = new System.Windows.Forms.Button();
            this.lblShowSignupMassege = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMassegeSignUpSuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMassegeSignUpSuccess
            // 
            this.panelMassegeSignUpSuccess.BackColor = System.Drawing.Color.Transparent;
            this.panelMassegeSignUpSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMassegeSignUpSuccess.Controls.Add(this.lblshowMassegetoLogIN);
            this.panelMassegeSignUpSuccess.Controls.Add(this.btnSinAfterSup);
            this.panelMassegeSignUpSuccess.Controls.Add(this.lblShowSignupMassege);
            this.panelMassegeSignUpSuccess.Location = new System.Drawing.Point(188, 42);
            this.panelMassegeSignUpSuccess.Name = "panelMassegeSignUpSuccess";
            this.panelMassegeSignUpSuccess.Size = new System.Drawing.Size(260, 350);
            this.panelMassegeSignUpSuccess.TabIndex = 0;
            // 
            // lblshowMassegetoLogIN
            // 
            this.lblshowMassegetoLogIN.AutoSize = true;
            this.lblshowMassegetoLogIN.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowMassegetoLogIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblshowMassegetoLogIN.Location = new System.Drawing.Point(3, 141);
            this.lblshowMassegetoLogIN.Name = "lblshowMassegetoLogIN";
            this.lblshowMassegetoLogIN.Size = new System.Drawing.Size(44, 18);
            this.lblshowMassegetoLogIN.TabIndex = 2;
            this.lblshowMassegetoLogIN.Text = "Wait";
            // 
            // btnSinAfterSup
            // 
            this.btnSinAfterSup.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSinAfterSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinAfterSup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSinAfterSup.Location = new System.Drawing.Point(159, 246);
            this.btnSinAfterSup.Name = "btnSinAfterSup";
            this.btnSinAfterSup.Size = new System.Drawing.Size(75, 23);
            this.btnSinAfterSup.TabIndex = 1;
            this.btnSinAfterSup.Text = "Sign In";
            this.btnSinAfterSup.UseVisualStyleBackColor = false;
            this.btnSinAfterSup.Click += new System.EventHandler(this.btnSinAfterSup_Click);
            // 
            // lblShowSignupMassege
            // 
            this.lblShowSignupMassege.AutoSize = true;
            this.lblShowSignupMassege.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSignupMassege.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowSignupMassege.Location = new System.Drawing.Point(3, 106);
            this.lblShowSignupMassege.Name = "lblShowSignupMassege";
            this.lblShowSignupMassege.Size = new System.Drawing.Size(44, 18);
            this.lblShowSignupMassege.TabIndex = 0;
            this.lblShowSignupMassege.Text = "Wait";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(596, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SignUpSuccessMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 434);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMassegeSignUpSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpSuccessMsg";
            this.Text = "SignUpSuccessMsg";
            this.panelMassegeSignUpSuccess.ResumeLayout(false);
            this.panelMassegeSignUpSuccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMassegeSignUpSuccess;
        private System.Windows.Forms.Label lblShowSignupMassege;
        private System.Windows.Forms.Button btnSinAfterSup;
        private System.Windows.Forms.Label lblshowMassegetoLogIN;
        private System.Windows.Forms.Button btnBack;
    }
}