using System;

namespace _06_ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //short form of if_else 
            //return 1st expr if condition is true otherwise false
            Console.WriteLine("Enter A :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B :");
            int b = Convert.ToInt32(Console.ReadLine());
            string check = (a > b) ? "A id big" : ((b > a) ? "B is big" : "both are equal");
            Console.WriteLine(check);
            Console.ReadLine();
        }
    }
}
