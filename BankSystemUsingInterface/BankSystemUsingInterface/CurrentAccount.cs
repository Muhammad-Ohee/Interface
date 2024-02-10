using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemUsingInterface
{
    public class CurrentAccount : BankInterface
    {
        private decimal Balance = 0;

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
            if (Balance < Amount)
            {
                Console.WriteLine($"Insufficiant Balance.");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                Console.WriteLine($"You have successfully withdraw {Amount} BDT amount.");
                Console.WriteLine($"Your balance is {Balance} BDT.");
                return true;
            }
        }
    }
}
