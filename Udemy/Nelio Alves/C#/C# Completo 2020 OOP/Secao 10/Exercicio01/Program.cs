using Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number of Products
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            //Products data
            List<Product> products = new List<Product>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (ch)
                {
                    case 'i': //Imported
                        Console.Write("Custom fee: ");
                        double custoFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, custoFee));
                        break;
                    case 'u': //Used
                        Console.Write("Manufacure date (DD/MM/YYYY): ");
                        DateTime manufacureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufacureDate));
                        break;
                    default: //Common
                        products.Add(new Product(name, price));
                        break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
