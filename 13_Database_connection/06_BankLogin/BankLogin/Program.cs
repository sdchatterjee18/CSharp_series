using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace BankLogin
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public int CustomerID  { get; set; }
        public int InsertDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int RowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spInsertDataintoCustomerDetailsTable",sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerName",this.CustomerName);
                sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                sqlConnection.Open();
                RowsEffected = sqlCommand.ExecuteNonQuery();
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public bool LoginCheckByIdPass()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            bool Ischeck = false;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spLoginByCustomerIDandPassword", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                sqlConnection.Open();
                Ischeck = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                return Ischeck;
            }
            catch (Exception ex)
            {
                return Ischeck;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }

            }

        }
        public int UpdateDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int RowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spUpdateCustomerDetailsIntodatabse", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                sqlCommand.Parameters.AddWithValue("@NewCustomerName", this.CustomerName);
                sqlCommand.Parameters.AddWithValue("@NewPassword", this.Password);
                sqlConnection.Open();
                RowsEffected = sqlCommand.ExecuteNonQuery();
                return RowsEffected;
            }
            catch (Exception ex)
            {
                return RowsEffected;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public int DeleteDataFromDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int rowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spDeleteAccount", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CustomerID",this.CustomerID);
                sqlConnection.Open();
                rowsEffected = sqlCommand.ExecuteNonQuery();
                return rowsEffected;
            }
            catch (Exception ex)
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
    class Program
    {
        static void DisplayMassege(int rowsEffected)
        {
            if (rowsEffected > 0)
            {
                Console.WriteLine("{0} rows Effected", rowsEffected);
            }
            else
            {
                Console.WriteLine("{0} rows Effected", rowsEffected);
            }
        }
        static void EnterID_PassWhileLogin(Customer customer)
        {
            Console.WriteLine("Enter C_ID :");
            customer.CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Password :");
            customer.Password = Console.ReadLine();
        }
        static void EnterNewDetails(Customer customer)
        {
            Console.WriteLine("Enter New Name :");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter New Password :");
            customer.Password = Console.ReadLine();
        }
        static void EnterDetailsToCreateAccount(Customer customer)
        {
            Console.WriteLine("Enter your name to create Account :");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Create your own Password :");
            customer.Password = Console.ReadLine();
        }
        static void EnterCustomerIDtoDeleteAcc(Customer c)
        {
            Console.WriteLine("Enter your C_ID to delete Your Account");
            c.CustomerID = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            int rowsEffected;
            Console.WriteLine(".........Choose What you want to do........");
            Console.WriteLine("1.Create Acc 2.Update Deatils 3.Delete Account 4.Login 5.Exit");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Hello!! user");
                    EnterDetailsToCreateAccount(customer);
                    rowsEffected=customer.InsertDataIntoDatabase();
                    DisplayMassege(rowsEffected);
                    break;
                case 2:
                    Console.WriteLine("Enter Your C_ID and Password to Update your Details");
                    EnterID_PassWhileLogin(customer);
                    if (customer.LoginCheckByIdPass())
                    {
                        EnterNewDetails(customer);
                        rowsEffected = customer.UpdateDataIntoDatabase();
                        DisplayMassege(rowsEffected);
                    }
                    else
                    {
                        Console.WriteLine("OOps!! wrong ID and password");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter ID and Password to delete your Account...");
                    EnterID_PassWhileLogin(customer);
                    if (customer.LoginCheckByIdPass())
                    {
                        rowsEffected = customer.DeleteDataFromDatabase();
                        DisplayMassege(rowsEffected);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter the right ID and Passowrd");
                    }
                    break;

            }
            Console.ReadLine();
        }
    }
}
