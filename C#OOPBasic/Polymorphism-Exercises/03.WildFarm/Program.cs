﻿using System;
using System.Collections.Generic;

namespace _03.WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();

            string firstLine;
            while ((firstLine = Console.ReadLine()) != "End")
            {
                var animalArgs = firstLine.Split();
                var foodArgs = Console.ReadLine().Split();
                try
                {
                    Animal currentAnimal = AnimalFactory.ProduceAnimal(animalArgs);
                    animals.Add(currentAnimal);

                    Food currentFood = FoodFactory.ProduceFood(foodArgs);

                    Console.WriteLine(currentAnimal.ProduceSound());
                    currentAnimal.IncreaseWeight(currentFood);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
