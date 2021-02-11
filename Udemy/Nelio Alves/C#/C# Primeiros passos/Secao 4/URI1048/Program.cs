using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0)
            {
                percentual = 15;
            }
            else if ( salario <= 800.0)
            {
                percentual = 12;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }
            reajuste = (salario * percentual) / 100;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
