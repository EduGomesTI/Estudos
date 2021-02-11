using System;
using System.Collections.Generic;
using Flunt.Notifications;
using NewStore.Shared.Commands;

namespace NewStore.Domain.StoreContext.Commands.OrderCommands.Inputs
{
    public class PlaceOrderCommand : Notifiable, ICommand
    {

        public PlaceOrderCommand()
        {
            OrderItems = new List<OrderItemCommand>();
        }

        public Guid Customer { get; set; }
        public IList<OrderItemCommand> OrderItems { get; set; }

        public new bool Valid()
        {
            throw new NotImplementedException();
        }
    }

    public class OrderItemCommand
    {
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }

        public bool Valid()
        {
            throw new NotImplementedException();
        }
    }

}