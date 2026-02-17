using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SBI:Bank
    {
        public int gold_loan_percent;
        public void display_goldLoanDetails()
        {
            Console.WriteLine("SBI gold loan at {0}%",gold_loan_percent);
        }
    }
}
