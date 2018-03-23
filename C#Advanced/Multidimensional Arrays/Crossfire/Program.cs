using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Program
    {
        private static List<List<int>> matrix;

        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
           .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();

            matrix = FillMatrix(sizes[0], sizes[1]);

            string line;
            while ((line = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] bombTokens = line
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int bombRow = bombTokens[0];
                int bombCol = bombTokens[1];
                int bombRadius = bombTokens[2];

                Explosion(bombRow, bombCol, bombRadius);
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void Explosion(int bombRow, int bombCol, int bombRadius)
        {
            for (int rowIndex = bombRow - bombRadius; rowIndex <= bombRow + bombRadius; rowIndex++)
            {
                if (IsValid(rowIndex, bombCol))
                {
                    matrix[rowIndex][bombCol] = -1;
                }
            }

            for (int colIndex = bombCol - bombRadius; colIndex <= bombCol + bombRadius; colIndex++)
            {
                if (IsValid(bombRow, colIndex))
                {
                    matrix[bombRow][colIndex] = -1;
                }
            }

            for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
            {
                matrix[rowIndex] = matrix[rowIndex].Where(n => n > 0).ToList();
                if (matrix[rowIndex].Count == 0)
                {
                    matrix.RemoveAt(rowIndex);
                    rowIndex--;
                }
            }
        }

        private static bool IsValid(int rowIndex, int bombCol)
        {
            return rowIndex >= 0 && rowIndex < matrix.Count && bombCol >= 0 && bombCol < matrix[rowIndex].Count;
        }

        private static List<List<int>> FillMatrix(int rowSize, int colSize)
        {
            List<List<int>> matrix = new List<List<int>>();

            int fillNumber = 1;
            for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
            {
                matrix.Add(new List<int>());
                for (int colIndex = 0; colIndex < colSize; colIndex++)
                {
                    matrix[rowIndex].Add(fillNumber);
                    fillNumber++;
                }
            }

            return matrix;
        }
    }
}
