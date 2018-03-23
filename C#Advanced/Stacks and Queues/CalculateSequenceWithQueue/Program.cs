using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(number);

            List<long> sequence = new List<long>();
            sequence.Add(number);

            while (queue.Count < 50)
            {
                long currentNumber = queue.Dequeue();
                long firstNumber = currentNumber + 1;
                long secondNumber = 2 * currentNumber + 1;
                long thirdNumber = currentNumber + 2;

                sequence.Add(firstNumber);
                sequence.Add(secondNumber);
                sequence.Add(thirdNumber);

                queue.Enqueue(firstNumber);
                queue.Enqueue(secondNumber);
                queue.Enqueue(thirdNumber);

            }
            Console.WriteLine(string.Join(" ", sequence.Take(50)));
        }
    }
}
