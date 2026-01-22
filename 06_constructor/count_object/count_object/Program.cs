using System;
namespace count_object
{
    class count_obj
    {
        static int count = 0;
        public count_obj()
        {
            count++;
        }
        public void show()
        {
            Console.WriteLine(count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            count_obj c1 = new count_obj();
            count_obj c2 = new count_obj();
            count_obj c3 = new count_obj();
            count_obj c4 = new count_obj();
            c4.show();
            Console.Read();
        }
    }
}