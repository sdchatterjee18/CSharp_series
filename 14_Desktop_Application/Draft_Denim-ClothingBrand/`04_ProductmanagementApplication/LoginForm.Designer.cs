namespace _04_ProductmanagementApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginGmail = new System.Windows.Forms.Label();
            this.lblSmallMsgOfLogin = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginGmail = new System.Windows.Forms.TextBox();
            this.pnlLoginSuccessMsg = new System.Windows.Forms.Panel();
            this.btnEnterShop = new System.Windows.Forms.Button();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.lblLoginS_Fmsg1 = new System.Windows.Forms.Label();
            this.lblLoginS_Fmsg = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.pnlLoginSuccessMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.txtLoginPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lblLoginGmail);
            this.panelLogin.Controls.Add(this.lblSmallMsgOfLogin);
            this.panelLogin.Controls.Add(this.lblLoginPassword);
            this.panelLogin.Controls.Add(this.txtLoginGmail);
            this.panelLogin.Location = new System.Drawing.Point(302, 111);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(322, 253);
            this.panelLogin.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(98, 126);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(208, 20);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(216, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginGmail
            // 
            this.lblLoginGmail.AutoSize = true;
            this.lblLoginGmail.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginGmail.ForeColor = System.Drawing.Color.White;
            this.lblLoginGmail.Location = new System.Drawing.Point(3, 82);
            this.lblLoginGmail.Name = "lblLoginGmail";
            this.lblLoginGmail.Size = new System.Drawing.Size(63, 27);
            this.lblLoginGmail.TabIndex = 0;
            this.lblLoginGmail.Text = "G-mail ";
            // 
            // lblSmallMsgOfLogin
            // 
            this.lblSmallMsgOfLogin.AutoSize = true;
            this.lblSmallMsgOfLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallMsgOfLogin.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallMsgOfLogin.ForeColor = System.Drawing.Color.White;
            this.lblSmallMsgOfLogin.Location = new System.Drawing.Point(3, 11);
            this.lblSmallMsgOfLogin.Name = "lblSmallMsgOfLogin";
            this.lblSmallMsgOfLogin.Size = new System.Drawing.Size(259, 27);
            this.lblSmallMsgOfLogin.TabIndex = 4;
            this.lblSmallMsgOfLogin.Text = "Enter G-mail and Password to login";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.ForeColor = System.Drawing.Color.White;
            this.lblLoginPassword.Location = new System.Drawing.Point(3, 124);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(79, 27);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtLoginGmail
            // 
            this.txtLoginGmail.Location = new System.Drawing.Point(98, 84);
            this.txtLoginGmail.Name = "txtLoginGmail";
            this.txtLoginGmail.Size = new System.Drawing.Size(208, 20);
            this.txtLoginGmail.TabIndex = 2;
            // 
            // pnlLoginSuccessMsg
            // 
            this.pnlLoginSuccessMsg.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginSuccessMsg.Controls.Add(this.btnEnterShop);
            this.pnlLoginSuccessMsg.Controls.Add(this.btnTryAgain);
            this.pnlLoginSuccessMsg.Controls.Add(this.lblLoginS_Fmsg1);
            this.pnlLoginSuccessMsg.Controls.Add(this.lblLoginS_Fmsg);
            this.pnlLoginSuccessMsg.Location = new System.Drawing.Point(302, 38);
            this.pnlLoginSuccessMsg.Name = "pnlLoginSuccessMsg";
            this.pnlLoginSuccessMsg.Size = new System.Drawing.Size(322, 280);
            this.pnlLoginSuccessMsg.TabIndex = 6;
            this.pnlLoginSuccessMsg.Visible = false;
            // 
            // btnEnterShop
            // 
            this.btnEnterShop.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterShop.Location = new System.Drawing.Point(30, 225);
            this.btnEnterShop.Name = "btnEnterShop";
            this.btnEnterShop.Size = new System.Drawing.Size(199, 53);
            this.btnEnterShop.TabIndex = 7;
            this.btnEnterShop.Text = "Let\'s Enter the style zone";
            this.btnEnterShop.UseVisualStyleBackColor = true;
            this.btnEnterShop.Visible = false;
            this.btnEnterShop.Click += new System.EventHandler(this.btnEnterShop_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(196, 198);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(109, 37);
            this.btnTryAgain.TabIndex = 6;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            this.btnTryAgain.Visible = false;
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // lblLoginS_Fmsg1
            // 
            this.lblLoginS_Fmsg1.AutoSize = true;
            this.lblLoginS_Fmsg1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginS_Fmsg1.ForeColor = System.Drawing.Color.White;
            this.lblLoginS_Fmsg1.Location = new System.Drawing.Point(10, 99);
            this.lblLoginS_Fmsg1.Name = "lblLoginS_Fmsg1";
            this.lblLoginS_Fmsg1.Size = new System.Drawing.Size(72, 16);
            this.lblLoginS_Fmsg1.TabIndex = 1;
            this.lblLoginS_Fmsg1.Text = "Waiting";
            this.lblLoginS_Fmsg1.Click += new System.EventHandler(this.lblLoginS_Fmsg1_Click);
            // 
            // lblLoginS_Fmsg
            // 
            this.lblLoginS_Fmsg.AutoSize = true;
            this.lblLoginS_Fmsg.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginS_Fmsg.ForeColor = System.Drawing.Color.White;
            this.lblLoginS_Fmsg.Location = new System.Drawing.Point(10, 133);
            this.lblLoginS_Fmsg.Name = "lblLoginS_Fmsg";
            this.lblLoginS_Fmsg.Size = new System.Drawing.Size(72, 16);
            this.lblLoginS_Fmsg.TabIndex = 0;
            this.lblLoginS_Fmsg.Text = "Waiting";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(598, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(39, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 434);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlLoginSuccessMsg);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.pnlLoginSuccessMsg.ResumeLayout(false);
            this.pnlLoginSuccessMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginGmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginGmail;
        private System.Windows.Forms.Label lblSmallMsgOfLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLoginSuccessMsg;
        private System.Windows.Forms.Label lblLoginS_Fmsg;
        private System.Windows.Forms.Label lblLoginS_Fmsg1;
        private System.Windows.Forms.Button btnTryAgain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEnterShop;
    }
}