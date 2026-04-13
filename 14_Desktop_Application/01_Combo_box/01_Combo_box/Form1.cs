using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace _01_Combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public List<string> GetNames()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<string> States = null;
            SqlConnection SqlConnection = null;
            try
            {
                SqlConnection = new SqlConnection(CS);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetAllStates", SqlConnection))
                {
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    DataRowCollection dataRowCollection = dataTable.Rows;
                    States = new List<string>();
                    foreach (DataRow dataRow in dataRowCollection)
                    {
                        States.Add(dataRow["StateName"].ToString());
                    }
                }
                return States;
            }
            catch (Exception ex)
            {
                return States;
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> AllStates = new List<string>();
            AllStates = GetNames();
            foreach (string states in AllStates)
            {
                comboBox1.Items.Add(states);
            }
        }
    }
}
