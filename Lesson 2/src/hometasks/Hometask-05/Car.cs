using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_05
{
    partial class Car
    {
        #region Fields
        private int IdNumber;
        private string Owner = "";
        private string Model = "Sedan";
        private string Color = "White";
        private double Consumption = 0;
        private bool EngineStarted = false;
        private uint Speed = 0;
        private uint MaxSpeed = 220;
        private Random rand = new Random();
        public static int NumberOfCars;
        public static int LastSaleCar;

        #endregion
        #region Constructors
        public Car()
        {
            NumberOfCars++;
            IdNumber = rand.Next();
            LastSaleCar = IdNumber;

        } //default ctor
        public Car(string Model, string Color, string Owner) 
        {
            this.Model = Model;
            this.Color = Color;
            this.Owner = Owner;
            NumberOfCars++;
            IdNumber = rand.Next();
            LastSaleCar = IdNumber;
        }
        public Car(string Model, string Color) 
        {
            this.Model = Model;
            this.Color = Color;
            NumberOfCars++;
            IdNumber = rand.Next();
            LastSaleCar = IdNumber;
        }
        public Car(string Model)
        {
            this.Model = Model;
            NumberOfCars++;
            IdNumber = rand.Next();
            LastSaleCar = IdNumber;
        }
        static Car() 
        {
            NumberOfCars = 0;
            LastSaleCar = 0;
        }

        #endregion
        #region Properties
        public int CarIdNumber
        {
            get { return IdNumber; }
        }
        public string CarOwner { get; set; }
        public string CarModel
        {
            get { return Model; }
        }
        public string CarColor
        {
            get { return Color; }
        }
        public double CarConsumption
        {
            get { return Consumption; }
            set { Consumption = value; }
        }
        public bool CarIsStarted
        {
            get { return EngineStarted; }
            set { EngineStarted = value; }
        }
        public uint CarSpeed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public uint CarMaxSpeed
        {
            get { return MaxSpeed; }
        }
        #endregion
        
    }
}
