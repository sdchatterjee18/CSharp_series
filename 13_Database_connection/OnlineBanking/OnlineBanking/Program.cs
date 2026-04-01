using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Account account=new Account();
            Random rnd=new Random();


            Console.WriteLine("Enter Name");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Generate your own Password");
            string Password = Console.ReadLine();
            customer.InsertDetails(CustomerName, Password);
            int C_ID=customer.InsertIntoCustomer();
            if (C_ID != 0)
            {
                Console.WriteLine("Customer_ID has been created Successfully...");
                Console.WriteLine("Your Customer_ID is :{0}\nRemember this to login your Account", C_ID);
                Console.WriteLine("Generate a PIN for performing Transactions...\nPIN must be 6 digits");
                string PIN = Authentication.PinGeneration();
                int AccountNo = rnd.Next(10000, 99999);
                account.AssignAccountDetails(AccountNo, PIN, C_ID);
                int RowsEffected= account.InsertAccountDetails();
                if (RowsEffected != 0)
                {
                    Console.WriteLine("PIN successfully generated...");
                    Console.WriteLine("Your account no. is :{0}", AccountNo);
                }
                else
                {
                    Console.WriteLine("Problem occured when creating account...");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong !! try again...");
            }
            Console.ReadLine();
        }
    }
}
