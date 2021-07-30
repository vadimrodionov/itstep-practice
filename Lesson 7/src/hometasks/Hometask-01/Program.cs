using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace artem_buzinov.Hometask_01
{
    class Program
    { 
        // Нужно, блеать подсвечивать курсор!
        //Без понятия как решать эту задачу в принципе
        static void Main(string[] args)
        {
            var mode = args.Length == 0
            ? String.Empty
            : OpenModes.ContainsKey(args[0])
            ? args[0]
            : "-h";
            OpenModes[mode](args);
        }
        static Dictionary<string, Action<string[]>> OpenModes => new Dictionary<string, Action<string[]>>()
        {
            { String.Empty, OpenWithoutFile },
            { "-h", PrintHelp },
            { "-n", CreateFile },
            { "-o", OpenFile },
        };
        static void PrintHelp(string[] _) => Console.WriteLine("Справка");
        static void PrintInvalidParametersMessage() =>
        Console.WriteLine("Некорректные параметры: не указан путь к файлу для создания или открытия.");
        static void OpenWithoutFile(string[] _)
        {
            Console.WriteLine("Редактор открыт без создания файла");
            using MemoryStream memoryStream = new MemoryStream();
            OpenEditor(memoryStream);
        }
        static void OpenFile(string[] args)
        {
            if (args.Length > 1)
            {
                try
                {
                    using FileStream fileStream = File.Open(args[1], FileMode.Open, FileAccess.ReadWrite);
                    OpenEditor(fileStream);

                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Возникла проблема при открытии файла: {ex.Message}");
                }
            }
            else
                PrintInvalidParametersMessage();
        }
        static void CreateFile(string[] args)
        {
            if (args.Length > 1)
            {
                try
                {
                    using FileStream fileStream = File.Open(args[1], FileMode.CreateNew, FileAccess.ReadWrite);
                    OpenEditor(fileStream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Возникла проблема при создании файла: {ex.Message}");
                }
            }
            else
                PrintInvalidParametersMessage();
        static void CreateFile(string[] args)
        {
            if (args.Length > 1)
            {
                try
                {
                    using FileStream fileStream = File.Open(args[1], FileMode.CreateNew, FileAccess.ReadWrite);
                    OpenEditor(fileStream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Возникла проблема при создании файла: {ex.Message}");
                }
            }
            else
                PrintInvalidParametersMessage();
        }
        }
        static void OpenEditor(Stream underlyingStream)
        {
            // edit text
            using StreamReader sR = new StreamReader(underlyingStream);
            using StreamWriter sW = new StreamWriter(underlyingStream);
            int currentRow = 0;
            int currentColumn = 0;
            while (true)
            {
                DrawCurrentText(sR, currentRow, currentColumn);
                ProcessUserInput();
            }
        }
        static void DrawCurrentText(StreamReader reader, int currentRow, int currentColumn)
        {
            //clear cosnole;
            Console.Clear();
            //seek beginning;
            reader.BaseStream.Seek(0, SeekOrigin.Begin); // ссылка на поток внутри потока
            //seek current row
            for (int i = 0; i < currentRow-5; i++)
            {
                reader.ReadLine();
            }
            //seek current column
            //seek beginning of the fifth line before current
            //seek ending of fourteenth line after current
            //read chunk of data from stream
            var displayData = new StringBuilder();
            for (int i = currentRow; i < currentRow+15; i++)
            {
                displayData.Append(reader.ReadLine());
            }
            //print the data into console
            displayData.ToString();
            Console.WriteLine(displayData);
        }
        static void ProcessUserInput()
        {
            //process input
        }

    }
}
