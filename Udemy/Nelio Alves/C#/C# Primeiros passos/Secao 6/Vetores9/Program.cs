using System;
using System.Globalization;

namespace Vetores9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, lucroBaixo, lucroNormal, lucroAlto;
            double valorTotalCompra, valorTotalVenda, lucroTotal;
            string[] s;

            //Conunto N de mercadorias definidas pelo usuário.
            N = int.Parse(Console.ReadLine());

            //Nome da mercadoria
            string[] mercadoria = new string[N];
            //Preço de compra
            double[] prcCompra = new double[N];
            //Preco de Venda
            double[] prcVenda = new double[N];
            //Inicialização das vars
            lucroBaixo = 0;
            lucroNormal = 0;
            lucroAlto = 0;
            lucroTotal = 0.0;
            valorTotalCompra = 0.0;
            valorTotalVenda = 0.0;

           
            for (int i = 0; i < N; i++)
            {
                //Cadastro de Dados nos vetores
                s = Console.ReadLine().Split(' ');
                mercadoria[i] = s[0];
                prcCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                prcVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                //Levantamento de lucro
                if (((prcVenda[i] / prcCompra[i] - 1)*100) < 10.0)
                {
                    lucroBaixo++;
                }
                else if (((prcVenda[i] / prcCompra[i] - 1) * 100) < 20.0)
                {
                    lucroNormal++;
                }
                else
                {
                    lucroAlto++;
                }

                //Valor total de compra e de venda
                valorTotalCompra = valorTotalCompra + prcCompra[i];
                valorTotalVenda = valorTotalVenda + prcVenda[i];

                //Lucro total
                lucroTotal = lucroTotal + (prcVenda[i] - prcCompra[i]);
            }

            //Visualização dos dados
            Console.WriteLine("Lucro abaixo de 10%: " + lucroBaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroNormal);
            Console.WriteLine("Lucro acima de 20%; " + lucroAlto);
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
