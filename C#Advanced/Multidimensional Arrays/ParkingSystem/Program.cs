using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem
{
    class Program
    {
        private static List<HashSet<int>> parking;
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
          .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
          .Select(int.Parse)
          .ToArray();

            parking = new List<HashSet<int>>();
            GenerateParking(sizes[0]);

            string line;
            while ((line = Console.ReadLine()) != "stop")
            {
                int[] tokens = line
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int entryRow = tokens[0];
                int parkingRow = tokens[1];
                int parkingCol = tokens[2];

                ParkTheCar(entryRow, parkingRow, parkingCol, sizes[1]);
            }
        }
        private static void ParkTheCar(int entryRow, int parkingRow, int parkingCol, int colSize)
        {
            if (parking[parkingRow].Contains(parkingCol) == false)
            {
                int counter = Math.Abs(entryRow - parkingRow) + parkingCol + 1;
                parking[parkingRow].Add(parkingCol);
                Console.WriteLine(counter);
            }
            else
            {
                int col = 0;
                for (int i = 1; i < colSize; i++)
                {
                    if ((parkingCol - i) > 0 && parking[parkingRow].Contains(parkingCol - i) == false)
                    {
                        col = parkingCol - i;
                        break;
                    }
                    if ((parkingCol + i) < colSize && parking[parkingRow].Contains(parkingCol + i) == false)
                    {
                        col = parkingCol + i;
                        break;
                    }
                }

                if (col == 0)
                {
                    Console.WriteLine($"Row {parkingRow} full");
                }
                else
                {
                    parking[parkingRow].Add(col);
                    int count = Math.Abs(entryRow - parkingRow) + col + 1;
                    Console.WriteLine(count);
                }
            }
        }

        private static void GenerateParking(int rowSize)
        {
            for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
            {
                parking.Add(new HashSet<int>());
                parking[rowIndex].Add(0);
            }
        }
    }
}
