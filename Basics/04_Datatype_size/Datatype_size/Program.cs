using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datatype_size
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of interger :" + sizeof(Int32));
            Console.WriteLine("Size of long     :" + sizeof(Int64));
            Console.WriteLine("Size of short    :" + sizeof(Int16));
            Console.WriteLine("Size of byte     :" + sizeof(Byte));
            Console.WriteLine("Size of float    :" + sizeof(Single));
            Console.WriteLine("Size of double   :" + sizeof(Double));
            Console.WriteLine("Size of Character:" + sizeof(Char));
            Console.Read();
        }
    }
}
