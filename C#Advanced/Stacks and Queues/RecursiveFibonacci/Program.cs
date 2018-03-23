using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class Program
    {
        public static long[] numbers;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            numbers = new long[n + 1];
            Console.WriteLine(recursiveFibonacci(n));
        }

        private static long recursiveFibonacci(int n)
        {
            if (n <= 2)
                return 1;

            if (numbers[n] != 0)
                return numbers[n];

            numbers[n] = recursiveFibonacci(n - 1) + recursiveFibonacci(n - 2);

            return numbers[n];
        }
    }


}
