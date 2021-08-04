using System;

public class Task3
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine();
 
            while (a <= b)
            {
                for (int i = 0; i<a; i++)
                    Console.Write("{0}", a);
                Console.WriteLine();
                a++;
            }
}
