using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;


namespace InsertUpdateDelete
{
    class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public int InsertDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int RowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("insert into tblBookDetails values ('"+this.BookName+"','"+this.Author+"','"+this.Publisher+"')",sqlConnection);
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
        public int UpdateDataInDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int RowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("update tblBookDetails set BookName='"+this.BookName+"',Author='"+this.Author+"',Publisher='"+this.Publisher+"' where BookID="+this.BookID+"", sqlConnection);
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
            int RowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("delete  from tblBookDetails where BookID ="+this.BookID, sqlConnection);
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            bool Check = true;
            while (Check)
            {
                Console.WriteLine("\n\nEnter which operation you want to perform ?");
                Console.WriteLine("1.INSERT 2.UPDATE 3.DELETE 4.EXIT");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter book name :");
                        books.BookName = Console.ReadLine();
                        Console.WriteLine("Enter Author name :");
                        books.Author = Console.ReadLine();
                        Console.WriteLine("Enter Publisher name :");
                        books.Publisher = Console.ReadLine();
                        int RowsEffected = books.InsertDataIntoDatabase();
                        if (RowsEffected > 0)
                        {
                            Console.WriteLine("{0} rows effected", RowsEffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows effected", RowsEffected);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter book ID to update details:");
                        books.BookID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new book name :");
                        books.BookName = Console.ReadLine();
                        Console.WriteLine("Enter new Author name :");
                        books.Author = Console.ReadLine();
                        Console.WriteLine("Enter new Publisher name :");
                        books.Publisher = Console.ReadLine();
                        RowsEffected = books.UpdateDataInDatabase();
                        if (RowsEffected > 0)
                        {
                            Console.WriteLine("{0} rows effected", RowsEffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows effected", RowsEffected);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter book ID to delete record :");
                        books.BookID = Convert.ToInt32(Console.ReadLine());
                        RowsEffected = books.DeleteDataFromDatabase();
                        if (RowsEffected > 0)
                        {
                            Console.WriteLine("{0} rows deleted", RowsEffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows deleted", RowsEffected);
                        }
                        break;
                    case 4:
                        Console.WriteLine("BYE BYE!!");
                        Check = false;
                        break;
                    default:
                        Console.WriteLine("OOPS!!\nChoosed wrong option....\nChoose again");
                        break;
                }
                Console.WriteLine("Do you want to perform anything else ??\n1.Yes 2.No");
            }
            
            Console.ReadLine();
        }

        public static bool check { get; set; }
    }
}
