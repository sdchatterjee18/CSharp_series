using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace OnlineBanking
{
    class Account
    {
        public int CustomerID { get; private set; }
        public int AccountNo { get;  private set; }
        private double Balance;
        private string PIN;
        public void AssignAccountDetails(int Acc,string Pin,int C_ID)
        {
            CustomerID = C_ID;
            PIN = Pin;
            AccountNo = Acc;
            Balance = 0;
        }
        public int InsertAccountDetails()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int rowsEffected = 0;
            try
            {

                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spInsertIntoAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                sqlCommand.Parameters.AddWithValue("@AccountNo", this.AccountNo);
                sqlCommand.Parameters.AddWithValue("@Balance", this.Balance);
                sqlCommand.Parameters.AddWithValue("@PIN", this.PIN);
                sqlConnection.Open();
                rowsEffected = sqlCommand.ExecuteNonQuery();
                return rowsEffected;
            }
            catch(Exception ex)
            {
                return rowsEffected;
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
