using System;

namespace URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, soma, min, max;

            N = int.Parse(Console.ReadLine());            

            for (int i = 1; i < N; i++)
            {
                soma = 0;
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                if ( x < y)
                {
                    min = x;
                    max = y;
                }
                else
                {
                    min = y;
                    max = x;
                }
                for (int f = min + 1; f < max; f++)
                {
                    if (f % 2 != 0)
                    {
                        soma = soma + f;
                    }                    
                }
                Console.WriteLine(soma);
            }
        }
    }
}
