using System;

namespace _02.VehiclesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            Vehicles car = new Car(double.Parse(cars[1]), double.Parse(cars[2]), double.Parse(cars[3]));

            var trucks = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Vehicles truck = new Truck(double.Parse(trucks[1]), double.Parse(trucks[2]), double.Parse(trucks[3]));

            var buss = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Vehicles bus = new Bus(double.Parse(buss[1]), double.Parse(buss[2]), double.Parse(buss[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var commnad = tokens[0];
                var vehicle = tokens[1];
                var distance = double.Parse(tokens[2]);

                Vehicles vehicles;
                if (vehicle == "Car")
                {
                    vehicles = car;
                }
                else if (vehicle == "Truck")
                {
                    vehicles = truck;
                }
                else
                {
                    vehicles = bus;
                }

                try
                {
                    switch (commnad)
                    {
                        case "Drive":
                            vehicles.Drive(distance);
                            Console.WriteLine($"{vehicles.GetType().Name} travelled {distance} km");
                            break;

                        case "DriveEmpty":
                            ((Bus)vehicles).DriveEmpty(distance);
                            Console.WriteLine($"{vehicles.GetType().Name} travelled {distance} km");
                            break;

                        case "Refuel":
                            vehicles.Refuel(distance);
                            break;
                    }

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);

                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
