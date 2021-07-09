using System;
using System.Linq;

namespace UdincevBogdan.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -1, 2, -3, 5, 0, 0, 1, -9 };
            array = array.OrderByDescending(x => x).ToArray();
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

        }
    }
}
