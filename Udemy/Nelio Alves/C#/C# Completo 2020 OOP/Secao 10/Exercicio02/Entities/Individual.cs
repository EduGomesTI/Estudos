using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Exercicio02.Entities
{
    class Individual : Taxpayer
    {
        public double HealthSpending { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthSpending):base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxToPay()
        {
            double tax = (AnnualIncome < 20000.00) ? (AnnualIncome * 0.15) : (AnnualIncome * 0.25);

            double health = (HealthSpending > 0) ? (HealthSpending * 0.50) : 0.0;

            return tax - health;
        }

        public override string ToString()
        {
            return $"{Name}: $ {TaxToPay().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
