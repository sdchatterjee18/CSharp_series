using System;

namespace _01_While_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number :");
            n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("the reverse of {0} is {1}", n, rev);
            Console.ReadLine();

        }
    }
}
