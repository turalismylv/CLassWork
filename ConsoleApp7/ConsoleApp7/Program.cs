using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car
            {
                Marka = "Chevrolet",
                Model="Camaro",
                Engine=6.2,
                Fuel=50.0,
                yuzeyandran=12,
                
            };
            Console.WriteLine(MyCar.CanDrive(100));

        }
    }
    class Car {
        public string Model;
        public string Marka;
        public double Engine;
        public double Fuel;
        public long Walk;
        public string Gearbox;
        public int Year;
        public string Color;
        public int Price;
        public int yuzeyandran;
        public bool CanDrive(int gedilecekYol)
        
        {
            return (gedilecekYol * yuzeyandran) / 100 <= Fuel;
        }

    }
}
