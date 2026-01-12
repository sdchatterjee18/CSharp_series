using System;


namespace user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The addition is " + c);
            Console.Read();
        }
    }
}
