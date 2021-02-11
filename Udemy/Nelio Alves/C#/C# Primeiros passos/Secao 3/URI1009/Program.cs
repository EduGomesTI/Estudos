using System;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, totalVendas, totalFimDoMes;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            totalVendas = double.Parse(Console.ReadLine());

            totalFimDoMes = salarioFixo + (totalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalFimDoMes.ToString("F2"));
        }
    }
}
