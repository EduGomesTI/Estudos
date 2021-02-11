using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Exercicio02.Entities
{
    class Company : Taxpayer
    {
        public int EmployeeNumber { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int employeeNumber):base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxToPay()
        {
            return (EmployeeNumber < 10) ? AnnualIncome * 0.16 : AnnualIncome * 0.14;            
        }

        public override string ToString()
        {
            return $"{Name}: $ {TaxToPay().ToString("F2", CultureInfo.InvariantCulture)}";;
        }
    }
}
