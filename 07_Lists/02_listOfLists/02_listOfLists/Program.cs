using System;
using System.Collections.Generic;

namespace _02_listOfLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> Allemployees = new List<List<string>>();
            Console.Write("Enter how many Employees :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details of employee{0}",(i+1));
                List<string> emp = new List<string>();
                Console.WriteLine("Enter employee id   :");
                emp.Add(Console.ReadLine());
                Console.WriteLine("Enter employee name :");
                emp.Add(Console.ReadLine());
                Console.WriteLine("Enter employee designation :");
                emp.Add(Console.ReadLine());
                Console.WriteLine();
                Allemployees.Add(emp);
            }
            int k = 1;
            foreach(List<string> emp in Allemployees)
            {
                Console.WriteLine("Employee{0}",k);
                Console.WriteLine();
                Console.WriteLine("Employee Id   :{0}",emp[0]);
                Console.WriteLine("Employee Name :{0}", emp[1]);
                Console.WriteLine("Employee Designation :{0}", emp[2]);
                Console.WriteLine();
                k++;
            }
            Console.Read();
        }
    }
}