using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = input[0];
            var cols = input[1];

            var matrix = new string[rows][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ' ' })
                    .ToArray();
            }

            int counter = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j] == matrix[i + 1][j] && matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);

         



        }
    }
}
