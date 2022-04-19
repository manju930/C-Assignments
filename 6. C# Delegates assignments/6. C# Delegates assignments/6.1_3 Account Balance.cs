//C# Delegates Assignments
//Manjunath
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates
{
    class BankAtm
    {
        static void Main(string[] args)
        {
            Account objAc = new Account();
            Console.WriteLine("Press 1 for With Draw Amount \n Press 2 for Deposit Amount \n");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            { 
                case 1:
                {
                    Console.WriteLine("You choosen With Draw Amount. \n Please Enter Amount to with draw");
                    int balance = Convert.ToInt32(Console.ReadLine());
                    objAc.UnderBalance += new delegatemethod(objAc.WithDraw);
                    objAc.Insufficient(balance);
                }
                break;
            case 2:
                {
                    Console.WriteLine("You choosen Deposit Amount. \n Please Enter Amount to Deposit");
                    int dpbalance = Convert.ToInt32(Console.ReadLine());
                    objAc.ZeroBalance += new delegatemethod(objAc.Deposit);
                    objAc.DepositMoney(dpbalance);
                }
                break;
                default:
                    break;

                
                Console.ReadKey();
            }
        }
        public delegate void delegatemethod(int x);
        public class Account
        {
            public int AccountNumber { get; set; }
            public int CustomerName { get; set; }
            public int Balance = 1000;
            public int WithDrawAmount { get; set; }
            public event delegatemethod UnderBalance;
            public event delegatemethod ZeroBalance;
            public void Insufficient(int x)
            {
                UnderBalance(x);
            }
            public void DepositMoney(int y)
            {
                ZeroBalance(y);
            }
            public void WithDraw(int x)
            {
                if (x < Balance && Balance != 0)
                {
                    Console.WriteLine("Congratulations!!! Transaction Successfull");
                    Console.WriteLine("Remaining Balance is :" + (Balance - x));
                }
                else if (x > Balance && Balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is " + Balance + " only");
                }
                else
                {
                    Console.WriteLine("Zero Balance :" + Balance);
                }
            }
            public void Deposit(int x)
            {
                Console.Write("Balance After Depositing: " + (Balance + x));
            }
        }
       
    }
}

