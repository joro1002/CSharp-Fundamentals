using System;

namespace _02.BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string title = Console.ReadLine();
                string author = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
