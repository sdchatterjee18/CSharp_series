using System;

namespace _01_Using_Static
{
    class Find_area
    {
        static float pi = 3.14f;            //A static variable or method allocates memory at compile time
        //int rad;                           //since the value of pi is fixed so it don't need to 
        public static int  Area(int r)      //create different memory space for multiple objects
        {
            //Console.WriteLine("Enter the radius");
            //rad = Convert.ToInt32(Console.ReadLine());
            float area = pi * r * r;
            Console.WriteLine("The area of circle is {0}", area);
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Find_area obj1 = new Find_area(); |
            //obj1.Area();                      |
            //Find_area obj2 = new Find_area(); |{while using non-static method}
            //obj2.Area();                      |
            Console.WriteLine("Enter the radius :");        //
            int r = Convert.ToInt32( Console.ReadLine());   //{while using static method}
            Find_area.Area(r);                              //
            Console.ReadLine();
        }
    }
}
