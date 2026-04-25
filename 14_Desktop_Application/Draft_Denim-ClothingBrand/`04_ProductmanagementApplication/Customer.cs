using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _04_ProductmanagementApplication
{
    class Customer
    {
        public int CustomerId {  get; private set; }
        public string CustomerFirstName {  get; private set; }
        public string CustomerSecondName { get; private set; }
        public string G_mail {  get; private set; }
        public string UserName {  get; private set; }
        public string Password {  get; private set; }

        public Customer(string F_Name, string S_Name, string G_Mail, string UserName, string Password)
        {
            this.CustomerFirstName = F_Name;
            this.CustomerSecondName = S_Name;
            this.G_mail = G_Mail;
            this.UserName = UserName;
            this.Password = Password;
        }
        public Customer()
        {

        }
        public int InsertDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int rowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlCommand sqlCommand = new SqlCommand("spInsertDeatilsIntoCustomerTable", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@FirstName",this.CustomerFirstName);
                    sqlCommand.Parameters.AddWithValue("@SecondName", this.CustomerSecondName);
                    sqlCommand.Parameters.AddWithValue("@G_mail", this.G_mail);
                    sqlCommand.Parameters.AddWithValue("@UserName", this.UserName);
                    sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                    sqlConnection.Open();
                    rowsEffected = sqlCommand.ExecuteNonQuery();
                    return rowsEffected;
                }
            }
            catch (Exception ex)
            {
                return rowsEffected;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public bool LoginCustomer()
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
                    sqlCommand.Parameters.AddWithValue("@Gmail", this.G_mail);
                    sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                    sqlConnection.Open();
                    isExist =Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
                    return isExist;
                }
            }
            catch(Exception ex)
            {
                return isExist;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void AssignLoginDetails(string gmail,string password)
        {
            this.G_mail = gmail;
            this.Password = password;
        }
        public static Customer GetDetails(string G_mail)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            Customer customer = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetDetailsAfterLogin", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@gmail", G_mail);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    DataRow row = dataTable.Rows[0];
                    customer = new Customer();
                    customer.CustomerId =Convert.ToInt32(row["CustomerId"]);
                    customer.CustomerFirstName =row["FirstName"].ToString();
                    customer.CustomerSecondName = row["SecondName"].ToString();
                    customer.UserName = row["UserName"].ToString();
                    return customer;
                }
            }
            catch (Exception ex)
            {
                return customer;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
