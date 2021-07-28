using System;
using System.IO;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        Stream FileStream;
        static void Main(string[] args)
        {
            ParametrsHandler(args);
        }
        static void ParametrsHandler(string[] args)
        {
            if (args.Length == 0)
                Start();
            else
            {
                switch (args[0])
                {
                    case "-h": PrintHelp(); break;
                    case "-n":
                        {
                            if (args.Length > 1)
                            {
                                StartWithCreate(args);
                            }
                            else
                            {
                                IncorrectInputMessage();
                            }
                            break;
                        }
                    case "-o":
                        {
                            if (args.Length > 1)
                            {
                                StartWithOpen(args);
                            }
                            break;
                        }
                    default: PrintHelp(); break;
                }
            }
        }
        static void PrintHelp() => Console.WriteLine("����� �������");
        static void IncorrectInputMessage() => Console.WriteLine("������������ ����");
        static void Start() => Console.WriteLine("������ ��������� ��� �������� �����");
        static void StartWithCreate(string[] args) => Console.WriteLine($"������ ��������� � ��������� ������ ����� {args[1]}");
        static void StartWithOpen(string[] args) => Console.WriteLine($"������ ��������� � ��������� ������������� ����� {args[1]}");
    }
}
