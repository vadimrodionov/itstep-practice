using System;

namespace artem_buzinov.Hometask_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5]; //массив элементов класса

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вывод массива созданных объектов");

            foreach (Car car in cars)
            {
                car.CarInfo();
            }

            Car car1 = new Car(); //использование конструктора по умолчанию
            Car car2 = new Car("Sedan", "Green", "Sergey"); //использование конструктора с параметрами
            Car car3 = new Car("Universal", "Red"); //использование перегруженного конструктора с параметрами
            Console.WriteLine("\nВывод информации об автомобиле\n");
            car2.CarInfo(); // вывод информации об автомобиле
            car2.StartTheCar();
            car2.SetSpeed(100);
            Console.WriteLine("\nВывод информации об автомобиле после изменения состояния с помощью реализованных методов\n");
            car2.CarInfo();
            Console.WriteLine("\nВывод информации с ипользованием статических полей\n");
            Car.Info();
            Console.WriteLine("\nПример использования метода с принимаемым аргументом по ссылке\n");
            Console.WriteLine("Введите значение пройденного расстояния");
            int distance,newDistance;
            while (!int.TryParse(Console.ReadLine(),out distance))
            {
                Console.WriteLine("Неверные данные\n");
            }
            Console.WriteLine("Введите новое значение пройденного расстояния");
            while (!int.TryParse(Console.ReadLine(), out newDistance))
            {
                Console.WriteLine("Неверные данные\n");
            }
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"\nИсходное расстояние до вызова метода: {distance}\n");
            Car.SetDistance(ref distance, newDistance);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nИсходное расстояние после вызова метода: {distance}\n");
            Console.ResetColor();




        }
    }
}
