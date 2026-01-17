using System;

namespace _02_While_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any number :");
            n = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = n; 
            while (n > 0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("the reverse of {0} is {1}", temp, rev);
            if (temp == rev)
            {
                Console.WriteLine("{0} is plaindrome",temp);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome",temp);
            }
            Console.ReadLine();
        }
    }
}
