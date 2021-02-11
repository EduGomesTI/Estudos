using System;
using System.Globalization;

namespace Matrizes6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, indiceMatriz;
            double[,] A;
            string[] s;
            double somaPositivos;

            //Incializa var
            somaPositivos = 0.0;

            //Determinar o tamanho da matriz
            N = int.Parse(Console.ReadLine());

            //Alocar a matriz
            A = new double[N, N];

            //Preencher a matriz
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                    //Calcula a soma dos positivos
                    if (A[i,j] > 0)
                    {
                        somaPositivos = somaPositivos + A[i, j];
                    }
                }
            }
            //Exibe a soma dos positivos
            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));

            //Leitura do índice
            indiceMatriz = int.Parse(Console.ReadLine());

            //Imprime os elementos da linha do índice escolhido
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[indiceMatriz, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            //Pula uma linha
            Console.WriteLine();

            //Leitura do índice
            indiceMatriz = int.Parse(Console.ReadLine());

            //Imprime os elementos da coluna do índice
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, indiceMatriz].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            //Pula uma linha
            Console.WriteLine();

            //Imprime a diagonal principal da matriz
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            //Pula uma linha
            Console.WriteLine();

            //Eleva os números negativos ao quadrado e imprime a nova matriz;
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        A[i, j] = Math.Pow(A[i, j], 2.0);                        
                    }
                    Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
