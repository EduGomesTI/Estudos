using Exercicio01.Entities;
using Exercicio01.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Enter account data");
				Console.Write($"Number: ");
				int number = int.Parse(Console.ReadLine());
				Console.Write("Holder: ");
				string holder = Console.ReadLine();
				Console.Write("Initial balance: ");
				double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.Write("Withdraw limit: ");
				double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Account account = new Account(number, holder, initialBalance, withdrawLimit);
				Console.WriteLine();
				Console.Write("Enter ammount for withdraw: ");
				double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				account.WithDraw(withdraw);

			}
			catch (DomainException e)
			{
				Console.WriteLine($"Error in account: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"General Error: {e.Message}");
			}
        }
    }
}
