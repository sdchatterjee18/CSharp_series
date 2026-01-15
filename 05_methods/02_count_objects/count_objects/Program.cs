using System;

namespace count_objects
{
    class count_obj
    {
        public static int c;
        static count_obj()
        {
            c = 0;
        }
        public  count_obj()
        {
            c++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            count_obj obj1 = new count_obj();
            count_obj obj2 = new count_obj();
            count_obj obj3 = new count_obj();
            Console.Write(count_obj.c);
            Console.Read();
        }
    }
}
