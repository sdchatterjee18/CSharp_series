using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  two  numbers");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("press : 1 for addition");
            Console.WriteLine("press : 2 for subtraction");
            Console.WriteLine("press : 3 for multiplication");
            Console.WriteLine("press : 4 for division");
            Console.WriteLine("choose :");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("The addition i s"+(a+b));
                    break;
                case 2:
                    Console.WriteLine("The subtraction is "+(a-b));
                    break;
                case 3:
                    Console.WriteLine("The multiplication is " + (a * b));
                    break;
                case 4:
                    if (b != 0)
                    {
                        Console.WriteLine("The division is " + (a / b));
                    }
                    else
                    {
                        Console.WriteLine("division not possible");
                    }
                    break;
                    
            }
            Console.Read();
        }
    }
}
