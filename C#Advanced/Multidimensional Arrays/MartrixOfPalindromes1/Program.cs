using System;
using System.Linq;

namespace MartrixOfPalindromes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                for (int j = 0; j < rowsAndCols[1]; j++)
                {
                    Console.WriteLine($"{(char)(i + 97)}{(char)(i + j + 97)}{(char)(i + 97)}");
                }
                Console.WriteLine();
            }
        }
    }
}
