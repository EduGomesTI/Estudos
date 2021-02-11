using System;

namespace URI1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A < B)
            {
                C = B;
                B = A;
                A = C;
            }

            if (A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
