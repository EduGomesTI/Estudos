using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {
          
        }

        public bool DocumentExist(string document)
        {
           return document == "27114498829" ? true : false;
        }

        public bool EmailExist(string email)
        {
            return email == "edu@gmail.com" ? true : false;
        }
    }
}