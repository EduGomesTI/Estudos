using System;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());

            horasTrabalhadas = int.Parse(Console.ReadLine());

            valorHora = double.Parse(Console.ReadLine());

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);

            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
