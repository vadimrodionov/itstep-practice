using System;
using System.Collections.Generic;

using static Demo.Commands;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mode = args.Length > 0 && Commands.ContainsKey(args[0])
                ? args[0]
                : String.Empty;

            Commands[mode]();
        }

        static Dictionary<string, Action> Commands = new Dictionary<string, Action>() {
            { String.Empty, PrintAbout },
            { "-?", PrintAbout },
            { "/?", PrintAbout },
            { "-h", PrintAbout },
            { "/h", PrintAbout },
            { "/help", PrintAbout },
            { "--help", PrintAbout },
            { "help", PrintAbout },
            { "demo-delegate", DelegateDemo },
            { "demo-multicast", MulticastDelegateDemo },
            { "demo-events", EventsDemo },
            { "sample-generic-delegate", GenericDelegateSample },
        };
    }
}
