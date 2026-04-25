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
    public partial class SignUpSuccessMsg : Form
    {
        int rowsEffected;
        Form1 Mainform;
        Default_load_form CreateAccountForm;
        public SignUpSuccessMsg(int rowsEffected,Form1 Mainform)
        {
            InitializeComponent();
            this.rowsEffected = rowsEffected;
            this.Mainform = Mainform;
            if (this.rowsEffected > 0)
            {
                lblShowSignupMassege.Text = "Your Account has been created";
                lblshowMassegetoLogIN.Text = "Step into Draft & Denim.";
            }
            else
            {
                lblShowSignupMassege.Text = "Error While Creating Account";
                lblshowMassegetoLogIN.Text = "Try Again Some Later";
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Mainform.Load_form_in_panel(new Default_load_form(Mainform));            
        }

        private void btnSinAfterSup_Click(object sender, EventArgs e)
        {
            Mainform.Load_form_in_panel(new LoginForm(Mainform));
        }
    }
}
