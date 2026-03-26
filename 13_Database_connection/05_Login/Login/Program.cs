using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Login
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool LoginCheckByIdPass()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            bool Ischeck=false;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spLoginByUserNamePassword", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", this.UserName);
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
        public string GetNameByLogin()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            string name=null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spShowUserName", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", this.UserName);
                sqlCommand.Parameters.AddWithValue("@Password", this.Password);
                sqlConnection.Open();
                name = Convert.ToString(sqlCommand.ExecuteScalar());
                return name;
            }
            catch (Exception ex)
            {
                return name;
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
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter UserName :");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            user.Password = Console.ReadLine();
            if (user.LoginCheckByIdPass())
            {
                string name = user.GetNameByLogin();
                Console.WriteLine("___________welcome {0}_________",name);
            }
            else
            {
                Console.WriteLine("login not successful");
            }

            Console.Read();
        }
    }
}
