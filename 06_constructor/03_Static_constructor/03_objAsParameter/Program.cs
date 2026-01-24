using System;

namespace _03_objAsParameter
{
    class demo
    {
        static float pi;
        int rad;
        float area1;
        static demo()//Static constructor is used to initialize static var
        {                   //allocates memory at compile time before creating any obj
            pi = 3.14f;
        }
        public void area()
        {
            Console.WriteLine("Enter the radius :");
            rad = Convert.ToInt32(Console.ReadLine());
            area1 = pi * rad * rad;
            Console.WriteLine("The area of circle is " + area1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find area of first circle ");
            demo obj1 = new demo();
            obj1.area();
            Console.WriteLine("Find area of second circle ");
            demo obj2 = new demo();
            obj2.area();
            Console.ReadLine();
        }
    }
}
