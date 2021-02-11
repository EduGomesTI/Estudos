using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Taxpayer> payers = new List<Taxpayer>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payers.Add(new Individual(name, income, healt));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, income, employee));
                }                
            }
            Console.WriteLine();

            Console.WriteLine("TAX PAID:");
            foreach (Taxpayer payer in payers)
            {
                Console.WriteLine(payer);
            }

            double sum = 0.0;

            foreach (Taxpayer payer in payers)
            {
                sum += payer.TaxToPay();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
