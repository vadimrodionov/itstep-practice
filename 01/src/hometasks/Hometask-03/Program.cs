// Программа считывает с клавиатуры и конвертирует символы нижнего регистра в символы верхнего регистра и наоборот

using System;
using System.Linq;
using System.Text;


namespace ElenaPlotnikova.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            text = string.Join("", text.Select(t => char.IsUpper(t) ? char.ToLower(t) : char.ToUpper(t)));
            Console.WriteLine("Измененный текст: " + text);
        }
    }
}