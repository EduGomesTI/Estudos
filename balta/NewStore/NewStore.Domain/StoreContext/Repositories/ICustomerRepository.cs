using System.Collections.Generic;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.Queries;

namespace NewStore.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
         bool CheckDocument(string document);
         bool CheckEmail(string email);
        void Save(Customer customer);
        CustomerOrdersCountResult GetCustomerOrdersCount(string document);
        IEnumerable<ListCustomerQueryResult> Get();
    }
}