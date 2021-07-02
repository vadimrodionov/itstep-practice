using System;

namespace vovazuev.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("��� ��������� ������� ������, ������ �� ���� ��� 0, � �������� �������������� ������ �������� ���������� �1.\n");
            // ������� ������ � ��������� ��� ���������� �������
            Random rand = new Random();
            int[] arr = new int[10];
            for(int i = 0; i < 10; ++i)
            {
                arr[i] = rand.Next(3);
            }
            // ������� �������� ������
            Console.Write("�������� ������: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("\n");
            // ��������������� 0 ������
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 9 - i; ++j)
                {
                    if (arr[j] == 0 && arr[j + 1] != 0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            // �������� 0 �� - 1
            for (int i = 0; i < 10; ++i)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
                }
            }
            // ������� �������� ������
            Console.Write("�������� ������: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
