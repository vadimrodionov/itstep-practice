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
        static void PrintHelp() => Console.WriteLine("Вывод справки");
        static void IncorrectInputMessage() => Console.WriteLine("Некорректный ввод");
        static void Start() => Console.WriteLine("Запуск редактора без открытия файла");
        static void StartWithCreate(string[] args) => Console.WriteLine($"Запуск редактора с созданием нового файла {args[1]}");
        static void StartWithOpen(string[] args) => Console.WriteLine($"Запуск редактора с открытием существующего файла {args[1]}");
    }
}
