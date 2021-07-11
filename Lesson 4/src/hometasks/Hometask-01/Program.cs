using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Модель банковского счета");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ResetColor();
            #region Replenish
            BankAccount account = new BankAccount("Artem Buzinov",DateTime.Now,"$");
            Console.WriteLine("Создание счета");
            account.Information();
            Thread.Sleep(2500);
            Console.WriteLine("Пополнение счета на 1000$");
            account.Replenish(1000);
            Thread.Sleep(2500);
            account.CheckBalance();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Withdraw
            Console.WriteLine("Снятие со счета 850$");
            account.CheckBalance();
            Thread.Sleep(2500);
            account.Withdraw(150);
            Thread.Sleep(2500);
            account.Information();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region History
            Console.WriteLine("Вывод полной истории ");
            account.GetHistory();
            Thread.Sleep(2500);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Close
            Console.WriteLine("Закрытие не пустого счета");
            account.Information();
            Thread.Sleep(2500);
            account.Close();
            account.Information();
            Console.ReadKey();
            Console.Clear();
            #endregion















        }
    }
}
