using System.Data;
using System.Linq;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.Repositories;
using Dapper;
using NewStore.Infra.StoreContext.DataContexts;
using NewStore.Domain.StoreContext.Queries;
using System.Collections.Generic;

namespace NewStore.Infra.StoreContext.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public bool CheckDocument(string document)
        {
            var qtde = _context
                 .Connection
                 .Query<int>(
                     $"sp_CheckDocument",
                     new
                     {
                         _document = document
                     },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();

            return (qtde > 0) ? true : false;
        }

        public bool CheckEmail(string email)
        {
             var qtde = _context
                 .Connection
                 .Query<int>(
                     "sp_checkemail",
                     new
                     {
                         _email = email
                     },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();

            return (qtde > 0) ? true : false;
        }

        public CustomerOrdersCountResult GetCustomerOrdersCount(string document)
        {
            return  _context
                 .Connection
                 .Query<CustomerOrdersCountResult>(
                     "sp_GetCustomerOrdersCount",
                     new
                     {
                         _document = document
                     },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
    
        }

        public IEnumerable<ListCustomerQueryResult> Get()
        {
            return  _context
                    .Connection
                    .Query<ListCustomerQueryResult>("SELECT * FROM vw_customers");    
        }

        public void Save(Customer customer)
        {
            _context.Connection.Execute(
                "sp_CreateCustomerWithAddress",
                new
                {
                    _firstname = customer.Name.FirstName,
                    _lastname = customer.Name.LastName,
                    _document = customer.Document.Number,
                    _email = customer.Email.EmailAddress,
                    _phone = customer.Phone
                },
                    commandType: CommandType.StoredProcedure
                );

            var lastCustomerId = _context
                .Connection
                .Query<int>(
                    "sp_last_id",
                    new { _table = "customer" },
                    commandType: CommandType.StoredProcedure
                )
                .FirstOrDefault();

            foreach (var address in customer.Addresses)
            {
                _context.Connection.Execute("sp_createaddress",
                new
                {
                    _customerId = lastCustomerId,
                    _street = address.Street,
                    _number = address.Number,
                    _complement = address.Complement,
                    _district = address.District,
                    _city = address.City,
                    _state = address.State,
                    _country = address.Country,
                    _zipCode = address.ZipCode,
                    _type = address.Type
                },
                commandType: CommandType.StoredProcedure);
            }
        }
    }
}