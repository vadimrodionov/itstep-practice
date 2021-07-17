using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UdincevBogdan.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input, input2;
            List<BankAccount> bankAccounts = new List<BankAccount>();
            do
            {
                MainMenu();
                input = Console.ReadKey(true); Console.WriteLine(input.KeyChar);
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            string name, currency;
                            Console.Write("������� ���� ���: "); name = Console.ReadLine();
                            Console.Write("������� ������: "); currency = Console.ReadLine();
                            bankAccounts.Add(new BankAccount(name, currency));
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            if (bankAccounts.Count > 0)
                                foreach (BankAccount bankAccount in bankAccounts)
                                    bankAccount.InformationScore();
                            else throw new InvalidOperationException("����� ��� �� �������!");
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            uint _number;
                            int n = 0;
                            Console.Clear(); Console.Write("������� ����� �����: ");
                            _number = uint.Parse(Console.ReadLine());
                            if (bankAccounts.Any(x => x.number == _number))
                            {
                                foreach (var i in bankAccounts)
                                {
                                    if (i.number == _number) break;
                                    else n++;
                                }
                            }
                            else throw new InvalidOperationException("������ ����� ����!");
                            if (bankAccounts[n].close == false) throw new InvalidOperationException("���� ������!");
                            do
                            {
                                AccountMenu();
                                input2 = Console.ReadKey(true); Console.WriteLine(input2.KeyChar);
                                switch (input2.Key)
                                {
                                    case ConsoleKey.D1:
                                        {
                                            Console.Clear();
                                            bankAccounts[n].CheckBalance();
                                            break;
                                        }
                                    case ConsoleKey.D2:
                                        {
                                            Console.Clear();
                                            bankAccounts[n].GetHistory();
                                            break;
                                        }
                                    case ConsoleKey.D3:
                                        {
                                            uint sum;
                                            Console.Write("������� ����� ����������: "); sum = uint.Parse(Console.ReadLine());
                                            bankAccounts[n].Replenish(sum);
                                            break;
                                        }
                                    case ConsoleKey.D4:
                                        {
                                            uint sum;
                                            Console.Write("������� ����� ������: "); sum = uint.Parse(Console.ReadLine());
                                            bankAccounts[n].Withdraw(sum);
                                            break;
                                        }
                                    case ConsoleKey.D5:
                                        {
                                            Console.Clear();
                                            bankAccounts[n].Close();
                                            Console.WriteLine("���� ������!");
                                            break;
                                        }
                                    default: break;
                                }
                            } while (input2.Key != ConsoleKey.Escape || !bankAccounts[n].close);
                            break;
                        }
                    default: break;
                }
            } while (input.Key != ConsoleKey.Escape);
        }
        static void MainMenu()
        {
            Console.WriteLine("��������� '����'\n��� ������ ������� Esc");
            Console.Write
                (
                "1. �������� ����� ����.\n" +
                "2. ���������� ������ �������.\n" +
                "3. ������� ����.\n" +
                "�������: "
                );
        }
        static void AccountMenu()
        {
            Console.WriteLine("���� ��������\n��� ������ ������� Esc");
            Console.Write
                (
                "1. ��������� ������.\n" +
                "2. �������� ������� ��������.\n" +
                "3. ��������� ����.\n" +
                "4. ����� ��������.\n" +
                "5. ������� ����.\n" +
                "�������: "
                );
        }
    }
}
