using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    class Admin
    {
        public int CustomerID { get; private set; }
        public string CustomerName { get; private set; }
        public int AccountNo { get; private set; }
        private double Balance;
        public List<Admin> GetAllCustomerDetails()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection sqlConnection = null;
            List<Admin> Allcustomers = null;
            try
            {
                sqlConnection = new SqlConnection(CS);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spDisplayllCustomerDetails",sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DataRowCollection dataRowCollection = dataTable.Rows;             
                Allcustomers=new List<Admin>();
                foreach (DataRow rows in dataRowCollection)
                {
                    Admin admin = new Admin();
                    admin.CustomerName = Convert.ToString(rows["CustomerName"]);
                    admin.CustomerID = Convert.ToInt32(rows["CustomerID"]);
                    admin.AccountNo= Convert.ToInt32(rows["AccountNo"]);
                    admin.Balance = Convert.ToDouble (rows["Balance"]);
                    Allcustomers.Add(admin);
                }
                return Allcustomers;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Allcustomers;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void DisplayDetailsOfEachCustomer(Admin Customers)
        {
            Console.WriteLine("\n|CUSTOMER_ID : {0}\t|CUSTOMER NAME : {1}\t|ACCOUNT NUMBER : {2}\t|BALANCE : {3}\t|", Customers.CustomerID, Customers.CustomerName, Customers.AccountNo, Customers.Balance);
        }
    }

}
