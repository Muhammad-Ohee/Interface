using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemUsingInterface
{
    public class SavingAccount : BankInterface
    {
        private decimal Balance = 0;
        private decimal TodayWithdrawAmount = 0;
        private readonly decimal WithdrawPerDayLimit = 10000;

        
        public decimal CheckBalance()
        {
            return Balance;
        }

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have successfully deposit amount {Amount} BDT.");
            Console.WriteLine($"You balance is {Balance} BDT.");
            return true;
        }

        public bool WithdrawAmount(decimal Amount)
        {
            if ( Balance < Amount )
            {
                Console.WriteLine($"Insufficiant Balance.");
                return false;
            }
            else if (TodayWithdrawAmount >= WithdrawPerDayLimit)
            {
                Console.WriteLine("Limit Exceeded For Today.");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawAmount = TodayWithdrawAmount + Amount;
                Console.WriteLine($"You have successfully withdraw {Amount} BDT amount.");
                Console.WriteLine($"Your balance is {Balance} BDT.");
                return true;
            }

        }
    }
}
