using System;
using System.Collections.Generic;

namespace UdincevBogdan.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитает количество повторений слов во ведённом тексте.");

            var words = new Dictionary<string, int>();

            foreach(var word in args)
            {
                word.ToLowerInvariant().Trim("!?,.-()@#$%^&*()_+=-{}[]<>/|\\".ToCharArray());
                if (words.ContainsKey(word)) words[word]++;
                else words.Add(word, 1);
            }

            Console.WriteLine("Частота повторений: ");
            foreach(var key in words.Keys)
                Console.WriteLine($"- {key} - {words[key]}");
            Console.WriteLine($"Общее количество слов: {args.Length}");
            Console.WriteLine($"Количество уникальных слов: {words.Keys.Count}");
        }
    }
}
