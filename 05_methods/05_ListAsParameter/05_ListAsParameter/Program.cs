using System;
using System.Collections.Generic;

namespace _05_ListAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> student =new List<string>();
            student.Add("souma");
            student.Add("sonali");
            student.Add("shreya");
            List<string> returned_list=names(student);
            foreach(string name in returned_list)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }

        static List<string> names(List<string> student)
        {
            return student;
        }
    }
}
