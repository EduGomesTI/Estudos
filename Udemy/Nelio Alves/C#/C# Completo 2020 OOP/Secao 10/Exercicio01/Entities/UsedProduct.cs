using System;
using System.Globalization;

namespace Exercicio01.Entities
{
   sealed class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate): base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufactured date: {ManufacturedDate.ToShortDateString()})";
        }
    }
}
