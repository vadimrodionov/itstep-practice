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
        private DateTime close;
        private string currency;
        private decimal balance;
        private string operationHistory= "\n----------------------------History------------------------------\n";
        private bool isAccountOpen = true;
        Random rand = new Random();
        #endregion
        #region Ctors
        public BankAccount() { }
        public BankAccount(string Name, DateTime Open, string Currency, decimal Balance=0) 
        {
            number = (uint)rand.Next(100000, 999999);
            name = Name;
            open = DateTime.Now;
            currency = Currency;
            balance = Balance;
            isAccountOpen = true;

        }
        #endregion
        #region Properties
        public uint pNumber
        {
            get { return number; }

        }
        public string pName
        {
            get { return name; }
        }
        public DateTime pOpenDate
        {
            get { return open; }
        }
        public DateTime pCloseDate
        {
            get { return close; }
            
        }
        public string pCurrency
        {
            get { return currency; }
            
        }
        public decimal pBalance
        {
            get { return balance; }
            set { balance = value; }
        }
        public bool pIsOpen { get; set; }
        #endregion
        #region Methods

        public void CheckBalance()
        {
            if (isAccountOpen)
            {
                Console.WriteLine($"Баланс счета: {balance}");
                OperationHistoryEventAdd("Запрос баланса",balance);
            }
            else
            {
                InvalidOperationException exeption = new InvalidOperationException($"Can't perform operation CheckBalance on a closed account {number}");
                
            }
            
        }

        public void Replenish(decimal sum)
        {
            if (isAccountOpen)
            {

                decimal balanceBefore = balance;
                balance += sum;
                OperationHistoryEventAdd("Пополнение счета", balanceBefore, sum);
                //Console.WriteLine($"Пополнение счета на: {sum}");
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation Replenish on a closed account {number}");
            }
        }

        public void Withdraw(decimal sum)
        {
            if (isAccountOpen)
            {

                decimal balanceBefore = balance;
                balance -= sum;
                OperationHistoryEventAdd("Снятие со счета", balanceBefore, sum);
                //Console.WriteLine($"Пополнение счета на: {sum}");
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation Withdraw on a closed account {number}");
            };
        }

        public void Close()
        {
            if (isAccountOpen)
            {
                //Console.WriteLine($"Счет закрыт");
                isAccountOpen = false;
            }
            else
            {
                throw new InvalidOperationException($"Can't perform operation Close on a closed account {number}");

            }
        }

        public void GetHistory()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(operationHistory);
            Console.WriteLine("\n-----------------------------END---------------------------------\n");
            Console.ResetColor();
        }
        public void OperationHistoryEventAdd(string operationType, decimal balanceBefore, decimal operationSum=0, bool operationStatus = true,  string operationComments="") 
        {
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
                              $"Сумма: {operationSum};\n" +
                              $"Статус операции: {status}\n" +
                              $"Комментарий: {operationComments}\n" +
                              $"Баланс перед операцией: {balanceBefore}\n" +
                              $"Баланс после операции: {balance}\n";
        }

       
        #endregion

    }
}
