using System;
using System.Globalization;

namespace URI1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            string intervalo;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.0 && valor <= 25.0)
            {
                intervalo = "Intervalo [0,25]";
            }
            else if (valor > 25.0 && valor <= 50.0)
            {
                intervalo = "Intervalo (25,50]";
            }
            else if (valor > 50.0 && valor <= 75)
            {
                intervalo = "Intervalo (50,75]";
            }
            else if (valor > 75.0 && valor <= 100.0)
            {
                intervalo = "Intervalo (75,100]";
            }
            else
            {
                intervalo = "Fora de intervalo";
            }
            Console.WriteLine(intervalo);
        }
    }
}
