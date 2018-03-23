using System;
using System.Collections.Generic;
using System.Linq;

namespace TheHeiganDance
{
    class Program
    {
        private static int[] playerPosition;
        static void Main(string[] args)
        {
            playerPosition = new[] { 7, 7 };

            decimal heiganHealth = 3000000;
            decimal playerHealth = 18500;

            const decimal plagueCloud = 3500;
            const decimal eruption = 6000;

            decimal playerDamage = decimal.Parse(Console.ReadLine());
            bool isPoisoned = false;

            string spell = "";
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                heiganHealth -= playerDamage;
                if (isPoisoned)
                {
                    playerHealth -= plagueCloud;

                    if (playerHealth <= 0)
                    {
                        break;
                    }

                    isPoisoned = false;
                }

                string inputSpell = tokens[0];
                spell = inputSpell;
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                HashSet<KeyValuePair<int, int>> lockedCells = LockAllValidCells(row, col);
                bool isPlayerInside = lockedCells.Any(c => c.Key == playerPosition[0] && c.Value == playerPosition[1]);

                if (isPlayerInside && heiganHealth > 0)
                {
                    bool isEscapePossible = IsEscapePossible(lockedCells);

                    if (!isEscapePossible)
                    {
                        if (inputSpell == "Cloud")
                        {
                            isPoisoned = true;
                            playerHealth -= plagueCloud;
                        }
                        else
                        {
                            playerHealth -= eruption;
                        }
                    }
                }

                if (heiganHealth <= 0 || playerHealth <= 0)
                {
                    break;
                }
            }

            if (heiganHealth <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganHealth:f2}");
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine("Player: Killed by {0}", spell == "Cloud" ? "Plague Cloud" : "Eruption");
            }
            else
            {
                Console.WriteLine($"Player: {playerHealth}");
            }

            Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
        }

        private static bool IsEscapePossible(HashSet<KeyValuePair<int, int>> lockedCells)
        {
            int currRow = playerPosition[0];
            int currCol = playerPosition[1];

            if (currCol >= 0 && currCol < 15 && currRow - 1 >= 0 && currRow - 1 < 15 && !lockedCells.Contains(new KeyValuePair<int, int>(currRow - 1, currCol)))
            {
                playerPosition[0] = currRow - 1;
                playerPosition[1] = currCol;
                return true;
            }
            if (currRow >= 0 && currRow < 15 && currCol + 1 >= 0 && currCol + 1 < 15 && !lockedCells.Contains(new KeyValuePair<int, int>(currRow, currCol + 1)))
            {
                playerPosition[0] = currRow;
                playerPosition[1] = currCol + 1;
                return true;
            }
            if (currCol >= 0 && currCol < 15 && currRow + 1 >= 0 && currRow + 1 < 15 && !lockedCells.Contains(new KeyValuePair<int, int>(currRow + 1, currCol)))
            {
                playerPosition[0] = currRow + 1;
                playerPosition[1] = currCol;
                return true;
            }
            if (currRow >= 0 && currRow < 15 && currCol - 1 >= 0 && currCol - 1 < 15 && !lockedCells.Contains(new KeyValuePair<int, int>(currRow, currCol - 1)))
            {
                playerPosition[0] = currRow;
                playerPosition[1] = currCol - 1;
                return true;
            }

            return false;
        }

        private static HashSet<KeyValuePair<int, int>> LockAllValidCells(int row, int col)
        {
            HashSet<KeyValuePair<int, int>> cells = new HashSet<KeyValuePair<int, int>>();

            cells.Add(new KeyValuePair<int, int>(row, col));
            cells.Add(new KeyValuePair<int, int>(row + 1, col - 1));
            cells.Add(new KeyValuePair<int, int>(row + 1, col));
            cells.Add(new KeyValuePair<int, int>(row + 1, col + 1));
            cells.Add(new KeyValuePair<int, int>(row - 1, col + 1));
            cells.Add(new KeyValuePair<int, int>(row - 1, col));
            cells.Add(new KeyValuePair<int, int>(row - 1, col - 1));
            cells.Add(new KeyValuePair<int, int>(row, col + 1));
            cells.Add(new KeyValuePair<int, int>(row, col - 1));

            cells = new HashSet<KeyValuePair<int, int>>(cells.Where(c => c.Key >= 0 && c.Key < 15 && c.Value >= 0 && c.Value < 15));

            return cells;
        }
    }
}
