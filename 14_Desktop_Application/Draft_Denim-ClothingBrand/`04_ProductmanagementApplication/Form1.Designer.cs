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
            this.MainForm_SidePanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.MainForm_UpperPanel.SuspendLayout();
            this.MainForm_SidePanel.SuspendLayout();
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
            this.MainForm_MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_MainPanel.Location = new System.Drawing.Point(198, 47);
            this.MainForm_MainPanel.Name = "MainForm_MainPanel";
            this.MainForm_MainPanel.Size = new System.Drawing.Size(636, 434);
            this.MainForm_MainPanel.TabIndex = 2;
            // 
            // MainForm_SidePanel
            // 
            this.MainForm_SidePanel.BackColor = System.Drawing.Color.White;
            this.MainForm_SidePanel.BackgroundImage = global::_04_ProductmanagementApplication.Properties.Resources.final_sidebar;
            this.MainForm_SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainForm_SidePanel.Controls.Add(this.btnLogin);
            this.MainForm_SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainForm_SidePanel.Location = new System.Drawing.Point(0, 47);
            this.MainForm_SidePanel.Name = "MainForm_SidePanel";
            this.MainForm_SidePanel.Size = new System.Drawing.Size(198, 434);
            this.MainForm_SidePanel.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(19, 129);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(156, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainForm_UpperPanel.ResumeLayout(false);
            this.MainForm_UpperPanel.PerformLayout();
            this.MainForm_SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm_SidePanel;
        private System.Windows.Forms.Panel MainForm_UpperPanel;
        private System.Windows.Forms.Panel MainForm_MainPanel;
        private System.Windows.Forms.Label lblbrandName1;
        private System.Windows.Forms.Button btnLogin;
    }
}

