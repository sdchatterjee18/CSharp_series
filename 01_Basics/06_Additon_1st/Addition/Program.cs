using System;


namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The addition is :{0} ",(a+b));
            Console.Read();
        }
    }
}
