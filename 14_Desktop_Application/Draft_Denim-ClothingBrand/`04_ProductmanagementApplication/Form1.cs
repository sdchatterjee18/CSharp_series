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
        public void Load_form_in_panel(Form f)
        {
            MainForm_MainPanel.Dock = DockStyle.Fill;
            if (this.MainForm_MainPanel.Controls.Count > 0)
            {
                this.MainForm_MainPanel.Controls.Clear();
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainForm_MainPanel.Controls.Add(f);
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_form_in_panel(new Default_load_form(this));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Load_form_in_panel(new LoginForm(this));
        }
        public void Load_Product_form(Form f)
        {
            MainForm_SidePanel.Visible = false;
            MainForm_MainPanel.Controls.Clear();
            MainForm_MainPanel.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainForm_MainPanel.Controls.Add(f);
            f.Show();
        }
        public void Show_Side_Panel()
        {
            MainForm_SidePanel.Visible = true;
        }
    }
}
