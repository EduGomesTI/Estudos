using System;

namespace Matrizes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maior;
            string[] s;
            int[,] mat;

            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                maior = 0;
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                    if (mat[i,j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
            Console.ReadLine();
        }
    }
}
