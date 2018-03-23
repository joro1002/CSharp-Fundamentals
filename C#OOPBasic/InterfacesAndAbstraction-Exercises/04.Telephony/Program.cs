using System;

namespace _04.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();
            var phone = new Phone();

            foreach (var number in numbers)
            {
                Console.WriteLine(phone.Calling(number));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(phone.Browsing(url));
            }
        }
    }
}
