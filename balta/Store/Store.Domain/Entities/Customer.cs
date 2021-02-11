using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Customer: Entity
    {
        public Customer(string name, string email)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(name, 3, "Name", "O Nome deve ter no mínimo 3 caracteres.")
                .HasMaxLen(name, 50, "Name", "O campo Name deve ter no máximo 50 caracteres.")
                .IsEmail(email, "Email", "E-mail inválido.")
            );
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}