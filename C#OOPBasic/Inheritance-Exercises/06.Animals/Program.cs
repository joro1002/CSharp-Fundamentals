using System;
using System.Collections.Generic;

namespace _06.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalType = Console.ReadLine();
            while (animalType != "Beast!")
            { 
                try
                {
                    Animal animal = GetAnimal(animalType);
                    Console.Write(animal.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                animalType = Console.ReadLine();
            }
        }

        private static Animal GetAnimal(string animalType)
        {
            var tokens = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var animalName = tokens[0];
            var animalAge = int.Parse(tokens[1]);

            switch (animalType)
            {
                case "Cat":
                    return new Cat(animalName, animalAge, tokens[2]);

                case "Dog":
                    return new Dog(animalName, animalAge, tokens[2]);

                case "Frog":
                    return new Frog(animalName, animalAge, tokens[2]);

                case "Kitten":
                    return new Kitten(animalName, animalAge);

                case "Tomcat":
                    return new Tomcat(animalName, animalAge);

                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
