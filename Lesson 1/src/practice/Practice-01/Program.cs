using System;

namespace BuzinovArtem.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ����������� � �������� ����������: ");
            var isInputCorrect = float.TryParse(Console.ReadLine(), out float tempF);
            if (isInputCorrect) 
            {
                float tempC = (tempF - 32) * 5 / 9;
                Console.WriteLine($"����������� � �������� �������: {tempC}");
                Console.ReadLine();
            } 
            else 
            {
                Console.WriteLine("������������ ��������. ��������� ������ ����� ��� ������� �����");
            }
        }
    }
}
