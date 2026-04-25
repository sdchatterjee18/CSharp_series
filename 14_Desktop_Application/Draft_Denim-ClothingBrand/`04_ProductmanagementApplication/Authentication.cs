using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _04_ProductmanagementApplication
{
    class Authentication
    {
        public static bool LoginCustomer(string G_mail, string Password)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            bool isExist = false;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spLoginCustomerByGmailAndPassword", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Gmail", G_mail);
                    sqlCommand.Parameters.AddWithValue("@Password",Password);
                    sqlConnection.Open();
                    isExist = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                    return isExist;
                }
            }
            catch (Exception ex)
            {
                return isExist;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
