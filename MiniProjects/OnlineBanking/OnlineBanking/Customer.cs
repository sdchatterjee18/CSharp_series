using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    class Customer
    {
        public int CustomerID { get; private set; }
        public string CustomerName { get; private set; }
        private string Password;

        public void InsertDetails(string Name, string Pass)
        {
            this.CustomerName = Name;
            this.Password = Pass;
        }
        public int InsertIntoCustomer()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int C_ID = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spCreateAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerName", this.CustomerName);
                sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                sqlConnection.Open();
                C_ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                CustomerID = C_ID;
                return CustomerID;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return C_ID;
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        public string GetNameOfCustomer(int C_ID)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection =null;
            string CustomerName = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("GetNameOfCustomer", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", C_ID);
                sqlConnection.Open();
                this.CustomerName=Convert.ToString(sqlCommand.ExecuteScalar());
                return this.CustomerName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return CustomerName;
                
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
