using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemUsingInterface
{
    interface BankInterface
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount (decimal amount);
        decimal CheckBalance();
    }
}
