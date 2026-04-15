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
        private int PIN;
        public void AssignAccountDetails(int Acc,int Pin,int C_ID)
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
                Console.WriteLine(ex.Message);
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
        public int? GetAccountNoForTransactions(int C_ID)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("GetAccountNoByCustomerID", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", C_ID);
                sqlConnection.Open();
                AccountNo = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return AccountNo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public double? GetBalanceByAccountNo(int AccountNo)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            Balance = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("GetBankBalanceByCustomerID", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountNo",AccountNo);
                sqlConnection.Open();
                Balance =Convert.ToInt32(sqlCommand.ExecuteScalar());
                return Balance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public double? DepositAmountUsingAccountNo(int AccountNo,double Balance,double Deposit)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            Balance = Balance+Deposit;
            try
            {

                
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spDepositBalanceThroughAccountNo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountNo",AccountNo);
                sqlCommand.Parameters.AddWithValue("@Balance", Balance);
                sqlConnection.Open();
                Balance = Convert.ToDouble(sqlCommand.ExecuteScalar());
                return Balance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public double? WithdrawAmountUsingAccountNo(int AccountNo, double Balance, double Withdraw)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            Balance = Balance - Withdraw;
            try
            {


                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spDepositBalanceThroughAccountNo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountNo", AccountNo);
                sqlCommand.Parameters.AddWithValue("@Balance", Balance);
                sqlConnection.Open();
                Balance = Convert.ToDouble(sqlCommand.ExecuteScalar());
                return Balance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public double? WithdrawAmountValidate(double balance)
        {
            Console.WriteLine("Enter the Amount of withdraw :");
            double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (WithdrawAmount > balance)
            {
                Console.WriteLine("Insufficient Balance");
                return null;
            }
            else if (WithdrawAmount < 0)
            {
                Console.WriteLine("Negative withdraw not possible");
                return null;
            }
            else
            {
                return WithdrawAmount;
            }
        }
        public double? DepositAmountValidate()
        {
            Console.WriteLine("Enter Amount of Deposit :");
            double deposit = Convert.ToDouble(Console.ReadLine());
            if (deposit > 0)
            {
                return deposit;
            }
            else
            {
                return null;
            }
        }
    }
}
