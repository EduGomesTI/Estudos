using Aula231Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Aula231Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = @"c:\lixo\product.csv";

            List<Product> list = new List<Product>();
            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1] , CultureInfo.InvariantCulture);
                    list.Add(new Product(name , price));
                }
            }

            Console.WriteLine();

            double r1 = ( from l in list
                       select l.Price ).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average Price: ${r1.ToString("F2" , CultureInfo.InvariantCulture)}");

            Console.WriteLine();

            IEnumerable<string> r2 = ( from l in list
                       where l.Price < r1
                       orderby l.Name descending
                       select l.Name );
            foreach(string n in r2)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
