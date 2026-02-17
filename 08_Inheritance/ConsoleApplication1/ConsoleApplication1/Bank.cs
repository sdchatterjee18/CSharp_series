
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bank
    {
        public  string bank_name;
        public string branch_name;
        public string address;

        public void Display_bank_details()
        {
            Console.WriteLine("----{0}----",bank_name);
            Console.WriteLine("Branch  Name : {0}", branch_name);
            Console.WriteLine("Bank address : {0}",address);
        }
    }
}
