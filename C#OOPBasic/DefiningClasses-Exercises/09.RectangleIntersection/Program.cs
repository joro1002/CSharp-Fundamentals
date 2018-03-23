using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new List<Rectangle>();

            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var numberOfRectangles = int.Parse(input[0]);
            var intersectionChecks = int.Parse(input[1]);

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var rectangle = new Rectangle(tokens[0],
                    double.Parse(tokens[1]),
                    double.Parse(tokens[2]),
                    double.Parse(tokens[3]),
                    double.Parse(tokens[4]));
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var firstRectangle = rectangles.FirstOrDefault(r => r.ID == tokens[0]);
                var secondRectangle = rectangles.FirstOrDefault(r => r.ID == tokens[1]);

                if (firstRectangle == null || secondRectangle == null)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine(firstRectangle.IntersectsRectangle(secondRectangle) ? "true" : "false");
                }
            }
        }
    }
}
