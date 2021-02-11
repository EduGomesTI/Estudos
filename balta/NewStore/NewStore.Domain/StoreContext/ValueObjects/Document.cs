using Flunt.Notifications;
using Flunt.Validations;

namespace NewStore.Domain.StoreContext.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(string number)
        {
            ChangeDocument(number);
        }

        public string Number { get; private set; }

        public void ChangeDocument(string number)
        {
            //* Apenas simula um campo de cpf, sem nehuma validação a não ser o tamanho.
            AddNotifications(
                new Contract()
                .Requires()
                .HasLen(number, 11, "Number","Documento deve ter 11 caracteres.")
            );
            Number = number;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}