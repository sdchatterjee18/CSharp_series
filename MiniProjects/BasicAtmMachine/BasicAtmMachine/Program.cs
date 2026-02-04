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
    public static customer login(List<customer> customers)
    {
        Console.WriteLine("\n***Enter your specific account number and PIN to login***");
        Console.WriteLine("\nEnter Account number :");
        string account_no = Console.ReadLine();
        Console.WriteLine("Enter your PIN :");
        string pin = Console.ReadLine();
        foreach (customer c in customers)
        {
            if (c.Acc_no == account_no)
            {
                if (c.PIN == pin)
                {
                    Console.WriteLine("LOGIN SUCCESSFUL...\n");
                    return c;
                }
                else
                {
                    Console.WriteLine("WRONG PASSWORD....\nTry again\n");
                    return null;
                }
            }
           
        }
         Console.WriteLine("Account does not exist...\nTry Again\n");
            return null;
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
        
        public static void logout(customer loggedIn)
        {
            if (loggedIn != null)
            {
                loggedIn = null;
                Console.WriteLine("Logout successfull...");
            }
        }
        static void Main(string[] args)
        {
            List<customer> AllCustomers = new List<customer>();
            level:
            Console.WriteLine("choose what do you want to do :");
            Console.WriteLine(" | 1. CREATE ACCOUNT | 2.LOGIN | 3.EXIT");
            int choose = Convert.ToInt32(Console.ReadLine());
            customer LoggedIn = null;
            switch(choose)
            {
                case 1 :
                     AllCustomers.Add(customer.CreateAccount());
                     goto level;
                             
                case 2:
                     if (LoggedIn == null)
                     {
                         while (LoggedIn == null)
                         {
                             LoggedIn = customer.login(AllCustomers);

                             if (LoggedIn == null)
                             {
                                 Console.WriteLine("Do you want to try again ?");
                                 Console.WriteLine("1.YES 2.NO");
                                 int c = Convert.ToInt32(Console.ReadLine());
                                 if (c == 2)
                                 {
                                     goto level;
                                 }
                             }
                         }
                     }
                     else
                     {
                         Console.WriteLine("Already logged in...");
                     }

                     Console.WriteLine("\n\nHELLO!! {0}", LoggedIn.Name);
                     agin:
                     Console.WriteLine("What you want to perform ?");
                     Console.WriteLine("1.Withdraw | 2.Deposit | 3.balace check | 4.Logout[Exit] ");
                     int choose1 = Convert.ToInt32(Console.ReadLine());
                     switch (choose1)
                     {
                         case 1:
                             LoggedIn.Withdraw();
                             break;
                         case 2:
                             LoggedIn.deposit();
                             break;
                         case 3:
                             LoggedIn.BalanceCheck();
                             break;
                         case 4:
                             logout(LoggedIn);
                             goto level;  
                         default:
                             Console.WriteLine("\nEnter right choice...\nPlease Logout if you want to exit...");
                             goto agin;
                     }
                    Console.WriteLine("\nDo you want any other services ?...");
                    Console.WriteLine("choose 1 for YES and 2 for NO");
                    int Agin_choose;
                    Agin_choose = Convert.ToInt32(Console.ReadLine());
                    switch(Agin_choose)
                    {
                     case 1:
                     goto agin;
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
