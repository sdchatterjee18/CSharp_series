using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_User_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";
            string password = "soumadip@3214";
            Console.WriteLine("Enter the username");
            string user = Console.ReadLine();
            
            if (user == username)
            {
                Console.WriteLine("Enter the password");
                string pass = Console.ReadLine();
                if (pass == password)
                {
                    Console.WriteLine("Login success");

                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("USER NAME DOES NOT MATCH");

            }
            Console.Read();
                
              
        }
    }
}
