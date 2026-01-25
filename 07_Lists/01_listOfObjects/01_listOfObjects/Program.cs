using System;
using System.Collections.Generic;

namespace _01_listOfObjects
{
    class student
    {
        public int id;
        public string name, department;
        public student(int id, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            Console.WriteLine("Enter how many students :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details for students {0}",(i+1));
                Console.WriteLine("Enter student id   :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student Name :");
                string name =Console.ReadLine();
                Console.WriteLine("Enter student department :");
                string department = Console.ReadLine();
                students.Add(new student(id,name,department));
                
            }
            int k=0;
            foreach (student s in students)
            {
                Console.WriteLine("Details for student{0}",(k+1));
                Console.WriteLine("Student Id   :{0}",s.id);
                Console.WriteLine("Student Name :{0}",s.name);
                Console.WriteLine("Student Dept :{0}",s.department);
                k++;
            }
            Console.Read();
        }
    }
}
