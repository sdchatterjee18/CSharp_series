using System;

namespace _04_Inc_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            //used to increase and decrease the value by one (++/--)
            int a = 10;
            int b = 20;
            Console.WriteLine(a++ + "  " + b--);//10 & 20
            Console.WriteLine(++a + "  " + --b);//12 & 18
            Console.Read();
        }
    }
}
