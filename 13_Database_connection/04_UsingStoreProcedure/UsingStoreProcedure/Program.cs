using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace UsingStoreProcedure
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string  Dept { get; set; }

        public int InsertDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int rowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spInsertDataIntoDatabase", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StudentName", this.StudentName);
                sqlCommand.Parameters.AddWithValue("@Dept", this.Dept);
                sqlConnection.Open();
                rowsEffected = sqlCommand.ExecuteNonQuery();
                return rowsEffected;
            }
            catch
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
        public int UpdateDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int rowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spUpdatestudentTable", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@StudentName", this.StudentName);
                sqlCommand.Parameters.AddWithValue("@Dept", this.Dept);
                sqlCommand.Parameters.AddWithValue("@s_id", this.StudentID);
                sqlConnection.Open();
                rowsEffected = sqlCommand.ExecuteNonQuery();
                return rowsEffected;
            }
            catch
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
        public int DeleteDataIntoDatabase()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            int rowsEffected = 0;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlCommand = new SqlCommand("spDeleteStudentDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@studentID", this.StudentID);
                sqlConnection.Open();
                rowsEffected = sqlCommand.ExecuteNonQuery();
                return rowsEffected;
            }
            catch
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
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Choose\n1.Insert 2.Update 3.delete");
            int choose=Convert.ToInt32(Console.ReadLine());
            int chooseAgin;
            int rowseffected;
            bool isCheck = true;
            while (isCheck)
            {
                switch (choose)
                {
                    case 1:
                        student.StudentName = "Souma";
                        student.Dept = "BCA";
                        rowseffected = student.InsertDataIntoDatabase();
                        if (rowseffected != 0)
                        {
                            Console.WriteLine("{0} rows effected", rowseffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows effected", rowseffected);
                        }
                        Console.WriteLine("DO YOU WANT TO PERFORM AGAIN?\n1.YES 2.NO");
                        chooseAgin = Convert.ToInt32(Console.ReadLine());
                        if (chooseAgin == 2)
                        {
                            isCheck = false;
                        }
                        break;
                    case 2:
                        student.StudentName = "Souma";
                        student.Dept = "BCA";
                        student.StudentID = 101;
                        rowseffected = student.UpdateDataIntoDatabase();
                        if (rowseffected != 0)
                        {
                            Console.WriteLine("{0} rows effected", rowseffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows effected", rowseffected);
                        }
                        Console.WriteLine("DO YOU WANT TO PERFORM AGAIN?\n1.YES 2.NO");
                        chooseAgin = Convert.ToInt32(Console.ReadLine());
                        if (chooseAgin == 2)
                        {
                            isCheck = false;
                        }
                        break;
                    case 3:
                        student.StudentID = 101;
                        rowseffected = student.DeleteDataIntoDatabase();
                        if (rowseffected != 0)
                        {
                            Console.WriteLine("{0} rows deleted", rowseffected);
                        }
                        else
                        {
                            Console.WriteLine("{0} rows deleted", rowseffected);
                        }
                        Console.WriteLine("DO YOU WANT TO PERFORM AGAIN?\n1.YES 2.NO");
                        chooseAgin = Convert.ToInt32(Console.ReadLine());
                        if (chooseAgin == 2)
                        {
                            isCheck = false;
                        }
                        break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
