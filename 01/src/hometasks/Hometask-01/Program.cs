using System;

namespace vovazuev.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("��� ��������� ��������� ������� � ����������, ���� �� ����� ������� �����. ��������� ������� ���������� ��������� ������������� ��������.");
            char key;
            int spaces = 0;
            do
            {
                key = Console.ReadKey().KeyChar;
                if (key == ' ') ++spaces;
            }
            while (key != '.');
            Console.WriteLine($"���������� ��������� ��������: {spaces}.");
        }
    }
}
