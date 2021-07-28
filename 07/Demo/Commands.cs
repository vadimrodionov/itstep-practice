using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Demo
{
    static class Commands
    {
        public static void PrintAbout() => WriteLine(File.ReadAllText("res/about.txt"));

        public static void ReadTextFile() 
        {
            var dir = new DirectoryInfo("res");
            PrintDirectoryFiles(dir);

            using var file = File.Open("res/cards.txt", FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(file);
            WriteLine("Begin reading the file...");
            WriteLine("< Press SPACE to read next line >\n");
            while (!reader.EndOfStream)
            {
                var input = ReadKey().KeyChar;
                if (char.IsWhiteSpace(input))
                    WriteLine(reader.ReadLine());
            }

            WriteLine("Reached end of file.");

            PrintDirectoryFiles(dir);
        }

        public static void ReadBinaryFile() 
        {
            var dir = new DirectoryInfo("res");
            PrintDirectoryFiles(dir);

            var cards = new List<ContactCard>();
            WriteLine("Trying to read cards.dat...");
            try
            {
                using var file = File.Open("res/cards.dat", FileMode.Open, FileAccess.Read);
                using var reader = new BinaryReader(file);

                WriteLine("Begin reading contact cards...");
                var counter = 0;
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    var card = new ContactCard();
                    card.ReadFromBinaryStream(reader);
                    cards.Add(card);
                    counter++;
                }
                WriteLine($"Reading has been completed. Read {counter} cards.");
            }
            catch (Exception ex)
            {
                WriteLine("Something went wrong.");
                WriteLine($"Error: {ex.Message}");
            }

            WriteLine("Cards read from file:\n");
            foreach (var c in cards)
                WriteLine(c.ToString());
        }

        public static void WriteTextFile() 
        {
            var dir = new DirectoryInfo("res");
            PrintDirectoryFiles(dir);

            WriteLine("Seeding contact cards...");
            var cards = Data.SeedContactCards();

            WriteLine("Saving contact cards to text file...");
            using var file = File.Open("res/cards.txt", FileMode.Create, FileAccess.Write);
            using var writer = new StreamWriter(file);
            foreach (var c in cards)
                writer.WriteLine(c.ToString());

            WriteLine("Completed writing to file.\n");

            PrintDirectoryFiles(dir);
        }

        public static void WriteBinaryFile() 
        {
            var dir = new DirectoryInfo("res");
            PrintDirectoryFiles(dir);

            WriteLine("Seeding contact cards...");
            var cards = Data.SeedContactCards();

            WriteLine("Writing cards to a binary file...");
            using var file = File.Open("res/cards.dat", FileMode.Create, FileAccess.Write);
            using var writer = new BinaryWriter(file);
            foreach (var c in cards)
                c.WriteToBinaryStream(writer);
            WriteLine("Completed writing to file.\n");

            PrintDirectoryFiles(dir);
        }

        static private void PrintDirectoryFiles(DirectoryInfo dir)
        {
            var originalColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"Current directory: {dir.FullName}");
            WriteLine($"Files: \n  - {String.Join("\n  - ", dir.GetFiles().Select(f => f.Name))}");
            ForegroundColor = originalColor;
        }
    }
}
