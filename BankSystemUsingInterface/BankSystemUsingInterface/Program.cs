//Console.WriteLine("Hello, OS");

namespace BankSystemUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Account:");
            BankInterface bankInterface = new SavingAccount();
            bankInterface.DepositAmount(20000);

            bankInterface.WithdrawAmount(10000);
            bankInterface.WithdrawAmount(10000);

            Console.WriteLine($"Your Saving Account Balance is {bankInterface.CheckBalance()} BDT.");

            Console.WriteLine("\nCurrent Account:");
            bankInterface = new CurrentAccount();
            bankInterface.DepositAmount(20000);

            bankInterface.WithdrawAmount(10000);
            bankInterface.WithdrawAmount(10000);

            Console.WriteLine($"Your Current Account Balance is {bankInterface.CheckBalance()} BDT.");
        }
    }
}