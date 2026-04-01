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
        public static void EnterDetails()
        {
            Console.WriteLine("Enter Name");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Generate your own Password");
            string Password = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            EnterDetails();
            Console.ReadLine();
        }
    }
}
