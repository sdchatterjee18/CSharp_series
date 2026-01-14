using System;
namespace datat_type_max_min__value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum value of long :" + Int64.MaxValue);
            Console.WriteLine("Minimum value of long :" + Int64.MinValue);
            Console.WriteLine();

            Console.WriteLine("Maximum value of int :" + Int32.MaxValue);
            Console.WriteLine("Minimum value of int :" + Int32.MinValue);
            Console.WriteLine();

            Console.WriteLine("Maximum value of short :" + Int16.MaxValue);
            Console.WriteLine("Minimum value of short :" + Int16.MinValue);
            Console.WriteLine();

            Console.WriteLine("Maximum value of byte :" + Byte.MaxValue);
            Console.WriteLine("Minimum value of byte :" + Byte.MinValue);
            Console.WriteLine();

            Console.WriteLine("Maximum value of double :" + Double.MaxValue);
            Console.WriteLine("Minimum value of double :" + Double.MinValue);
            
            Console.WriteLine();
            Console.WriteLine("Maximum value of float :" + Single.MaxValue);
            Console.WriteLine("Minimum value of float :" + Single.MinValue);
            Console.ReadLine();

       
        }
    }
}
