using Flunt.Notifications;
using Flunt.Validations;

namespace NewStore.Domain.StoreContext.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            ChangeName(firstName, lastName);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public void ChangeName(string firstName, string lastName)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(firstName, 3, "FirstName", "Nome não pode ter menos que 3 caracteres.")
                .HasMaxLen(firstName, 20, "FirstName", "Nome não pode ter mais que 20 caracteres.")
                .HasMinLen(lastName, 3, "LastName", "Nome não pode ter menos que 3 caracteres.")
                .HasMaxLen(lastName, 20, "LastName", "Nome não pode ter mais que 20 caracteres.")
            );
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}