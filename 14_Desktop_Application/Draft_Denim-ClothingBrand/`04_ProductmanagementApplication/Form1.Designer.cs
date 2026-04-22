namespace _04_ProductmanagementApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainForm_UpperPanel = new System.Windows.Forms.Panel();
            this.lblbrandName1 = new System.Windows.Forms.Label();
            this.MainForm_MainPanel = new System.Windows.Forms.Panel();
            this.panelSigninAndUp = new System.Windows.Forms.Panel();
            this.lblEndMassege = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.lblSignupMsg = new System.Windows.Forms.Label();
            this.lalNewhereMsg = new System.Windows.Forms.Label();
            this.lblBrandName2 = new System.Windows.Forms.Label();
            this.lblSignupWelcome = new System.Windows.Forms.Label();
            this.MainForm_SidePanel = new System.Windows.Forms.Panel();
            this.MainForm_UpperPanel.SuspendLayout();
            this.MainForm_MainPanel.SuspendLayout();
            this.panelSigninAndUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_UpperPanel
            // 
            this.MainForm_UpperPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainForm_UpperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_UpperPanel.Controls.Add(this.lblbrandName1);
            this.MainForm_UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainForm_UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.MainForm_UpperPanel.Name = "MainForm_UpperPanel";
            this.MainForm_UpperPanel.Size = new System.Drawing.Size(834, 47);
            this.MainForm_UpperPanel.TabIndex = 1;
            // 
            // lblbrandName1
            // 
            this.lblbrandName1.AutoSize = true;
            this.lblbrandName1.BackColor = System.Drawing.Color.Transparent;
            this.lblbrandName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbrandName1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbrandName1.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrandName1.Location = new System.Drawing.Point(0, 2);
            this.lblbrandName1.Name = "lblbrandName1";
            this.lblbrandName1.Padding = new System.Windows.Forms.Padding(5);
            this.lblbrandName1.Size = new System.Drawing.Size(147, 40);
            this.lblbrandName1.TabIndex = 0;
            this.lblbrandName1.Text = "Draft&Denim";
            // 
            // MainForm_MainPanel
            // 
            this.MainForm_MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainForm_MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainForm_MainPanel.BackgroundImage")));
            this.MainForm_MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_MainPanel.Controls.Add(this.panelSigninAndUp);
            this.MainForm_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_MainPanel.Location = new System.Drawing.Point(198, 47);
            this.MainForm_MainPanel.Name = "MainForm_MainPanel";
            this.MainForm_MainPanel.Size = new System.Drawing.Size(636, 434);
            this.MainForm_MainPanel.TabIndex = 2;
            // 
            // panelSigninAndUp
            // 
            this.panelSigninAndUp.BackColor = System.Drawing.Color.Transparent;
            this.panelSigninAndUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSigninAndUp.Controls.Add(this.lblEndMassege);
            this.panelSigninAndUp.Controls.Add(this.btnCreateAcc);
            this.panelSigninAndUp.Controls.Add(this.lblSignupMsg);
            this.panelSigninAndUp.Controls.Add(this.lalNewhereMsg);
            this.panelSigninAndUp.Controls.Add(this.lblBrandName2);
            this.panelSigninAndUp.Controls.Add(this.lblSignupWelcome);
            this.panelSigninAndUp.Location = new System.Drawing.Point(179, 44);
            this.panelSigninAndUp.Name = "panelSigninAndUp";
            this.panelSigninAndUp.Size = new System.Drawing.Size(260, 350);
            this.panelSigninAndUp.TabIndex = 0;
            // 
            // lblEndMassege
            // 
            this.lblEndMassege.AutoSize = true;
            this.lblEndMassege.BackColor = System.Drawing.Color.LightGray;
            this.lblEndMassege.Font = new System.Drawing.Font("Playbill", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndMassege.Location = new System.Drawing.Point(0, 326);
            this.lblEndMassege.Name = "lblEndMassege";
            this.lblEndMassege.Size = new System.Drawing.Size(256, 21);
            this.lblEndMassege.TabIndex = 5;
            this.lblEndMassege.Text = "Hurry up! to join the waitlist for the first drop.";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.Gray;
            this.btnCreateAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.Location = new System.Drawing.Point(113, 248);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(120, 33);
            this.btnCreateAcc.TabIndex = 4;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // lblSignupMsg
            // 
            this.lblSignupMsg.AutoSize = true;
            this.lblSignupMsg.Font = new System.Drawing.Font("HP Simplified Hans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignupMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSignupMsg.Location = new System.Drawing.Point(2, 214);
            this.lblSignupMsg.Name = "lblSignupMsg";
            this.lblSignupMsg.Size = new System.Drawing.Size(249, 14);
            this.lblSignupMsg.TabIndex = 3;
            this.lblSignupMsg.Text = "Create an account to draft your first look...";
            // 
            // lalNewhereMsg
            // 
            this.lalNewhereMsg.AutoSize = true;
            this.lalNewhereMsg.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNewhereMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lalNewhereMsg.Location = new System.Drawing.Point(2, 194);
            this.lalNewhereMsg.Name = "lalNewhereMsg";
            this.lalNewhereMsg.Size = new System.Drawing.Size(98, 16);
            this.lalNewhereMsg.TabIndex = 2;
            this.lalNewhereMsg.Text = "New here?";
            // 
            // lblBrandName2
            // 
            this.lblBrandName2.AutoSize = true;
            this.lblBrandName2.BackColor = System.Drawing.Color.DimGray;
            this.lblBrandName2.Font = new System.Drawing.Font("Old English Text MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBrandName2.Location = new System.Drawing.Point(125, 28);
            this.lblBrandName2.Name = "lblBrandName2";
            this.lblBrandName2.Size = new System.Drawing.Size(135, 28);
            this.lblBrandName2.TabIndex = 1;
            this.lblBrandName2.Text = "Draft&Denim";
            // 
            // lblSignupWelcome
            // 
            this.lblSignupWelcome.AutoSize = true;
            this.lblSignupWelcome.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSignupWelcome.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignupWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblSignupWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblSignupWelcome.Name = "lblSignupWelcome";
            this.lblSignupWelcome.Size = new System.Drawing.Size(125, 28);
            this.lblSignupWelcome.TabIndex = 0;
            this.lblSignupWelcome.Text = "Welcome to";
            // 
            // MainForm_SidePanel
            // 
            this.MainForm_SidePanel.BackColor = System.Drawing.Color.White;
            this.MainForm_SidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainForm_SidePanel.BackgroundImage")));
            this.MainForm_SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainForm_SidePanel.Location = new System.Drawing.Point(0, 47);
            this.MainForm_SidePanel.Name = "MainForm_SidePanel";
            this.MainForm_SidePanel.Size = new System.Drawing.Size(198, 434);
            this.MainForm_SidePanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.MainForm_MainPanel);
            this.Controls.Add(this.MainForm_SidePanel);
            this.Controls.Add(this.MainForm_UpperPanel);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.MainForm_UpperPanel.ResumeLayout(false);
            this.MainForm_UpperPanel.PerformLayout();
            this.MainForm_MainPanel.ResumeLayout(false);
            this.panelSigninAndUp.ResumeLayout(false);
            this.panelSigninAndUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm_SidePanel;
        private System.Windows.Forms.Panel MainForm_UpperPanel;
        private System.Windows.Forms.Panel MainForm_MainPanel;
        private System.Windows.Forms.Label lblbrandName1;
        private System.Windows.Forms.Panel panelSigninAndUp;
        private System.Windows.Forms.Label lalNewhereMsg;
        private System.Windows.Forms.Label lblBrandName2;
        private System.Windows.Forms.Label lblSignupWelcome;
        private System.Windows.Forms.Label lblEndMassege;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label lblSignupMsg;
    }
}

