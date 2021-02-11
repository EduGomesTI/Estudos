using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MaiorAB, MaiorGeral;

            string[] valor;

            valor = Console.ReadLine().Split(' ');

            A = int.Parse(valor[0]);

            B = int.Parse(valor[1]);

            C = int.Parse(valor[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            MaiorGeral = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(MaiorGeral + " eh o maior");
        }
    }
}
