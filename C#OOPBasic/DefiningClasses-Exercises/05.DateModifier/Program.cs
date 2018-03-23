using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();
        Console.WriteLine(DateModifier.CalculateDateDifference(firstDate, secondDate));
    }
}

