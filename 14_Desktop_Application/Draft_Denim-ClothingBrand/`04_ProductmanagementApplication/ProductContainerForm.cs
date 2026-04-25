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
    public partial class ProductContainerForm : Form
    {
        Form1 mainform;
        public ProductContainerForm(Form1 mainform)
        {
            this.mainform = mainform;
            
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainform.Show_Side_Panel();
            mainform.Load_form_in_panel(new Default_load_form(mainform));
        }
    }
}
