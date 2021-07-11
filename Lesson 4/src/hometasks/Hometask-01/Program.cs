using System;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            try
            {
                acc.CheckBalance();
                //acc.Close();
                acc.Replenish(100);
                acc.Withdraw(50);
                acc.GetHistory();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
