using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal price, bool active)
        {
            AddNotifications(
                new Contract()
                .HasMinLen(title, 3, "Title", "Title dever conter mais que 3 caracteres.")
                .HasMaxLen(title, 50, "Title", "Titel deve conter menos de 50 caracteres.")
                .IsGreaterOrEqualsThan(price, 0, "Price", "Price deve ser igual ou maior que 0.")
            );
            Title = title;
            Price = price;
            Active = active;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }
    }
}