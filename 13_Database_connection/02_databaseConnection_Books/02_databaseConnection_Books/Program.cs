using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
namespace _02_databaseConnection_Books
{
    class Book
    {
        public string Name;
        public string Author;
        public int ConnectDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            int rowseffected = 0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("insert into tblBooks values ('" + this.Name + "','" + this.Author + "')", sqlConnection);
                sqlConnection.Open();
                rowseffected = sqlCommand.ExecuteNonQuery();
                return rowseffected;
            }
            catch (Exception ex)
            {
                return rowseffected;
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
            Book book = new Book();
            Console.WriteLine("Enter Book name :");
            book.Name=Console.ReadLine();
            Console.WriteLine("Enter author name :");
            book.Author =Console.ReadLine();
            int effectedrows = book.ConnectDatabase();
            if (effectedrows > 0)
            {
                Console.WriteLine("{0} row effected", effectedrows);
            }
            else
            {
                Console.WriteLine("{0} row effected", effectedrows);
            }
            Console.Read();
        }
    }
}
