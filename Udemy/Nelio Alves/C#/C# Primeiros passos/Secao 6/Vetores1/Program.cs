using System;
using System.Globalization;

namespace Vetores1
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior;
            int posicao, N;
         
            posicao = 0;
            maior = 0;
            N = int.Parse(Console.ReadLine());
            double[] numeros = new double[N];
            string[] s = Console.ReadLine().Split(" ");

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
            Console.ReadLine();



        }
    }
}
