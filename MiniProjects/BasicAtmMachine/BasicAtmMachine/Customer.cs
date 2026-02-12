using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAtmMachine
{
    class Customer
    {
            private string Acc_no, PIN;
            private int Balance;
            private string Phone;
            private string Name;

            public Customer(int Balance, string Acc_no, string PIN, string Phone, string name)
            {
                this.Acc_no = Acc_no;
                this.PIN = PIN;
                this.Balance = Balance;
                this.Phone = Phone;
                this.Name = name;
            }

            //-----LOGIN METHOD-----
            public static Customer Login(List<Customer> customers, string account_no, string pin)
            {
                
                foreach (Customer c in customers)
                {
                    if (c.Acc_no == account_no)
                    {
                        if (c.PIN == pin)
                        {
                            Console.WriteLine("LOGIN SUCCESSFUL...\n");
                            Console.WriteLine("Hello !! {0}", c.Name);
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
                Console.WriteLine("Available Balance is :{0}", Balance);
            }

        }
    }
