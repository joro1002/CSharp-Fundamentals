using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int counter = 0; counter < n; counter++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];

                double Tire1Pressure = double.Parse(tokens[5]);
                int Tire1Age = int.Parse(tokens[6]);
                double Tire2Pressure = double.Parse(tokens[7]);
                int Tire2Age = int.Parse(tokens[8]);
                double Tire3Pressure = double.Parse(tokens[9]);
                int Tire3Age = int.Parse(tokens[10]);
                double Tire4Pressure = double.Parse(tokens[11]);
                int Tire4Age = int.Parse(tokens[12]);


                var engine = new engine(engineSpeed, enginePower);
                var cargo = new cargo(cargoWeight, cargoType);
                tire[] tires = new tire[4];
                tires[0] = new tire(Tire1Pressure, Tire1Age);
                tires[1] = new tire(Tire2Pressure, Tire2Age);
                tires[2] = new tire(Tire3Pressure, Tire3Age);
                tires[3] = new tire(Tire4Pressure, Tire4Age);
                
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else
            {
                cars.Where(p => p.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
