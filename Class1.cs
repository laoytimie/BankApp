using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppLib
{
 
    public class Account
    {
        public string Name { get; set; }
        public string InitialDeposit { get; set; }
        public double WithdrawalAmount { get; set; }
       

        public double Balance;
        public double Deposit { get; set; }
        public int number=123456789;

        public void CreateAccount()
        {
            Console.WriteLine("Hello, Kindly Enter your full name for your account creation");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("To create your account you need to make an initial deposit not less than #1,000. Enter the Amount for your intial Deposit");
            string CustomerDeposit = Console.ReadLine();
            this.Name = CustomerName;
            this.InitialDeposit = CustomerDeposit;
            number += 1;
            Balance = Int32.Parse(InitialDeposit);
            Console.WriteLine($" Hi {Name}, You are welcome to MyBank. Your  account number is {number} , Please Do not share it with anyone. You just made an Initial Deposit of {InitialDeposit}");

        }

        public void MakeDeposit()
        {
            Console.WriteLine("Enter Amount to deposit");
            double MyDeposit= Int32.Parse(Console.ReadLine());
            this.Deposit = MyDeposit;
            this.Balance += Deposit;
            Console.WriteLine($" Dear {Name},You have just made a deposit of {Deposit}, and your current balance is  {Balance}");
        }

        public void MakeWithdrawal()
        {
            Console.WriteLine("Enter Amount to be Withdrawn");

            double MyWithdrawal= Int32.Parse(Console.ReadLine());
            this.WithdrawalAmount = MyWithdrawal;
            if (MyWithdrawal <= Balance)
            {
                this.Balance -= WithdrawalAmount;
                Console.WriteLine($"{WithdrawalAmount} has just been withdrawn from your account, your balance is {Balance}, If this withdrawal isnt done by you, kindly Visit any of our branches to make a complain");


            }
            else
            {
                Console.WriteLine(" You have Inssufficient Balance");
            }
            
        }


    }

   
}
