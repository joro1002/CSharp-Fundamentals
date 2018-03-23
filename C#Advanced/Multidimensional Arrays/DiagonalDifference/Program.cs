using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int primarySum = 0;
            int secondarySum = 0;


            for (int i = 0; i < matrix.Length; i++)
            {
                primarySum += matrix[i][i];
               
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                secondarySum += matrix[i][matrix.Length - 1 - i];
            }

            Console.WriteLine(Math.Abs(secondarySum - primarySum));
        }
    }
}
