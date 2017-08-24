using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habibEATM
{
    class eatm
    {
        int[] card_numbers = new int[3] { 1, 2, 3 };
        int[] pin_numbers = new int[3] { 123, 234, 456 };
        int[] balance = new int[3] { 500, 200, 800 };
        int n;
        int ct = 0;
        int withdraw = 0;
        int withdrawamount = 0;
        public void PinVerified()
        {
                Console.WriteLine("What You Want?\nPress 1 for Check Balance,\nPress 2 for Add Balance,\nPress 3 for Withdraw\nPress 4 for Exit");
                int select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Console.WriteLine("You Account Balance is: " + balance[ct]);
                }
                else if (select == 2)
                {
                    Console.WriteLine("Enter Amount: ");
                    int x = int.Parse(Console.ReadLine());
                    balance[ct] = balance[ct] + x;
                    Console.WriteLine("You Corrent Amount: " + balance[ct]);
                }
                else if (select == 3)
                {
                    if (withdraw < 3 && withdrawamount < 1000)
                    {
                        Console.WriteLine("Enter Amount: ");
                        int x = int.Parse(Console.ReadLine());
                        if (balance[ct] < x)
                        {
                            Console.WriteLine("Not Enough Money");
                            PinVerified();
                    }
                        else
                        {
                            balance[ct] = balance[ct] - x;
                            Console.WriteLine("You Corrent Amount: " + balance[ct]);
                            withdraw += 1;
                            withdrawamount = withdrawamount + x;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You Daily Maximum Time is Exist");
                    }
                }
                else if (select == 4)
                {
                verification();
                }
                else
                {
                    Console.WriteLine("Select Correct Option");
                }
            PinVerified();
        }
        public void verification()
        {
                Console.Write("what is your card number :");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < card_numbers.Length; i++)
                {
                    if (n == card_numbers[i])
                    {
                        ct = i;
                        break;
                    }
                    else
                    {
                        ct = 999;
                    }
                }
                if (ct == 999)
                {
                    Console.WriteLine("incorrect");
                verification();
            }
                Console.Write("pin number: ");
                int m = int.Parse(Console.ReadLine());

                if (pin_numbers[ct] == m)
                {
                    Console.WriteLine("Pin Verified");
                    PinVerified();
                }
                else
                {
                    Console.WriteLine("Pin Not Match");
                verification();
            }
            verification();
        }
        public void mainProject()
        {
            verification();
        }
    }
}
