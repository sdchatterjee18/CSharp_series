using System;

namespace _04_objAsParameter
{
    class student
    {
        int id;
        string name;
        public student()
        {
            Console.WriteLine("Student details");
        }
        public void input()
        {
            Console.WriteLine("Enter student id :");
            id=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter student Name :");
            name =Console.ReadLine(); 
        }
        public student(student s1)
        {
            s1.input();
        }
        public void display()
        {
            Console.WriteLine("student id : {0}",id);
            Console.WriteLine("student Name :{0}",name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student(s1);
            s1.display();
            Console.ReadLine();
        }
    }
}
