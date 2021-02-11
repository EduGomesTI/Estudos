using Aula21LinqLambda.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Aula21LinqLambda
{
    class Program
    {
        static void Print<T>(string message , IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2 , "Computers" , 1);
            Category c3 = new Category(3 , "Eletronics" , 1);

            List<Product> products = new List<Product>();

            products.Add(new Product(1 , "Computer" , 1100.0 , c2));
            products.Add(new Product(2 , "Hammer" , 90.0 , c1));
            products.Add(new Product(3 , "TV" , 1700.0 , c3));
            products.Add(new Product(4 , "Notebook" , 1300.0 , c2));
            products.Add(new Product(5 , "Saw" , 80.0 , c1));
            products.Add(new Product(6 , "Tablet" , 700.0 , c2));
            products.Add(new Product(7 , "Camera" , 700.0 , c2));
            products.Add(new Product(8 , "Printer" , 350.0 , c3));
            products.Add(new Product(9 , "MacBook" , 1800.0 , c2));
            products.Add(new Product(10 , "Sound Bar" , 700.0 , c3));
            products.Add(new Product(11 , "Level" , 70.0 , c1));

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;
            Print("Tier 1 And Price < 900:" , r1);

            Console.WriteLine();

            //var r2 = products.Where(p => p.Category.Id == 1).Select(p => p.Name);
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p.Name;
            Print("Name of Products From tools" , r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new { p.Name , p.Price , CategoryName = p.Category.Name };
            Print("Names Started with 'C' and Anonymous object" , r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;                     
            Print(" " , r4);

            var r5 = (from p in r4
                      select p).Skip(2).Take(4);
            Print("" , r5);

            var r6 = ( from p in products
                       select p ).First();
            Console.WriteLine($"First: {r6}");

            Console.WriteLine();

            var r7 = ( from p in products
                       where p.Price > 3000.00
                       select p ).FirstOrDefault();
            Console.WriteLine($"FirstOrDefault: {r7}");

            Console.WriteLine();

            var r8 = ( from p in products
                       where p.Id == 3
                       select p).SingleOrDefault(); 
            Console.WriteLine($"SingleOrDefault {r8}");

            Console.WriteLine();

            var r9 = ( from p in products
                       where p.Id == 30
                       select p ).SingleOrDefault();
            Console.WriteLine($"SingleOrDefault: {r9}");

            Console.WriteLine();

            var r10 = ( from p in products
                        select p.Price ).Max();
            Console.WriteLine($"Max: {r10}");

            Console.WriteLine();

            var r11 = ( from p in products
                        select p.Price ).Min();
            Console.WriteLine($"Min: {r11}");

            Console.WriteLine();

            var r12 = ( from p in products
                        where p.Category.Id == 1
                        select p ).Sum(p => p.Price);
            Console.WriteLine($"Sum: {r12}");

            Console.WriteLine();

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(r13);

            //Macete para não dar erro se não houver dados para o Average.
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); 
            Console.WriteLine(r14);

            //O 0.0 na expressão é uma sobrecarga que recebe um valor inicial caso a base de dados seja vazia.
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x , y) => x + y); 
            Console.WriteLine(r15);

            var r16 = from p in products
                      group p by p.Category;
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"{group.Key.Name} : ");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
