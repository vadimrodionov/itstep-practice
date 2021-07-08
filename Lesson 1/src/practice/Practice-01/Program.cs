using System;

namespace BuzinovArtem.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в градусах Фаренгейта: ");
            var isInputCorrect = float.TryParse(Console.ReadLine(), out float tempF);
            if (isInputCorrect) 
            {
                float tempC = (tempF - 32) * 5 / 9;
                Console.WriteLine($"Температура в градусах Цельсия: {tempC}");
                Console.ReadLine();
            } 
            else 
            {
                Console.WriteLine("Некорректное значение. Требуется ввести целое или дробное число");
            }
        }
    }
}
