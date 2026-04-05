using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    class Authentication
    {
        private static int PIN;
        public static string PinGeneration()
        {
            const int pinLength = 6;
            while (true)
            {
                PIN =Convert.ToInt32(CheckDigit());
                string pin = Convert.ToString(PIN);
                if (pin.Length == pinLength)
                {
                    return pin;
                }
                else
                {
                    Console.WriteLine("SomeThing went Wrong!!PIN must be 6 Digits");
                }
            }
        }
        public static bool Login(int C_ID,string pass)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            bool IsExists = false;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spLoginExistingAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", C_ID);
                sqlCommand.Parameters.AddWithValue("@Password", pass);
                sqlConnection.Open();
                IsExists = Convert.ToBoolean(sqlCommand.ExecuteScalar ());
                return IsExists;
            }
            catch (Exception ex)
            {
                return IsExists;
            }
            finally
            {
                if (sqlConnection != null)
                sqlConnection.Close();
            }
        }
        public static string CheckDigit()
        {
            while(true)
            {
                string digit =Console.ReadLine();
                if (digit.All(char.IsDigit))
                {
                    return digit;
                }
                else
                {
                    Console.WriteLine("Please Enter Digits");
                }
            }
            
        }
        public static bool CheckPinForTransactions(int PIN, int Account_no)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            bool IsExists = false;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spVarifyPin", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@AccountNo", Account_no);
                sqlCommand.Parameters.AddWithValue("@pin", PIN);
                sqlConnection.Open();
                IsExists = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                return IsExists;
            }
            catch (Exception ex)
            {
                return IsExists;
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
    }
}
