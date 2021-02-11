using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] s, s1;
            int[,] A, B, C;

            //Obter tamanho das matrizes
            s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            //Inicializar matrizes
            A = new int[M, N];
            B = new int[M, N];
            C = new int[M, N];

            //Primeira matriz
            for (int i = 0; i < M; i++)
            {
                s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s1[j]);
                }
            }

            //Segunda matriz
            for (int i = 0; i < M; i++)
            {
                s1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(s1[j]);
                }
            }

            //Realizar a soma na terceira matriz
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
