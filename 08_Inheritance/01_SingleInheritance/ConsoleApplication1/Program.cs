using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SBI sbi = new SBI();
            sbi.bank_name = "State Bank Of India";
            sbi.branch_name = "Panskura";
            sbi.address="Panskura R.S.";
            sbi.gold_loan_percent = 7;
            sbi.Display_bank_details();
            sbi.display_goldLoanDetails();
            Console.Read();
        }
    }
}
