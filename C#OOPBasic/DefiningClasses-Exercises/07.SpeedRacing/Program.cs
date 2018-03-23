using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double fuelFor1Km = double.Parse(carInfo[2]);

                var car = new Car(model, fuel, fuelFor1Km);
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                int amountOfKM = int.Parse(tokens[2]);
                Car car = cars.First(c => c.Model == model);
                car.Drive(amountOfKM);

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.DistanceTraveled}"); 
            }
        }
    }
}
