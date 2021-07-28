using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Demo
{
    public class Snippets
    {
        public static void PrintDemoDelegateData(DemoDelegateOptions options)
        {
            WriteLine("Options container content:");
            foreach (var key in options.Data.Keys)
                WriteLine($"{key}: {options[key]}");
            WriteLine();
        }

        public static void PrintColoredDemoDelegateData(DemoDelegateOptions options)
        {
            void printOption(string key, string value, ConsoleColor baseColor)
            {
                if (options.Data.ContainsKey("--key-color") && Enum.TryParse(options["--key-color"], out ConsoleColor keyColor))
                    ForegroundColor = keyColor;
                Write($"{key}: ");

                if (options.Data.ContainsKey("--value-color") && Enum.TryParse(options["--value-color"], out ConsoleColor valueColor))
                    ForegroundColor = valueColor;
                WriteLine($"{value}");

                ForegroundColor = baseColor;
            }

            if (options.Data.ContainsKey("--color") && Enum.TryParse(options["--color"], out ConsoleColor color))
                ForegroundColor = color;
            if (options.Data.ContainsKey("--bg-color") && Enum.TryParse(options["--bg-color"], out ConsoleColor bgColor))
                BackgroundColor = bgColor;
            WriteLine("Options container content:");

            foreach (var key in options.Data.Keys)
                if (!key.StartsWith("--"))
                    printOption(key, options[key], ForegroundColor);
            WriteLine();

            ResetColor(); 
        }

        public static void LinqDemo()
        {
            var options = new List<DemoDelegateOptions> {
                new DemoDelegateOptions (new Dictionary<string, string> { { "name", "John" }  })
            };

            var query = from o in options
                        let d = o.Data
                        where d.Count > 1
                        orderby o ascending
                        join n in options on o.Data.Keys equals n.Data.Keys
                        group o by d into g
                        select new { g.Key, g.Key.Values };

            WriteLine();
            // any other stuff

            var res = query.ToList();
            var res2 = query.ToList();

            options.Where(o => o.Data.Keys.Contains("name"))
                .OrderBy(o => o.Data.Keys.Count)
                .GroupBy(o => o.Data)
                .Select(g => g.Key)
                .ToList();
        }

    }
}
