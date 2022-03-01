using System;
using System.Collections.Generic;
using ex1HeP.Entities;
using System.Globalization;

namespace ex1HeP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter for number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (r == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (r == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs Fee: ");
                    double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cf));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
