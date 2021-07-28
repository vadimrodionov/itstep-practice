using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace UdincevBogdan.Hometask_05
{
    partial class Rocket
    {
        //static double PayLoad { get; set; }
        //static uint PeopleInRocket { get; set; }
        public static string Company { get; set; }
        public double Version_Rocket { get; set; }

        public string Color { get; set; }
        public string Material { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        private double _MassRocket;
        private double MassRocket
        {
            get { return _MassRocket; }
            set { _MassRocket = value; } 
        }
        private double RocketFuel { get; set; }
        public double SpecificImpulse { get; set; }

        public Rocket(string company, double version_Rocket, string color, string material, string name, double height, double width)
        {
            Company = company;
            Version_Rocket = version_Rocket;
            Color = color;
            Material = material;
            Name = name;
            Height = height;
            Width = width;
            if (Material == "Алюминий") MassRocket = ((2.7 * Height * Width)) / 100;
            else if (Material == "Сталь") MassRocket = ((7.8 * Height * Width)) / 100;
            else if (Material == "Титан") MassRocket = ((4.5 * Height * Width)) / 100;
            else throw new ArgumentException($"{Material} такого материала нету!");
            RocketFuel = MassRocket * 20;
            SpecificImpulse = (((RocketFuel + MassRocket) / FuelConsumption()) * 1000) * 3;
        }
        public Rocket(string color, string material, string name)
        {
            Color = color;
            Material = material;
            Name = name;
        }
        public Rocket() { }
        static Rocket()
        {
            Company = null;
        } 
        
        private double FuelConsumption()
        {
            return RocketFuel * 10;
        }
        public double EngineThrust()
        {
            return (SpecificImpulse * FuelConsumption() * 9.8) / 1000; 
        }
        public double MaxSpeedRocket()
        {
            return (SpecificImpulse * (Math.Log((MassRocket + RocketFuel) / MassRocket))) * 2;
        }

        public void Info()
        {
            Console.WriteLine($"Компания: {Company}");
            Console.WriteLine($"Версия: {Version_Rocket}");
            Console.WriteLine($"Имя ракеты: {Name}");
            Console.WriteLine($"Цвет ракеты: {Color}");
            Console.WriteLine($"Материал ракеты: {Material}");
            Console.WriteLine($"Длина ракеты: {Height}");
            Console.WriteLine($"Ширина ракеты: {Width}");
            Console.WriteLine($"Масса ракеты: {MassRocket} т");
            Console.WriteLine($"Масса ракеты с топливом: " + (MassRocket + RocketFuel) + " т");
            Console.WriteLine($"Максимальная скорость: " + MaxSpeedRocket() + " м/c");
            Console.WriteLine($"Эффективность двигателя: " + EngineThrust() + " kH");
            Console.WriteLine($"Удельный импульс ракеты: " + SpecificImpulse + " м/c");
            Console.WriteLine($"Затраты топлива в секунду: " + FuelConsumption() + " кг/c");
        }
        public void Min_Info()
        {
            Console.WriteLine($"Компания: {Company}");
            Console.WriteLine($"Версия: {Version_Rocket}");
            Console.WriteLine($"Имя ракеты: {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Rocket rocket = new Rocket("SpaceX", 1.1, "White", "Сталь", "Souz", 60, 3);
            Rocket[] Rockets = new Rocket[10];
            Rockets[0] = new Rocket("SpaceX", 1.1, "White", "Сталь", "Souz", 60, 3);
            Rockets[1] = new Rocket("SpaceX", 1.2, "Black", "Алюминий", "Falcon", 65, 3.5);
            Rockets[2] = new Rocket("SpaceX", 1.3, "Red", "Сталь", "Souz 1", 70, 4);
            Rockets[3] = new Rocket("SpaceX", 1.4, "Blue", "Титан", "Souz 2", 75, 4.5);
            Rockets[4] = new Rocket("SpaceX", 1.5, "Green", "Титан", "Souz 3", 80, 5);
            char key;
            //char key2;
            int index;
            double Force;

            //string Company;
            //string Name;
            //string Color;
            //string Material = null;
            //double Version_Rocket;
            //double Height;
            //double Width;
            do
            {
                Console.WriteLine("Выберете действие...");
                Console.WriteLine("1. Отобразить ракету по индексу.");
                Console.WriteLine("2. Отобразить весь список ракет с их кратким содержанием.");
                Console.WriteLine("3. Добавить мощности к ракете.");
                Console.WriteLine("0. Выход из программы.");
                key = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (key)
                {
                    case '0': Console.WriteLine(); break;
                    case '1':
                        Console.Write("Введите индекс ракеты: "); index = int.Parse(Console.ReadLine()); Console.Clear();
                        Rockets[index].Info();
                        Console.WriteLine("Для продолжение нажмите любую клавишу...");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case '2':
                        for (int i = 0; i < Rockets.Length; i++)          
                        {
                            Rockets[i].Min_Info(); Console.WriteLine();
                        }
                        Console.WriteLine("Для продолжение нажмите любую клавишу...");
                        Console.ReadKey(); Console.Clear();
                        break;
                    case '3':
                        Console.Write("Введите индекс ракеты: "); index = int.Parse(Console.ReadLine());
                        Console.Write("Введите добавляемую мощность: "); Force = double.Parse(Console.ReadLine());
                        Rockets[index].AddForceToRocket(ref Rockets[index], Force);
                        Console.WriteLine($"Новая мощнасть: {Rockets[index].SpecificImpulse} м/c");
                        Console.WriteLine("Для продолжение нажмите любую клавишу...");
                        Console.ReadKey(); Console.Clear();
                        break;
                    //case '3':
                    //    Console.Write("Компания: "); Company = Console.ReadLine();
                    //    Console.Write("Версия: "); Version_Rocket = double.Parse(Console.ReadLine());
                    //    Console.Write("Имя ракеты: "); Name = Console.ReadLine();
                    //    Console.Write("Цвет ракеты: "); Color = Console.ReadLine();
                    //    Console.WriteLine("Выберете материал ракеты...");
                    //    Console.WriteLine("1. Алюминий");
                    //    Console.WriteLine("2. Сталь");
                    //    Console.WriteLine("3. Титин");
                    //    key2 = Console.ReadKey().KeyChar;
                    //    switch (key2)
                    //    {
                    //        case '1': Material = "Алюминий"; break;
                    //        case '2': Material = "Сталь"; break;
                    //        case '3': Material = "Титиан"; break;
                    //    }
                    //    Console.Write("Длина ракеты: "); Height = double.Parse(Console.ReadLine());
                    //    Console.Write("Ширина ракеты: "); Width = double.Parse(Console.ReadLine());
                    //    foreach (Rocket i in Rockets)
                    //    {
                    //        Rockets = Rockets.Concat(new Rocket[] { new Rocket(Company, Version_Rocket, Color, Material, Name, Height, Width) }).ToArray();
                    //    }
                    //    break;
                }
            } while (key != '0');
        }
    }
}