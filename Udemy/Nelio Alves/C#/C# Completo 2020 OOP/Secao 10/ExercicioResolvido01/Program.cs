using ExercicioResolvido01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number of Employees
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // EMployees data
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee e = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(e);

                }
                else
                {
                    Employee e = new Employee(name, hours, valuePerHour);
                    employees.Add(e);
                }               
            }
            
            Console.WriteLine();

            //Print
            Console.WriteLine("PAYMENTS");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
