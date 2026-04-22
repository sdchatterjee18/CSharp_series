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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Load_Sign_Up_form(Form f)
        {
            if (this.MainForm_MainPanel.Controls.Count > 0)
            {
                this.MainForm_MainPanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainForm_MainPanel.Controls.Add(f);
            f.Show();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Load_Sign_Up_form(new SignUpForm());
        }

    }
}
