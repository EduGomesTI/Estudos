using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.Handlers;
using NewStore.Domain.StoreContext.Queries;
using NewStore.Domain.StoreContext.Repositories;
using NewStore.Domain.StoreContext.ValueObjects;
using NewStore.Shared.Commands;

namespace NewStore.Api.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repository;
        private readonly CustomerHandler _handler;

        public CustomerController(ICustomerRepository repository, CustomerHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/customers")]
        [ResponseCache(Duration = 15)]
        public IEnumerable<ListCustomerQueryResult> Get()
        {
            return _repository.Get();
        }

        [Route("v1/customers/{id}")]
        [HttpGet]
        public Customer GetById(int id)
        {
            var name = new Name("Eduardo", "Gomes");
            var document = new Document("27114498829");
            var email = new Email("edu@gmail.com");
            var customer = new Customer(name, document, email, "983995714");
            return customer;

        }

        [Route("v1/customers/{id}/orders")]
        [HttpGet]
        public List<Order> GetOrders(int id)
        {
            return null;
        }

        [HttpPost]
        [Route("v1/customers")]
        public ICommandResult Post([FromBody]CreateCustomerCommand command)
        {
            var result = _handler.Handle(command);
            return result;
        }

        [Route("v1/customer/{id}")]
        [HttpPut]
        public Customer Put([FromBody] Customer customer)
        {
            return null;
        }

        [Route("v1/customer/{id}")]
        [HttpDelete]
        public object Delete()
        {
            return new { message = "Cliente removido com sucesso." };
        }

    }
}