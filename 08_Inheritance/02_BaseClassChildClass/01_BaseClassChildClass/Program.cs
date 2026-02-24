using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_BaseClassChildClass
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Base class");
        }
    }
    class B:A
    {
        public override void  display()
        {
            Console.WriteLine("chlid class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new B();
            a1.display();
            a1 = new A();
            a1.display();
            
            Console.ReadLine();
        }
    }
}
