using NewStore.Domain.StoreContext.Services;

namespace NewStore.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void send(string to, string from, string subject, string body)
        {
            
        }
    }
}