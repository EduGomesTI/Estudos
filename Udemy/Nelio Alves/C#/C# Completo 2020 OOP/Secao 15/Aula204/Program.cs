using System;
using Aula204.Extensions;

namespace Aula204
{
    class Program
    {
        static void Main(string[] args)
        {
            DiferencaDatas dt = new DiferencaDatas();

            dt.DataInicial = DateTime.Parse("23/04/2020 8:00");

            dt.DataFinal = DateTime.Parse("23/04/2020 08:30");

            Console.WriteLine(dt.DifDataAtual());

            Console.WriteLine(dt.DifDuasDatas());
        }
    }
}
