using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Discount: Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            AddNotifications(
                new Contract()
                .IsGreaterOrEqualsThan(amount, 0, "Amount", "O valor deve ser maior ou igula a 0.")
                .IsGreaterThan(expireDate, DateTime.Now, "ExpireDate", "A data dever ser maior que a data atual.")
            );
            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public bool Isvalid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value()
        {
            if(Isvalid())
            {
                return Amount;
            }
            else
            {
                return 0;
            }
        }

    }
}