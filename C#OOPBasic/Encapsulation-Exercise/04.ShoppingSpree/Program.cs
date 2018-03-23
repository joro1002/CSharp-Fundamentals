using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = ParsePeople();
                List<Product> products = ParseProduct();

                BuyProducts(people, products);

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void BuyProducts(List<Person> people, List<Product> products)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = tokens[0];
                var productName = tokens[1];

                Person person = people.First(p => p.Name == personName);
                Product product = products.First(p => p.Name == productName);

                string output = person.BuyProduct(product);

                Console.WriteLine(output);


                command = Console.ReadLine();

            }
        }


        private static List<Product> ParseProduct()
        {
            var inputProduct = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();

            foreach (var productInput in inputProduct)
            {
                var tokens = productInput.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string productName = tokens[0];
                decimal productPrice = decimal.Parse(tokens[1]);

                var product = new Product(productName, productPrice);
                products.Add(product);
            }
            return products;

        }

        private static List<Person> ParsePeople()
        {
            var inputPeople = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();

            foreach (var inputPerson in inputPeople)
            {
                var tokens = inputPerson.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);

                var person = new Person(name, money);
                people.Add(person);

            }
            return people;
        }
    }
}


