using Aula232Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Aula232Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter full file path: ");
            string path = @"c:\lixo\func.csv";
            Console.Write("Enter Salary:");
            double salary = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Email of people whose salary is more than {salary}:");

            List<Employee> emp = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string name = campos[0];
                    string email = campos[1];
                    double salaryEmp = double.Parse(campos[2], CultureInfo.InvariantCulture);
                    emp.Add(new Employee(name , email , salaryEmp));
                }
            }

            IEnumerable<string> emails = from e in emp
                         where e.Salary > salary
                         orderby e.Email
                         select e.Email;
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            double sumSalary = ( from s in emp
                                            where s.Name[0] == 'M'
                                            select s.Salary ).Sum();
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': ${sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
