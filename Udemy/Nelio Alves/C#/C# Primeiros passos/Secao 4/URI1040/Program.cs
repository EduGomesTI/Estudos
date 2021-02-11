using System;
using System.Globalization;

namespace URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, exame;
            string[] notas;

            notas = Console.ReadLine().Split(' ');
            N1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + exame) / 2;
                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
