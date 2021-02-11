using System;

namespace Matrizes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma;
            string[] s;
            int[,] mat;

            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            //Somar e mostar resultado
            for (int i = 0; i < N; i++)
            {
                soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }
    }
}
