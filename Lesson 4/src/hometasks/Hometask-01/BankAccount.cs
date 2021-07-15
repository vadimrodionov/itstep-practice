using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class BankAccount:IBankOperation
    {
        #region Fields
        private uint number;
        private string name;
        private DateTime open;
        private DateTime close = DateTime.MinValue;
        private string currency;
        private uint balance;
        private string operationHistory= "\n----------------------------History------------------------------\n";
        Random rand = new Random();
        #endregion
        #region Ctors
        public BankAccount() { }
        public BankAccount(string Name, DateTime Open, string Currency, uint Balance=0) 
        {
            number = (uint)rand.Next(100000, 999999);
            name = Name;
            open = DateTime.Now;
            currency = Currency;
            balance = Balance;

        }
        #endregion
        #region Properties
        public string Currency
        {
            get { return currency; }
        }
        #endregion
        #region Methods

        public void CheckBalance()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (close==DateTime.MinValue)
            {
                Console.WriteLine($"Баланс счета {number}: {balance}{currency}");
                OperationHistoryEventAdd("Запрос баланса",balance);
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation CheckBalance on a closed account {number}");
            }
            Console.ResetColor();
        }
        public void Replenish(uint sum)
        {
            if (close == DateTime.MinValue)
            {

                decimal balanceBefore = balance;
                balance += sum;
                OperationHistoryEventAdd("Пополнение счета", balanceBefore, sum);
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation Replenish on a closed account {number}");
            }
        }
        public void Withdraw(uint sum)
        {
            decimal balanceBefore = balance;

            if (close == DateTime.MinValue)
            {
                if (sum > balance)
                {
                    OperationHistoryEventAdd("Снятие со счета", balanceBefore, sum, false);
                    throw new InsufficientFundsException($"Can't perform operation Withdraw on account {number}");
                }
                else
                {
                    balance -= sum;
                    OperationHistoryEventAdd("Снятие со счета", balanceBefore, sum);
                }
            }

            else
            {
                throw new InvalidOperationException($"Can't perform operation Withdraw on a closed account {number}");
            };

           
        }
        public void Close()
        {
            if (close == DateTime.MinValue)
            {
                if (balance>0)
                {
                    Withdraw(balance);
                }

                close = DateTime.Now;
                OperationHistoryEventAdd("Закрытие счета", balance);
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation Close on a closed account {number}");

            }
        }
        public void GetHistory()
        {
            if (close == DateTime.MinValue)
            {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(operationHistory);
            Console.WriteLine("\n-----------------------------END---------------------------------\n");
            Console.ResetColor();
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation GetHistory on a closed account {number}");
            }
        }
        public void OperationHistoryEventAdd(string operationType, decimal balanceBefore, decimal operationSum=0, bool operationStatus = true,  string operationComments="") 
        {
            char type = '+';
            if (operationType== "Снятие со счета")
            {
                type = '-';
            };
            if (operationType == "Запрос баланса"|| operationType == "Запрос выписки"||operationSum==0)
            {
                type = ' ';
            }
            string status;
            if (operationStatus)
            {
                status = "Успешно";
            }
            else
            {
                status = "Отказано";
            }
            operationHistory += $"\n-----------------------------------------------------------------\n" +
                              $"Время операции: {DateTime.Now};\n" +
                              $"Операция:{operationType};\n" +
                              $"Сумма: {type}{operationSum}{currency};\n" +
                              $"Статус операции: {status}\n" +
                              $"Комментарий: {operationComments}\n" +
                              $"Баланс перед операцией: {balanceBefore}\n" +
                              $"Баланс после операции: {balance}\n";
        }
        public void Information() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string status;
            string closeDate;
            if (close == DateTime.MinValue)
            {
                status = "Открыт";
                closeDate = "Счет открыт";

            }
            else
            {
                status = "Закрыт";
                closeDate = $"{close}";
            }
            OperationHistoryEventAdd("Запрос выписки", balance);
            Console.WriteLine("\nИнформация по счету:\n" +
                              $"Номер счета: {number};\n" +
                              $"Владелец: {name};\n" +
                              $"Статуc: {status}; \n" +
                              $"Дата открытия: {open};\n" +
                              $"Дата закрытия: {closeDate};\n" +
                              $"Баланс: {balance}{currency}\n");
            Console.ResetColor();
        }

        #endregion

    }
}
