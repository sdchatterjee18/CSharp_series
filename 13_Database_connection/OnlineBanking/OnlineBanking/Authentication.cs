using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineBanking
{
    class Authentication
    {
        private int PIN;
        public static string PinGeneration()
        {
            while (true)
            {
                string PIN = Console.ReadLine();
                if (PIN.Length == 6 && PIN.All(char.IsDigit))
                {
                    return PIN;
                }
                else
                {
                    Console.WriteLine("SomeThing went Wrong!!PIN must be 6 Digits");
                }
            }
        }
    }
}
