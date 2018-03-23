using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _10.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var engines = new List<Engine>();
            int typeOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < typeOfEngines; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var engineInfo = double.Parse(tokens[1]);

                var engine = new Engine(model, engineInfo);

                if (tokens.Length > 2)
                {
                    var displacementOrEfficiency = tokens[2];
                    double result;
                    bool isNumber = double.TryParse(displacementOrEfficiency, out result);

                    if (isNumber)
                    {
                        engine.Displacement = displacementOrEfficiency;
                    }
                    else
                    {
                        engine.Efficiency = displacementOrEfficiency;
                    }
                }

                if (tokens.Length > 3)
                {
                    engine.Efficiency = tokens[3];
                }
                engines.Add(engine);
            }

            int n = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < n; counter++)
            {
                var tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                string engine = tokens[1];

                Car car = new Car(model, engines.FirstOrDefault(e => e.Model == engine));

                if (tokens.Length > 2)
                {
                    var colorOrWeight = tokens[2];
                    double result;

                    bool isNumber = double.TryParse(colorOrWeight, out result);

                    if (isNumber)
                    {
                        car.Weight = colorOrWeight;
                    }
                    else
                    {
                        car.Color = colorOrWeight;
                    }
                }

                if (tokens.Length >3)
                {
                    car.Color = tokens[3];
                }
                cars.Add(car);
            }

            cars.ForEach(c => Console.Write(c.ToString()));
        }
    }
}
