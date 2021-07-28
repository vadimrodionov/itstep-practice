using System;
using System.IO;
using System.Collections.Generic;

using static Demo.Commands;

namespace Demo
{
    class Program
    {
        FileStream f;
        MemoryStream m;
        BufferedStream b;

        TextReader tr;
        TextWriter tw;

        StringReader stringr;
        StringWriter stringw;
        StreamWriter streamr;
        StreamWriter streamw;

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
            { "demo-read-text-file", ReadTextFile },
            { "demo-read-binary-file", ReadBinaryFile },
            { "demo-write-text-file", WriteTextFile },
            { "demo-write-binary-file", WriteBinaryFile },
        };
    }
}
