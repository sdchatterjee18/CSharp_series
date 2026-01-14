using System;
namespace null_coalescing_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            Console.WriteLine("low for cold/medium for hot/high for very very hot/press enter for nothing");
            Console.WriteLine("choose what you want");
            choose = Console.ReadLine();
            choose = string.IsNullOrEmpty(choose) ? null : choose;
            choose = choose ?? "Not decided";
            switch (choose.ToLower())
            {
                case "low":
                    Console.WriteLine("It is cold");
                    break;
                case "medium":
                    Console.WriteLine("It is hot");
                    break;
                case "high":
                    Console.WriteLine("It is very hot");
                    break;
                default:
                    Console.WriteLine(choose);
                    break;
            }
            Console.Read();

            //int? a = null;
            //Console.WriteLine("Enter 1 for tea 2 for no milk");
            //a = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
