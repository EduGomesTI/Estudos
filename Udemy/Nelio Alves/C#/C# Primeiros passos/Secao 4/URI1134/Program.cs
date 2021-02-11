using System;

namespace URI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, qtdeAlcool, qtdeGasolina, qtdeDiesel;

            codigo = int.Parse(Console.ReadLine());

            qtdeAlcool = 0;
            qtdeDiesel = 0;
            qtdeGasolina = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    qtdeAlcool += 1;
                }    
                else if (codigo == 2)
                {
                    qtdeGasolina += 1;
                }
                else if (codigo == 3)
                {
                    qtdeDiesel += 1;
                }
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + qtdeAlcool);
            Console.WriteLine("Gasolina: " + qtdeGasolina);
            Console.WriteLine("Diesel: " + qtdeDiesel);
        }
    }
}
