using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<char[]> matrix = new List<char[]>();
            int rotations = GetRotationsCount();

            string input = Console.ReadLine();

            int maxColSize = 0;
            while (input != "END")
            {
                matrix.Add(input.ToCharArray());
                if (input.Length > maxColSize)
                {
                    maxColSize = input.Length;
                }
                
                input = Console.ReadLine();
            }

            for (int i = 0; i < rotations; i++)
            {
                matrix = Rotate(matrix, maxColSize);
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("" , row));
            }
        }

        private static List<char[]> Rotate(List<char[]> matrix, int maxColSize)
        {
            List<char[]> newMatrix = new List<char[]>();

            for (int colIndex = 0; colIndex < maxColSize; colIndex++)
            {
                List<char> curr = new List<char>();
                for (int rowIndex = 0; rowIndex < matrix.Count; rowIndex++)
                {
                    if (colIndex < matrix[rowIndex].Length)
                    {
                        curr.Add(matrix[rowIndex][colIndex]);
                    }
                    else
                    {
                        curr.Add(' ');
                    }
                }

                curr.Reverse();
                newMatrix.Add(curr.ToArray());
            }

            return newMatrix;
        }

        private static int GetRotationsCount()
        {
            string number = "";
            string line = Console.ReadLine();
            bool appendMode = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ')')
                {
                    break;
                }

                if (appendMode)
                {
                    number += line[i];
                }

                if (line[i] == '(')
                {
                    appendMode = true;
                }
            }
            return (int.Parse(number) % 360) / 90;
        }
}
}
