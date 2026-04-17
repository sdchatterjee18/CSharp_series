using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _02_Basic_registrationForm
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
        private List<string> GetAllNames()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            List<string> States = null;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStateNames",sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    DataRowCollection dataRowCollection = dataTable.Rows;
                    States = new List<string>();
                    foreach (DataRow row in dataRowCollection)
                    {
                        States.Add(row["State_Name"].ToString());
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
                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> States = GetAllNames();
            if (States != null)
            {
                foreach(string state in States)
                {
                    comboBox1.Items.Add(state);
                }
            }
            else
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                int rowseffected=InsertDetailsIntoTable();
                if(rowseffected!=0)
                {
                    lblMassege.Text = "Registration Successfull";
                    lblMassege.ForeColor = Color.Green;
                    lblMassege.BackColor = Color.RosyBrown;
                }
                else
                {
                    lblMassege.Text = "Registration failed !! try again...";
                    lblMassege.ForeColor = Color.Red;
                    lblMassege.BackColor = Color.RosyBrown;
                }
            }
            else
            {
                lblMassege.Text = "Please match confirm password!!";
                lblMassege.ForeColor = Color.Red;
                lblMassege.BackColor = Color.RosyBrown;
            }
        }
        private int InsertDetailsIntoTable()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int RowsEffected = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spInsertDetailsIntoStudentTable", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Student_Name", this.txtname.Text);
                    sqlCommand.Parameters.AddWithValue("@State", this.comboBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", this.txtPassword.Text);
                    sqlConnection.Open();
                    RowsEffected = sqlCommand.ExecuteNonQuery();
                }
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
