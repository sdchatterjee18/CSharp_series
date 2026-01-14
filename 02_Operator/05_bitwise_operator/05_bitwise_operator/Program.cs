using System;

namespace _05_bitwise_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert the value into binary and then perform bit operations like | & 
            int a = 5;//0101 
    //                       \
   //                          0001 
  //                         /
            int b = 9;//1001
            int c = (a & b);
            Console.WriteLine(c);
            Console.Read();
        }
    }
}
