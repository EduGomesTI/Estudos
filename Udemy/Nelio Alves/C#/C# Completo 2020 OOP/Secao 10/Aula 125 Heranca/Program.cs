using Aula_125_Heranca.Entities;
using System;

namespace Aula_125_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            // BusinessAccount acc5 = (BusinessAccount)acc3; Dá erro em tempo de execução.

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Forma alternativa de Casting
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");


                //Virtual, Override e Base
                Account acc11 = new Account(1001, "Alex", 500.0);
                Account acc12 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

                acc11.Withdraw(10.0);
                acc12.Withdraw(10.0);

                Console.WriteLine(acc11.Balance);
                Console.WriteLine(acc12.Balance);
            }
        }
    }
}
