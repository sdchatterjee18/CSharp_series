using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    class Program
    {
        public static int retryLogin()
        {
            bool Ischeck = true;
            while (Ischeck)
            {
                Console.WriteLine("Enter ID");          
                int CustomerID = Convert.ToInt32(Authentication.CheckDigit());
                Console.WriteLine("Enter Password");
                string Password = Console.ReadLine();
                if (Authentication.Login(CustomerID, Password))
                {
                    return CustomerID;
                }
                else
                {
                    Console.WriteLine("\tInvalid ID or Password");
                    bool check = true;
                    while (check)
                    {
                        Console.WriteLine("\tDo you want to try Again?\n\t1.yes | 2.No");
                        int Choose = Convert.ToInt32(Authentication.CheckDigit());
                        switch (Choose)
                        {
                            case 1:
                                Console.WriteLine("\ttry Again ->");
                                check = false;
                                break;
                            case 2:
                                return 0;
                            default:
                                Console.WriteLine("\tChoose Right Option");
                                break;
                        }
                    }
                }
                
            }
            return 0;
        }
        public static int RetryPin(int AccountNo)
        {
            int Pin;
            bool Ischeck = true;
            while (Ischeck)
            {
                Console.WriteLine("Enter PIN");
                Pin = Convert.ToInt32(Authentication.CheckDigit());
                if (Authentication.CheckPinForTransactions(Pin,AccountNo))
                {
                    return Pin;
                }
                else
                {
                    Console.WriteLine("\tPIN Does not Match");
                    bool check = true;
                    while (check)
                    {
                        Console.WriteLine("\tDo you want to try Again?\n\t1.yes | 2.No");
                        int Choose = Convert.ToInt32(Authentication.CheckDigit());
                        switch (Choose)
                        {
                            case 1:
                                Console.WriteLine("\ttry Again ->");
                                check = false;
                                break;
                            case 2:
                                return 0;
                            default:
                                Console.WriteLine("\tChoose Right Option");
                                break;
                        }
                    }
                }

            }
            return 0;
        }
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Account account=new Account();
            Random rnd=new Random();
            Console.WriteLine("\t\t____________________________________");
            Console.WriteLine("\t\t|\tWelcome to Bank _XYZ_\t   |");
            Console.WriteLine("\t\t------------------------------------");
            int Choose_section;
            Console.WriteLine("\nChoose your section ->");
            Console.WriteLine("\t_____________________________________________");
            Console.WriteLine("\t|  1.CUSTOMER Section  |  2.ADMIN Section  |");
            Console.WriteLine("\t---------------------------------------------");
            Choose_section = Convert.ToInt32(Authentication.CheckDigit());
            switch (Choose_section)
            {
                case 1:
                    Console.WriteLine("Enter which operation you want to perform?  ->");
                    Console.WriteLine("1.CREATE ACCOUNT | 2.LOGIN ");
                    int Choose_Operation =Convert.ToInt32(Authentication.CheckDigit());
                    switch (Choose_Operation)
                    {
                        case 1:
                            Console.WriteLine("Enter Name");
                            string CustomerName = Console.ReadLine();
                            Console.WriteLine("Generate your own Password");
                            string Password = Console.ReadLine();
                            customer.InsertDetails(CustomerName, Password);
                            int C_ID=customer.InsertIntoCustomer();
                            if (C_ID != 0)
                            {
                                Console.WriteLine("Customer_ID has been created Successfully...");
                                Console.WriteLine("Your Customer_ID is :{0}\nRemember this to login your Account", C_ID);
                                Console.WriteLine("Generate a PIN for performing Transactions...\nPIN must be 6 digits");
                                int PIN =Convert.ToInt32( Authentication.PinGeneration());
                                int AccountNo = rnd.Next(10000, 99999);
                                account.AssignAccountDetails(AccountNo, PIN, C_ID);
                                int RowsEffected = account.InsertAccountDetails();
                                if (RowsEffected != 0)
                                {
                                   Console.WriteLine("PIN successfully generated...");
                                   Console.WriteLine("Your account no. is :{0}", AccountNo);
                                }
                               else
                               {
                                   Console.WriteLine("Problem occured while generating account No...");
                               }
                            }
                           else
                           {
                              Console.WriteLine("Something went wrong !! Customer ID not created...");
                           }
                            break;
                        case 2:
                            Console.WriteLine("\tEnter your Customer_ID and Password to login...");
                            C_ID = retryLogin();
                            if (C_ID != 0)
                            {
                                Console.WriteLine("\tLOGIN SUCCESSFUL!!");
                                string Name = customer.GetNameOfCustomer(C_ID);
                                Console.WriteLine("\nWELCOME!! {0}", Name);
                                int? AccountNo;
                                if (account.GetAccountNoForTransactions(C_ID) != null)
                                {
                                    AccountNo =Convert.ToInt32(account.GetAccountNoForTransactions(C_ID));
                                    bool Check = true;
                                    //Loop for multiple Operations at a time
                                    while (Check)
                                    {
                                        Console.WriteLine("\nChoose which service Do you Want ->");
                                        Console.WriteLine("\t________________");
                                        Console.WriteLine("\t1>Deposit       |");
                                        Console.WriteLine("\t----------------");
                                        Console.WriteLine("\t2>Withdraw      | ");
                                        Console.WriteLine("\t----------------");
                                        Console.WriteLine("\t3>Check balance |");
                                        Console.WriteLine("\t________________");
                                        int Choose_operation = Convert.ToInt32(Authentication.CheckDigit());
                                        //Switch All Operations
                                        switch (Choose_operation)
                                        {
                                            case 1:
                                                break;
                                            case 2:
                                                if (RetryPin(AccountNo.Value) != 0)
                                                {
                                                    double? Balance = account.GetBalanceByAccountNo(AccountNo.Value);
                                                    if (Balance != null)
                                                    {
                                                        Console.WriteLine("Enter the Amount of deposit :");
                                                        double Deposit = Convert.ToDouble(Console.ReadLine());
                                                        Balance = account.DepositAmountUsingAccountNo(AccountNo.Value, Balance.Value, Deposit);
                                                        if (Balance!=null)
                                                        {
                                                            Console.WriteLine("\nAmount Deposit successfull\nCurrent balance is {0}",Balance);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Error!! While fetching Account Balance");
                                                    }
                                                }
                                                break;
                                            case 3:
                                                
                                                if (RetryPin(AccountNo.Value) != 0)
                                                {
                                                    double? Balance = account.GetBalanceByAccountNo(AccountNo.Value);
                                                    if (Balance != null)
                                                    {
                                                        Console.WriteLine("Current Balance : {0}", Balance);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Error!! While fetching Account Balance");
                                                    }
                                                }                                               
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.WriteLine("You Choosed wrong option...");
                                                break;
                                        }
                                        //Checking if any other service needed
                                        Console.WriteLine("\tDo you want any other servies?\n\t1.yes | 2.No");
                                        bool check_agin = true;
                                        //loop for try again if wrong option choosed mistakenly 
                                        while (check_agin)
                                        {
                                            int Choose_operation_Again = Convert.ToInt32(Authentication.CheckDigit());
                                            switch (Choose_operation_Again)
                                            {
                                                case 1:
                                                    check_agin = false;
                                                    break;
                                                case 2:
                                                    check_agin = false;
                                                    Check = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Choosed wrong option try Again...");
                                                    break;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error Occured while fetching account no.");
                                }
                            }
                            break;
                     }
                    break;
                case 2:
                    //Admin part
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

        public static int Account_No { get; set; }
    }
}
