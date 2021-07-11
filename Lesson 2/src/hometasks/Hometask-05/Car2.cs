using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_05
{
    partial class Car
    {
        #region Methods
        public void SetSpeed(uint value)
        {
            if (value > 0 && value <= MaxSpeed)
            {
                CarSpeed = value;
                if (value > 10 && value <= 30)
                {
                    CarConsumption = 12.5;
                }
                if (value > 30 && value <= 80)
                {
                    CarConsumption = 10.5;
                }
                if (value > 80 && value <= 110)
                {
                    CarConsumption = 8.5;
                }
                if (value > 110)
                {
                    CarConsumption = 10.0;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недопустимая скорость!");
                Console.ResetColor();
            }

        }
        public void StartTheCar()
        {
            CarIsStarted = true;
        }
        public void TurnOffTheCar()
        {
            CarIsStarted = false;
        }
        public void CarInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Информация об автомобиле:\n" +
                                $"Регистрационный номер: {IdNumber};\n" +
                                $"Владелец: {Owner};\n" +
                                $"Модель автомобиля: {Model};\n" +
                                $"Цвет автомобиля: {Color};\n" +
                                $"Двигатель включен: {EngineStarted};\n" +
                                $"Фактическая скорость: {Speed};\n" +
                                $"Расход бензина:{Consumption};\n");
            Console.ResetColor();
        }
        public static void Info()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Отчет завода о произведенных и проданных автомобилях:\n" +
                              $"Всего автомобилей произведено: {NumberOfCars};\n" +
                              $"Последний проданный автомобиль s/n: {LastSaleCar}\n");
            Console.ResetColor();
        }

        public static void SetDistance(ref int dinstance, int newDinstance) 
        {
            dinstance = newDinstance;
        }
        #endregion
    }
}
