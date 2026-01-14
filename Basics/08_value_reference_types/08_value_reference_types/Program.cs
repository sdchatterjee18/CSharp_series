using System;
class val
{
    public int age = 10;
}

namespace _08_value_reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference type
            val obj = new val();
            obj.age = 20;
            //Console.WriteLine(obj.age);
            val obj1 = new val();
            obj1 = obj;//reference copied
            obj1.age = 30;
            Console.WriteLine(obj.age);
           

            //Value type
            int a = 10;
            int b = a;//value copied
            b = 20;
            Console.WriteLine(a+""+b);
            Console.Read();
        }
    }
}
