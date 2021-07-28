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

        static void PrintHelp() => Console.WriteLine("����� �������");
        static void PrintIncorrectInputMessage() => Console.WriteLine("������������ ����: ��������� ���� � ����� ��� ��������");
        static void OpenWithoutFile() => Console.WriteLine("������ ��������� ��� �������� �����");
        static void OpenFile(string path)
        {  
            Console.WriteLine($"������ ��������� � ��������� ������������� ����� �� ���������� ����: {path}");
        }
        static void CreateFile(string path)
        {
            Console.WriteLine($"������ ��������� � ��������� ������ ����� �� ���������� ����: {path}");
        }
    }
}
