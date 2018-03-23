using System;
using System.IO;

namespace _01.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carTokens = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));

            var truckTokens = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split();
                var command = commands[0];
                var typeOfVehicle = commands[1];
                var distance = double.Parse(commands[2]);

                IVehicle vehicle;

                if (typeOfVehicle == "Car")
                {
                    vehicle = car;
                }
                else
                {
                    vehicle = truck;
                }

                switch (command)
                {
                    case "Drive":
                        try
                        {
                            vehicle.Drive(distance);
                            Console.WriteLine($"{vehicle.GetType().Name} travelled {distance} km");
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;

                    case "Refuel":
                        vehicle.Refuel(distance);
                        break;

                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
