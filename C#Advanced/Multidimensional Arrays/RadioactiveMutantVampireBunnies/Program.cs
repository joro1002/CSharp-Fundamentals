using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeTokens = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int rowSize = sizeTokens[0];
            int colSize = sizeTokens[1];

            int playerRow = 0;
            int playerCol = 0;

            char[][] matrix = ReadMatrix(ref playerRow, ref playerCol, rowSize, colSize);

            char[] directions = Console.ReadLine().ToCharArray();

            bool hasEscaped = false;
            bool isDead = false;

            foreach (var direction in directions)
            {
                int nextRow;
                int nextCol;

                switch (direction)
                {
                    case 'U':
                        nextRow = playerRow - 1;
                        MoveRow(matrix, nextRow, ref playerRow, ref playerCol, ref hasEscaped, ref isDead);
                        break;
                    case 'D':
                        nextRow = playerRow + 1;
                        MoveRow(matrix, nextRow, ref playerRow, ref playerCol, ref hasEscaped, ref isDead);
                        break;
                    case 'L':
                        nextCol = playerCol - 1;
                        MoveCol(matrix, nextCol, ref playerRow, ref playerCol, ref hasEscaped, ref isDead);
                        break;
                    case 'R':
                        nextCol = playerCol + 1;
                        MoveCol(matrix, nextCol, ref playerRow, ref playerCol, ref hasEscaped, ref isDead);
                        break;
                }

                SpreadBunnies(matrix, ref isDead);

                if (isDead || hasEscaped)
                {
                    break;
                }
            }

            Print(playerRow, playerCol, matrix, hasEscaped);
        }

        private static void Print(int playerRow, int playerCol, char[][] matrix, bool hasEscaped)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

            if (hasEscaped)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static char[][] ReadMatrix(ref int playerRow, ref int playerCol, int rowSize, int colSize)
        {
            char[][] matrix = new char[rowSize][];

            for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
            {
                matrix[rowIndex] = new char[colSize];

                string line = Console.ReadLine();

                for (int colIndex = 0; colIndex < colSize; colIndex++)
                {
                    matrix[rowIndex][colIndex] = line[colIndex];
                    if (line[colIndex] == 'P')
                    {
                        playerRow = rowIndex;
                        playerCol = colIndex;
                    }
                }
            }

            return matrix;
        }

        private static void SpreadBunnies(char[][] matrix, ref bool isDead)
        {
            //int[0] -> row index ; int[1] -> col index
            List<int[]> indexes = new List<int[]>();

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        indexes.Add(new[] { row + 1, col });
                        indexes.Add(new[] { row - 1, col });
                        indexes.Add(new[] { row, col + 1 });
                        indexes.Add(new[] { row, col - 1 });
                    }
                }
            }

            foreach (var index in indexes)
            {
                //Skip invalid indexes
                if (index[0] < 0 || index[0] >= matrix.Length || index[1] < 0 || index[1] >= matrix[0].Length)
                {
                    continue;
                }

                if (matrix[index[0]][index[1]] == 'P')
                {
                    isDead = true;
                }

                //Add a new bunny
                matrix[index[0]][index[1]] = 'B';
            }
        }

        private static void MoveCol(char[][] matrix, int nextCol, ref int playerRow, ref int playerCol, ref bool hasEscaped, ref bool isDead)
        {
            if (nextCol < 0 || nextCol >= matrix[0].Length)
            {
                hasEscaped = true;
                matrix[playerRow][playerCol] = '.';
            }
            else
            {
                if (matrix[playerRow][nextCol] == 'B')
                {
                    playerCol = nextCol;
                    isDead = true;
                }
                else
                {
                    matrix[playerRow][nextCol] = 'P';
                    matrix[playerRow][playerCol] = '.';

                    playerCol = nextCol;
                }
            }
        }

        private static void MoveRow(char[][] matrix, int nextRow, ref int playerRow, ref int playerCol,
            ref bool hasEscaped, ref bool isDead)
        {
            if (nextRow < 0 || nextRow >= matrix.Length)
            {
                hasEscaped = true;
                matrix[playerRow][playerCol] = '.';
            }
            else
            {
                if (matrix[nextRow][playerCol] == 'B')
                {
                    playerRow = nextRow;
                    isDead = true;
                }
                else
                {
                    matrix[nextRow][playerCol] = 'P';
                    matrix[playerRow][playerCol] = '.';

                    playerRow = nextRow;
                }
            }
            
        }
    }
}
