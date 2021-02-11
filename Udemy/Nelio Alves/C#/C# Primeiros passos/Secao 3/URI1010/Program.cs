using System;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, qtdePeca1, codPeca2, qtdePeca2;
            double valorPeca1, valorPeca2, total;

            string[] peca1 = Console.ReadLine().Split(' ');

            string[] peca2 = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(peca1[0]);

            qtdePeca1 = int.Parse(peca1[1]);

            valorPeca1 = double.Parse(peca1[2]);

            codPeca2 = int.Parse(peca2[0]);

            qtdePeca2 = int.Parse(peca2[1]);

            valorPeca2 = double.Parse(peca2[2]);

            total = qtdePeca1 * valorPeca1 + qtdePeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        }
    }
}
