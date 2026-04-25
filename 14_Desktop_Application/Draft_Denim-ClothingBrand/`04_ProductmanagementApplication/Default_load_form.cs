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
    public partial class Default_load_form : Form
    {
        private Form1 mainform;
        public Default_load_form(Form1 M_form)
        {
            InitializeComponent();
            mainform = M_form;
        }
        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            mainform.Load_form_in_panel(new SignUpForm(mainform));
        }     
    }
}
