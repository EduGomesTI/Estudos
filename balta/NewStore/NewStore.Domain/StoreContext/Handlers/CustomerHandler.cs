using System;
using Flunt.Notifications;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using NewStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.ValueObjects;
using NewStore.Shared.Commands;
using NewStore.Domain.StoreContext.Services;
using NewStore.Domain.StoreContext.Repositories;

namespace NewStore.Domain.StoreContext.Handlers
{
    public class CustomerHandler :
        Notifiable,
        ICommandHandler<CreateCustomerCommand>,
        ICommandHandler<AddAddressCommand>
    {
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;
        public CustomerHandler(ICustomerRepository repository, IEmailService emailService)
            {
            _repository = repository;
            _emailService = emailService;
        }
        public ICommandResult Handle(CreateCustomerCommand command)
        {
            //Verficar se CPF já existe
            if (_repository.CheckDocument(command.DocumentNumber))
                AddNotification("DocumentNumber", "Este CPF já está em uso");
            //Verificar se E-mail já existe
            if (_repository.CheckEmail(command.EmailAddress))
                AddNotification("EmailAddress", "Este e-mail já está em uso");
            //Criar os VOs
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.DocumentNumber);
            var email = new Email(command.EmailAddress);

            //Criar Entidade
            var customer = new Customer(name, document, email, command.Phone);

            //Validar entidades e VOs
            AddNotifications(customer.Notifications);
            if (Invalid)
                return new CommandResult(false, "Por favor, corrija os campos abaixo", Notifications);

            //Persisitir o cliente
            _repository.Save(customer);
            //Enviar E-mail de boas vindas

            //Retornar o resultado para a tela
            return new CommandResult(true, "Cliente Cadastrado com sucesso", new
            {
                Id = customer.Id,
                Name = name.ToString(),
                Email = email.EmailAddress
        });
        }

        public ICommandResult Handle(AddAddressCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}