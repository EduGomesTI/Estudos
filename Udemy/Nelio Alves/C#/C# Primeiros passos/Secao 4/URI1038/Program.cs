using System;
using System.Globalization;

namespace URI1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, qtde;
            double valor;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);

            if (codigo == 1)
            {
                valor = qtde * 4.0;
            }
            else if (codigo == 2)
            {
                valor = qtde * 4.5;
            }
            else if (codigo == 3)
            {
                valor = qtde * 5.0;
            }
            else if (codigo == 4)
            {
                valor = qtde * 2.0;
            }
            else
            {
                valor = qtde * 1.5;
            }
            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
