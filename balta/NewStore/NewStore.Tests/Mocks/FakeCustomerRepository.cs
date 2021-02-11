using System.Collections.Generic;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.Queries;
using NewStore.Domain.StoreContext.Repositories;

namespace NewStore.Tests.Mocks
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public bool CheckDocument(string document)
        {
            return false;
        }

        public bool CheckEmail(string email)
        {
            return false;
        }

        public CustomerOrdersCountResult GetCustomerOrdersCount(string document)
        {
            var orders = new CustomerOrdersCountResult();
            return orders;
        }
        public void Save(Customer customer)
        {
           
        }

        IEnumerable<ListCustomerQueryResult> ICustomerRepository.Get()
        {
            throw new System.NotImplementedException();
        }
    }
}