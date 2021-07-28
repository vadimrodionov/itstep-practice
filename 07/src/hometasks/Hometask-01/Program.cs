using System;
using System.IO;

namespace UdincevBogdan.Hometask_01
{
    class Program
    {
        Stream fileStream;

        static void Main(string[] args)
        {
            ParametersHandler(args);
        }

        static void ParametersHandler(string[] args)
        {
            if (args.Length == 0) OpenWithoutFile();
            else
            {
                switch (args[0])
                {
                    case "-h": PrintHelp(); break;
                    case "-n":
                        {
                            if (args.Length > 1)
                                CreateFile(args[1]);
                            else
                                PrintIncorrectInputMessage();
                            break;
                        }
                    case "-o":
                        {
                            if (args.Length > 1)
                                OpenFile(args[1]);
                            else
                                PrintIncorrectInputMessage();
                            break;
                        }
                    default: PrintHelp(); break;
                }
            }
        }

        static void PrintHelp() => Console.WriteLine("Вывод справки");
        static void PrintIncorrectInputMessage() => Console.WriteLine("Некорректный ввод: требуется путь к файлу для открытия");
        static void OpenWithoutFile() => Console.WriteLine("Запуск редактора без создания файла");
        static void OpenFile(string path)
        {  
            Console.WriteLine($"Запуск редактора с открытием существующего файла по указанному пути: {path}");
        }
        static void CreateFile(string path)
        {
            Console.WriteLine($"запуск редактора с созданием нового файла по указанному пути: {path}");
        }
    }
}
