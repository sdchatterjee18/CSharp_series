using System;
using System.Collections.Generic;
using System.Linq;
static class CheckValidation
{
    //-----ACCOUNT-NUMBER CHECKING METHOD----- 
    public static string CheckAccountNo()
    {
        while (true)
        {
            Console.WriteLine("Enter acc no.(7 digits):");
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
            Console.WriteLine("Generate a PIN(5 digits):");
            string pin = Console.ReadLine();
            if (pin.Length == 5 && pin.All(char.IsDigit))
            {
                return pin;
            }
            Console.WriteLine("You enter invalid Pin !! must be 5 digits...");
        }

    }
}
class Customer
{
    private string Acc_no,PIN;
    private int Balance;
    private string Phone;
    private string Name;

    public Customer(int Balance, string Acc_no, string PIN, string Phone,string name)
    {
        this.Acc_no = Acc_no;
        this.PIN = PIN;
        this.Balance = Balance;
        this.Phone = Phone;
        this.Name = name;
    }

    //-----LOGIN METHOD-----
    public static Customer Login(List<Customer> customers)
    {
        Console.WriteLine("\n***Enter your specific account number and PIN to login***");
        string account_no = CheckValidation.CheckAccountNo();
        string pin = CheckValidation.checkPin();
        foreach (Customer c in customers)
        {
            if (c.Acc_no == account_no)
            {
                if (c.PIN == pin)
                {
                    Console.WriteLine("LOGIN SUCCESSFUL...\n");
                    Console.WriteLine("Hello !! {0}",c.Name);
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


    //-----WITHDRAW METHOD-----
    public void Withdraw(int amount)
    {          
        if (amount <= 0)
        {
            Console.WriteLine("Enter right amount...");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient amount...");
        }
        else
        {
            Balance = Balance - amount;
            Console.WriteLine("WITHDRAW SUCCESSFULL....");
        }
        
    }


    //-----DEPOSIT METHOD-----
    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("You enter invalid amount...");
        }
        else
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposit successfull...");
        }
    }

    //-----BALANCE CHECK METHOD-----
    public void BalanceCheck()
    {
        Console.WriteLine("Available Balance is :{0}",Balance);
    }

}

namespace BasicAtmMachine
{
    class Program
    {
       

        //CREATE ACCOUNT AND ENTER DETAILS...
        public static void CreateAccountInput(List<Customer> AllCustomers)
        {
            string accNo =CheckValidation.CheckAccountNo();
            string pin = CheckValidation.checkPin();
            Console.WriteLine("Enter name :");
            string name=Console.ReadLine();
            Console.WriteLine("Enter mobile number :");
            string phone=Console.ReadLine();
            Console.WriteLine("Account created successfully...");
            AllCustomers.Add(new Customer(0,accNo,pin,phone,name));
        }

        //---------Main Method----------
        static void Main(string[] args)
        {
            List<Customer> AllCustomers = new List<Customer>();
           Customer LoggedIn = null;
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Choose what do you want to do :");
                Console.WriteLine(" | 1. CREATE ACCOUNT | 2.LOGIN | 3.EXIT");
                int Choose = Convert.ToInt32(Console.ReadLine());
                switch (Choose)
                {
                    case 1:

                        CreateAccountInput(AllCustomers);
                        
                        break;
                    case 2:
                        bool check = true;
                        while (check)
                        {
                            LoggedIn = Customer.Login(AllCustomers);
                            if (LoggedIn == null)
                            {
                                Console.WriteLine("Do you want to try Again ? 1. yes 2. No ");
                                int Temp_choose = Convert.ToInt32(Console.ReadLine());
                                if (Temp_choose == 2)
                                {
                                    check = false;
                                }
                            }
                            else
                            {
                                check = false;
                            }
                        }
                        
                        while (LoggedIn!=null)
                        {
                            Console.WriteLine("1.WITHDRAW  2.DEPOSIT  3.BALANCE-CHECK  4.LOGOUT[Exit]");
                            int ChooseAgain = Convert.ToInt32(Console.ReadLine());
                            switch (ChooseAgain)
                            {
                                case 1:
                                    Console.Write("Enter Amount to withdraw...  :");
                                    int amount = Convert.ToInt32(Console.ReadLine());
                                    LoggedIn.Withdraw(amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter how much amount you want to deposit?");
                                    amount = Convert.ToInt32(Console.ReadLine());
                                    LoggedIn.Deposit(amount);
                                    break;
                                case 3:
                                    LoggedIn.BalanceCheck();
                                    break;
                                case 4:
                                    LoggedIn = null;
                                    Console.WriteLine("Logout successfully...");                                    
                                    break;
                            }
                            Console.WriteLine("do you want any other services ?? 1.Yes 2.No");
                            ChooseAgain = Convert.ToInt32(Console.ReadLine());
                            if (ChooseAgain == 2)
                            {
                                break;
                            }
                        }
                       

                        break;
                    case 3:
                        Console.WriteLine("Thank you!! Wish you a good day...");
                        exit = false;
                        break;
                }

            }
           

            Console.ReadLine();
        }
    }
}
