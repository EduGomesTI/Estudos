using System;
using System.Globalization;

namespace URI1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] ponto;
            string mensagem = "";

            ponto = Console.ReadLine().Split(' ');
            x = double.Parse(ponto[0], CultureInfo.InvariantCulture);
            y = double.Parse(ponto[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                mensagem = "Origem";
            }
            else if (x == 0 && y != 0)
            {
                mensagem = "Eixo X";
            }
            else if (x != 0 && y == 0)
            {
                mensagem = "Eixo Y";
            }
            else if (x > 0 && y > 0)
            {
                mensagem = "Q1";
            }
            else if (x < 0 && y > 0)
            {
                mensagem = "Q2";
            }
            else if (x < 0 && y < 0)
            {
                mensagem = "Q3";
            }
            else if (x > 0 && y < 0)
            {
                mensagem = "Q4";
            }
            Console.WriteLine(mensagem);
        }
    }
}
