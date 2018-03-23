using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listOfBuy = new List<IBuy>();

            for (int i = 0; i < n; i++)
            {
                var buyerArgs = Console.ReadLine().Split();

                IBuy currentBuyer;
                if (buyerArgs.Length == 3)
                {
                    currentBuyer = new Rebel(buyerArgs[0], int.Parse(buyerArgs[1]), buyerArgs[2]);
                }
                else
                {
                    currentBuyer = new Citizen(buyerArgs[0], int.Parse(buyerArgs[1]), buyerArgs[2], buyerArgs[3]);
                }

                listOfBuy.Add(currentBuyer);
            }

            string buyerName;
            while ((buyerName = Console.ReadLine()) != "End")
            {
                foreach (var buyer in listOfBuy.Where(b => b.Name == buyerName))
                {
                    buyer.BuyFood();
                }
            }

            var totalAmountOfFood = listOfBuy.Sum(b => b.Food);
            Console.WriteLine(totalAmountOfFood);
        }
    }
}
