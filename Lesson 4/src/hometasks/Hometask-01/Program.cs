using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        public static void Invitation(string message) 
        {
            Console.WriteLine($"{message}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public static void ExeptionCatcher(Exception ex) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ex.Message}");
            Console.ResetColor();
        }
        public static void FilalyBlock(string message) 
        {
            Console.WriteLine($"{message}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("������ ����������� �����");
            Thread.Sleep(3000);
            BankAccount account = new BankAccount("Artem Buzinov",DateTime.Now,"$");
            BankAccount accountEmpty = new BankAccount("Vasiliy Tupenko", DateTime.Now,"EU");
            BankAccount accountIlon = new BankAccount("Ilon Musk", DateTime.Now, "EU",1000);
            #region Normal operation
            Console.WriteLine("������ ���������� ����:");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #region Replenish
            uint balanceUp;
            do
            {
                Console.WriteLine("������� ����� ���������� �����:");
            } while (!uint.TryParse(Console.ReadLine(), out balanceUp));
            account.Replenish(balanceUp);
            Console.WriteLine($"���� �������� �� {balanceUp}{account.Currency} ");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region CheckBalance
            Console.WriteLine("����������� ������ �����:");
            Thread.Sleep(2000);
            account.CheckBalance();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region CloseEmptyAcc
            Console.WriteLine("����������� ������� ������� ������� �����:");
            Thread.Sleep(2000);
            accountEmpty.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("������� ������� ������ ����:");
            Thread.Sleep(2000);
            accountEmpty.Close();
            Thread.Sleep(2000);
            Console.WriteLine("���������:");
            accountEmpty.Information();
            #endregion
            #region CloseNotEmptyAcc
            Console.WriteLine("����������� ������� ����� c ������������� ��������:");
            Thread.Sleep(2000);
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("����������� ������� �����:");
            Thread.Sleep(2000);
            account.GetHistory();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("������� ������� �� ������ ����:");
            Thread.Sleep(2000);
            account.Close();
            Thread.Sleep(2000);
            Console.WriteLine("���������:");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
#endregion
#endregion
            #region abnormalOperation
            Console.WriteLine("��������� ��������� �������� ����:");
            account.Information();
            uint balanceUpOnClose;
            do
            {
                Console.WriteLine("������� ����� ���������� �����:");
            } while (!uint.TryParse(Console.ReadLine(), out balanceUpOnClose));

            try
            {
                account.Replenish(balanceUpOnClose);
            }
            catch (InvalidOperationException ex)
            {
                ExeptionCatcher(ex);
            }
            finally
            {
                FilalyBlock("�� �����.....");
            }
            Invitation("��������� ����� ����� � ��������� �����:");
            try
            {
                account.Withdraw(100);
            }
            catch (InvalidOperationException ex)
            {
                ExeptionCatcher(ex);
            }
            finally
            {
                FilalyBlock("����� �� �����.....");
            }
            Invitation("��������� ������, ���� �� ��� �� �������� �����:");
            try
            {
                account.CheckBalance();
            }
            catch (InvalidOperationException ex)
            {
                ExeptionCatcher(ex);
            }
            finally
            {
                FilalyBlock("����� �� ���������.....");

            }
            Invitation("��������� ������� �������� ����:");
            try
            {
                account.Close();
            }
            catch (InvalidOperationException ex)
            {
                ExeptionCatcher(ex);
            }
            finally
            {
                FilalyBlock("����� ������.....");
            }
            Console.WriteLine("��������� ����� �� ����� ����� ������ �������:");
            accountIlon.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            try
            {
                accountIlon.Withdraw(1000000);
            }
            catch (InsufficientFundsException ex)
            {
                ExeptionCatcher(ex);
            }
            finally
            {
                FilalyBlock("�� �����.....");
            }
            Console.WriteLine("������� �� ��������!!!");
            #endregion
            Console.ReadLine();













        }
    }
}
