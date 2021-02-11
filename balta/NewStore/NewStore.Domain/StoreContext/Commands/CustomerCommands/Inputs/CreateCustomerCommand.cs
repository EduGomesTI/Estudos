using Flunt.Notifications;
using NewStore.Domain.StoreContext.Entities;
using NewStore.Domain.StoreContext.ValueObjects;
using NewStore.Shared.Commands;

namespace NewStore.Domain.StoreContext.Commands.CustomerCommands.Inputs
{

    public class CreateCustomerCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName  {get ; set; }
        public string DocumentNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }

        public new bool Valid()
        {        
            return true;
        }
    }    
}
