using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var n = int.Parse(input[0]);
            var s = int.Parse(input[1]);
            var x = int.Parse(input[2]);

            var numbs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < numbs.Length; i++)
            {
              queue.Enqueue(numbs[i]);
               
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
