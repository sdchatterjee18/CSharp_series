using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FieldAndProperty
{
    class Bank
    {
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
        }
        public void SetBalance(int a)
        {
            balance = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            //bank.Balance = 200;
            Console.WriteLine("Enter balance :");
            int bal = Convert.ToInt32(Console.ReadLine());
            bank.SetBalance(bal);
            Console.WriteLine("The balance is :{0}",bank.Balance);
            Console.ReadLine();
        }
    }
}
