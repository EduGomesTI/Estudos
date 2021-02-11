using System;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores;

            valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0]);

            B = double.Parse(valores[1]);

            C = double.Parse(valores[2]);

            triangulo = (A * C) / 2;

            circulo = 3.14159 * Math.Pow(C, 2.0);

            trapezio = ((A + B) * C) / 2;

            quadrado = Math.Pow(B, 2.0);

            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}
