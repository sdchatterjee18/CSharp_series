using System;
using System.Collections.Generic;
class customer
{
    public string Acc_no,PIN;
    public int Balance;
    public string Phone;
    public string Name;

    public customer(int Balance, string Acc_no, string PIN, string Phone,string name)
    {
        this.Acc_no = Acc_no;
        this.PIN = PIN;
        this.Balance = Balance;
        this.Phone = Phone;
        this.Name = name;
    }
    public static customer CreateAccount()
    {
        Console.Write("Enter Account NO.(7 digits) :");
        string Acc_no = Console.ReadLine();
        Console.Write("Generate a PIN of 5 digits :");
        string PIN = Console.ReadLine();
        Console.Write("Enter your name :");
        string Name = Console.ReadLine();
        Console.Write("Enter Mobile number:");
        string Phone = Console.ReadLine();       
        Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY...");
        return new customer(0,Acc_no,PIN,Phone,Name);
    }
    public void Withdraw()
    {
        Console.Write("Enter Amount to withdraw...  :");
        int amount = Convert.ToInt32(Console.ReadLine());  
        if (amount < 0)
        {
            Console.WriteLine("Enter right amount...");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficiant amount...");
        }
        else
        {
            Balance = Balance - amount;
            Console.WriteLine("WITHDRAW SUCCESSFULL....");
        }
        
    }
    public void deposit()
    {
        Console.WriteLine("Enter amount to deposit :");
        int amount = Convert.ToInt32(Console.ReadLine());
        Balance = Balance + amount;
        Console.WriteLine("Deposit successfull...");

    }
    public void BalanceCheck()
    {
        Console.WriteLine("Available Balance is :{0}",Balance);
    }
}

namespace BasicAtmMachine
{
    class Program
    {
        static customer login(List<customer> customers)
        {
            Console.WriteLine("***Enter your specific account number and PIN to login***");
            Console.WriteLine("Enter Account number :");
            string account_no = Console.ReadLine();
            Console.WriteLine("Enter your PIN :");
            string pin= Console.ReadLine();
            foreach (customer c in customers)
            {
                if (c.Acc_no == account_no)
                {
                    if (c.PIN == pin)
                    {
                        Console.WriteLine("LOGIN SUCCESSFUL...");
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("WRONG PASSWORD....");
                        return null;
                    }
                }
            }
            Console.WriteLine("Account does not exist...");
            return null;          
        }
        static void Main(string[] args)
        {
            List<customer> AllCustomers = new List<customer>();
            level:
            Console.WriteLine("choose what do you want to do :");
            Console.WriteLine(" | 1. CREATE ACCOUNT | 2.WITHDRAW | 3.DEPOSIT | 4.BALANCE CHECK | ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1 :
                    AllCustomers.Add(customer.CreateAccount());
                     break;           
               case 2:
                    customer withdraw_customer=login(AllCustomers);
                    if(withdraw_customer!=null)
                    {
                        
                        withdraw_customer.Withdraw();
                    }
                     break;
                case 3:
                     customer deposit_customer = login(AllCustomers);
                     if (deposit_customer != null)
                     {
                         deposit_customer.deposit();
                     }
                     break;
                case 4:
                     customer check_balance_customer = login(AllCustomers);
                     if (check_balance_customer != null)
                     {
                         check_balance_customer.BalanceCheck();
                     }
                     break;
            }
            Console.WriteLine("Do you want any other services ?...");
            Console.WriteLine("choose 1 for YES and 2 for NO");
            int Agin_choose;
            Agin_choose = Convert.ToInt32(Console.ReadLine());
            switch(Agin_choose)
            {
                case 1:
                    goto level;
            }
            Console.ReadLine();
        }
    }
}
