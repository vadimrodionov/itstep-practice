using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("������ ����������� �����");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ResetColor();
            #region Replenish
            BankAccount account = new BankAccount("Artem Buzinov",DateTime.Now,"$");
            Console.WriteLine("�������� �����");
            account.Information();
            Thread.Sleep(2500);
            Console.WriteLine("���������� ����� �� 1000$");
            account.Replenish(1000);
            Thread.Sleep(2500);
            account.CheckBalance();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Withdraw
            Console.WriteLine("������ �� ����� 850$");
            account.CheckBalance();
            Thread.Sleep(2500);
            account.Withdraw(150);
            Thread.Sleep(2500);
            account.Information();
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region History
            Console.WriteLine("����� ������ ������� ");
            account.GetHistory();
            Thread.Sleep(2500);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Close
            Console.WriteLine("�������� �� ������� �����");
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
