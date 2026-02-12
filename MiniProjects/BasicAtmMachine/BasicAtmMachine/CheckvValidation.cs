using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAtmMachine
{
    static class CheckValidation
    {
        //-----ACCOUNT-NUMBER CHECKING METHOD----- 
        public static string CheckAccountNo()
        {
            while (true)
            {
                string acc_no = Console.ReadLine();
                if (acc_no.Length == 7 && acc_no.All(char.IsDigit))
                {
                    return acc_no;
                }
                Console.WriteLine("You enter invalid account no!! must be 7 digits...");
            }

        }

        //------PIN CHECKING METHOD------
        public static string checkPin()
        {
            while (true)
            {
                string pin = Console.ReadLine();
                if (pin.Length == 5 && pin.All(char.IsDigit))
                {
                    return pin;
                }
                Console.WriteLine("You enter invalid Pin !! must be 5 digits...");
            }

        }
    }
}
