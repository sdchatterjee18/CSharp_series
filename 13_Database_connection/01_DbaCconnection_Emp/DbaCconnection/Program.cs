using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace DbaCconnection
{
    class Employee
    {
        public int EmpID;
        public string EmpName;
        public int salary;

        public int DatabaseConnection()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection=null;
            int EffectedRows=0;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlCommand sqlcommand = new SqlCommand("insert into tblEmpDetails values('"+this.EmpName+"',"+this.salary+")",sqlConnection);
                sqlConnection.Open();
                EffectedRows=sqlcommand.ExecuteNonQuery();
                return EffectedRows;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return EffectedRows;           
            }
            finally
            {
                if(sqlConnection!=null)
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
            Console.WriteLine("----Enter Employee Details----\n");
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Name:");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            employee.salary = Convert.ToInt32(Console.ReadLine());
            int EffectedRows=employee.DatabaseConnection();
            if (EffectedRows > 0)
            {
                Console.WriteLine("Data Inserted Successfuly...\n{0} Rows effected", EffectedRows);
            }
            else
            {
                Console.Write("{0} Row effeted",EffectedRows);
            }
            Console.Read();
        }
    }
}
