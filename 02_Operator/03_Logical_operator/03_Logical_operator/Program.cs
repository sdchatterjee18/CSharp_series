using System;

namespace Logical_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basically used in if-else statement 
            //perform logical operations on values
            int a,b,c;
            Console.WriteLine("Enter three numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine()); 
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is big",a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("{0} is big", b);
            }
            else
            {
                Console.Write("{0} is big",c);
            }
            Console.Read();

        }
    }
}
