using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Relational_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basically used in if-else statement 
            int a = 10;
            int b = 9;
            if (a > b)
            {
                Console.WriteLine("A is big");
            }
            else
            {
                Console.WriteLine("B is big");
            }

            //Bool datatype
            bool check;
            check = ("ABC" == "ABC");//comparing two strings
            Console.Write(check);
            Console.Read();
        }
    }
}
