using Flunt.Notifications;
using Flunt.Validations;

namespace NewStore.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string emailAddress)
        {
            ChangeEmailAddress(emailAddress);
        }

        public string EmailAddress { get; private set; }

        public void ChangeEmailAddress(string email)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsEmail(email, "EmailAddress", "E-mail inválido.")
            );
            EmailAddress = email;
        }

        public override string ToString()
        {
            return EmailAddress;
        }
    }
}