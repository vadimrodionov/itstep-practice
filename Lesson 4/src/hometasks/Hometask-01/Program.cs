using System;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.CheckBalance();
            acc.GetHistory();
            acc.Replenish(100);
            acc.GetHistory();
            
        }
    }
}
