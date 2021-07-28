using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static Demo.Snippets;

namespace Demo
{
    static class Commands
    {
        public static void PrintAbout() => WriteLine(File.ReadAllText("res/about.txt"));

        public static void GenericDelegateSample()
        {
            void doSomethingOnNumber(int number) => 
                WriteLine($"Called <{nameof(doSomething)}> with param {number}");
            void doSomething() => WriteLine("Hello");

            void printString(string str) => WriteLine(str);
            string printHello() => "Hello";

            bool isNegative(int number) => number < 0;
            int compareNumbers(int a, int b) => a - b;

            var generic = new GenericDelegate<int>(doSomethingOnNumber);
            var genericString = new GenericDelegate<string>(printString);

            generic(5);
            genericString("hi there");

            var actionOnNumber = new Action<int>(doSomethingOnNumber);
            var action = new Action(doSomething);
            var function = new Func<string>(printHello);
            var predicate = new Predicate<int>(isNegative);
            var comparison = new Comparison<int>(compareNumbers);
        }

        public static void DelegateDemo()
        {
            DemoDelegate demoDelegate = PrintDemoDelegateData;
            WriteLine($"Initialized delegate with a method {nameof(PrintDemoDelegateData)}");

            WriteLine("Calling a delegate...");
            demoDelegate(InitializeOptions());
            WriteLine("Delegate execution completed.");
        }

        public static void MulticastDelegateDemo()
        {
            DemoDelegate demoDelegate = PrintDemoDelegateData;
            WriteLine($"Initialized delegate with a method {nameof(PrintDemoDelegateData)}");

            demoDelegate += PrintColoredDemoDelegateData;
            WriteLine($"Added {nameof(PrintColoredDemoDelegateData)} to delegate");

            var options = InitializeOptions();
            options.Add("--color", "DarkGreen");
            options.Add("--bg-color", "White");
            options.Add("--key-color", "DarkBlue");
            options.Add("--value-color", "DarkCyan");

            WriteLine("Initialized delegate options and added some colors");

            WriteLine("Calling a delegate...");
            demoDelegate(options);
            WriteLine("Delegate execution completed.");
        }

        public static void EventsDemo()
        {
            var dictionary = new NotifyChangedStringDictionary();
            WriteLine("Initialized notifying dictionary.");

            try
            {
                dictionary.Add("sample1", "test");
            }
            catch (Exception ex)
            {
                WriteLine($"Added sample value - exception <{ex.GetType().Name}> thrown, because no one is subscribed.");
            }

            dictionary.NotifyDataChanged += PrintColoredDemoDelegateData;
            WriteLine($"Subscribed {nameof(PrintColoredDemoDelegateData)}.");

            dictionary.Add("sample2", "test 2");
            WriteLine("Added another value - one handler is called.");

            DemoDelegate anonymous = delegate (DemoDelegateOptions options) {
                WriteLine("Dictionary data changed.");
            };

            dictionary.NotifyDataChanged += anonymous;
            WriteLine($"Subscribed anonymous method.");

            dictionary.AddOrReplace("sample3", "test 3");
            WriteLine("Added third value - two handlers are called.");

            dictionary.NotifyDataChanged -= PrintColoredDemoDelegateData;
            WriteLine($"Unsubscribed {nameof(PrintColoredDemoDelegateData)}.");

            dictionary.Remove("sample1");
            WriteLine("Removed a value - only second handler is called.");

            dictionary.AddRange(
                new Dictionary<string, string> {
                    { "bulk1", "bulk value 1" },
                    { "bulk2", "bulk value 2" },
                    { "bulk3", "bulk value 3" }
                });
            WriteLine("Added three more values.");
        }

        private static DemoDelegateOptions InitializeOptions()
        {
            var options = new DemoDelegateOptions();
            options.Add("greeting", "Hey there!");
            options.Add("question", "How're you?");
            options.Add("hope", "Hope you're doing good!");
            options.Add("wish", "It's Friday, all in all, so I wish you enjoy it :)");
            options.Add("farewell", "Aight, I gotta go. See ya later ;)");
            return options;
        }
    }
}
