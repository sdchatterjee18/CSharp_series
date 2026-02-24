using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Abstract_class
{
    abstract class A
    {
        public abstract void display();
        public abstract void show();
    }
    abstract class B : A
    {
        public override void display()
        {
            Console.WriteLine("CLASS B");
        }
    }
    class C:B
    {
        //public override void display()
        //{
        //    Console.WriteLine("CLASS C");
        //}
        public override void show()
        {
            Console.WriteLine("CLASS c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.display();
            c.show();
            Console.Read();
        }
    }
}
