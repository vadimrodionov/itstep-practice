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
            Console.WriteLine("Модель банковского счета");
            Thread.Sleep(3000);
            BankAccount account = new BankAccount("Artem Buzinov",DateTime.Now,"$");
            BankAccount accountEmpty = new BankAccount("Vasiliy Tupenko", DateTime.Now,"EU");
            BankAccount accountIlon = new BankAccount("Ilon Musk", DateTime.Now, "EU",1000);
            #region Normal operation
            Console.WriteLine("Создан банковский счет:");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #region Replenish
            uint balanceUp;
            do
            {
                Console.WriteLine("Введите сумму пополнения счета:");
            } while (!uint.TryParse(Console.ReadLine(), out balanceUp));
            account.Replenish(balanceUp);
            Console.WriteLine($"Счет пополнен на {balanceUp}{account.Currency} ");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region CheckBalance
            Console.WriteLine("Запрашиваем баланс счета:");
            Thread.Sleep(2000);
            account.CheckBalance();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region CloseEmptyAcc
            Console.WriteLine("Запрашиваем выписку другого пустого счета:");
            Thread.Sleep(2000);
            accountEmpty.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("Пробуем закрыть пустой счет:");
            Thread.Sleep(2000);
            accountEmpty.Close();
            Thread.Sleep(2000);
            Console.WriteLine("Результат:");
            accountEmpty.Information();
            #endregion
            #region CloseNotEmptyAcc
            Console.WriteLine("Запрашиваем выписку счета c положительным балансом:");
            Thread.Sleep(2000);
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("Запрашиваем историю счета:");
            Thread.Sleep(2000);
            account.GetHistory();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("Пробуем закрыть не пустой счет:");
            Thread.Sleep(2000);
            account.Close();
            Thread.Sleep(2000);
            Console.WriteLine("Результат:");
            account.Information();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
#endregion
#endregion
            #region abnormalOperation
            Console.WriteLine("Попробуем пополнить закрытый счет:");
            account.Information();
            uint balanceUpOnClose;
            do
            {
                Console.WriteLine("Введите сумму пополнения счета:");
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
                FilalyBlock("Не вышло.....");
            }
            Invitation("Попробуем снять сотэн с закрытого счета:");
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
                FilalyBlock("Снова не вышло.....");
            }
            Invitation("Попробуем узнать, есть ли что на закрытом счете:");
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
                FilalyBlock("Опять не прокатило.....");

            }
            Invitation("Попробуем закрыть закрытый счет:");
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
                FilalyBlock("Снова провал.....");
            }
            Console.WriteLine("Попробуем снять со счета сумму больше баланса:");
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
                FilalyBlock("Не вышло.....");
            }
            Console.WriteLine("Спасибо за просмотр!!!");
            #endregion
            Console.ReadLine();













        }
    }
}
