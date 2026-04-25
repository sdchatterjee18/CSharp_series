using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04_ProductmanagementApplication
{
    public partial class LoginForm : Form
    {
        Form1 mainform;
        //Default_load_form Defaultform1;
        public LoginForm(Form1 mainform)
        {
            this.mainform = mainform;
            //this.Defaultform1 = def;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLoginSuccessMsg.Visible = true;
            if (Authentication.LoginCustomer(this.txtLoginGmail.Text, this.txtLoginPassword.Text))
            {
                Customer customer=Customer.GetDetails(this.txtLoginGmail.Text);
                if (customer != null)
                {
                    panelLogin.Visible = false;
                    pnlLoginSuccessMsg.Visible = true;
                    lblLoginS_Fmsg1.Text = "Welcome  "+customer.CustomerFirstName ;
                    lblLoginS_Fmsg.Text = "Let’s continue your style journey";
                    lblLoginS_Fmsg1.ForeColor = Color.Green;
                    lblLoginS_Fmsg.ForeColor = Color.Green;
                    btnEnterShop.Visible = true;
                }
                else
                {
                    panelLogin.Visible = false;
                    pnlLoginSuccessMsg.Visible = true;
                    lblLoginS_Fmsg1.Text = "Something Wrong Happened..";
                    lblLoginS_Fmsg.Text = "Try Again";
                    lblLoginS_Fmsg.ForeColor = Color.Red;
                    lblLoginS_Fmsg1.ForeColor = Color.Red;
                    btnTryAgain.Visible = true;
                    
                }
            }
            else
            {
                panelLogin.Visible = false;
                pnlLoginSuccessMsg.Visible = true;
                lblLoginS_Fmsg1.Text = "Account Not Found!";
                lblLoginS_Fmsg.Text = "Try Again";
                lblLoginS_Fmsg1.ForeColor = Color.Red;
                lblLoginS_Fmsg.ForeColor = Color.Red;
                btnTryAgain.Visible = true;
            }
        }

        private void lblLoginS_Fmsg1_Click(object sender, EventArgs e)
        {

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            pnlLoginSuccessMsg.Visible = false;
            btnTryAgain.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Load_form_in_panel(new Default_load_form(mainform));
        }

        private void btnEnterShop_Click(object sender, EventArgs e)
        {
            mainform.Load_Product_form(new ProductContainerForm(mainform));
        }

    }
}
