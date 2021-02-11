using NewStore.Domain.StoreContext.Services;

namespace NewStore.Infra.Services
{
    public class EmailService : IEmailService
    {
        public void send(string to, string from, string subject, string body)
        {
            //TODO Implementar
        }
    }
}