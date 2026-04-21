using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03_Learning_DesignOfWindowsFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadFormInPanel(object childForm)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                mainpanel.Controls.Clear();
            }
            Form f = (Form)childForm;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(f);
            mainpanel.Tag = f;
            f.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new EmployeeForm());
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new dashboard());
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new report());
        }
    }
}
