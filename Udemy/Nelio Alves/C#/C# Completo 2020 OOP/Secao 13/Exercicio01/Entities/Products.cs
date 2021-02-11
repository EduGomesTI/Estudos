using System.Globalization;

namespace Exercicio01.Entities
{
    class Products
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }

        public Products()
        {

        }

        public Products(string name, double value, int quantity)
        {
            Name = name;
            Value = value;
            Quantity = quantity;
        }

        public double TotalValue(double value, int quantity)
        {
            return value * quantity;
        }

        public string LineItem()
        {
            return $"{Name}, {TotalValue(Value, Quantity).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
