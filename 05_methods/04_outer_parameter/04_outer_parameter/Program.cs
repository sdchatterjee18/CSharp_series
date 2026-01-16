using System;

namespace _04_outer_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub,mul;
            int a, b;
            Console.WriteLine("Enter 2  numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int add=calculate(a,b,out sub,out mul);
            Console.WriteLine("The sum is :"+add);
            Console.WriteLine("The subtraction is :"+sub);
            Console.WriteLine("The Multiplication is :" + mul);
            Console.ReadLine();
            
        }
        public static int calculate(int a,int b,out int sub,out int mul)
        {
            int sum=a+b;
            sub=a-b;
            mul = a * b;
            return sum;
        }

        
    }
}
