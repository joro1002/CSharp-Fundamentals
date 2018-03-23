using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var x = int.Parse(input[2]);

            var inputNumbs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < inputNumbs.Length; i++)
            {
                stack.Push(inputNumbs[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }




        }
    }
}
