using System;

namespace _03_Using_params
{
    class add
    {
        public static void sum(params int[] arr)
        {
            int sum = 0;
            foreach (int n in arr)
            {
                sum = sum + n;
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[10];
            Console.WriteLine("Enter how many numbers");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers :");
            for (int i = 0; i < n; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            add.sum(arr);
            Console.Read();
        }
    }
}
