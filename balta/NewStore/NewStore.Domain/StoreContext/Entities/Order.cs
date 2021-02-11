using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using NewStore.Domain.StoreContext.Enums;
using NewStore.Shared.Entities;

namespace NewStore.Domain.StoreContext.Entities
{
    public class Order : Entity
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer    = customer;
            CreateDate = DateTime.Now;
            Status      = EOrderStatus.Created;
            _items       = new List<OrderItem>();
            _deliveries  = new List<Delivery>();
        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _deliveries.ToArray();

        public void AddItem(Product product, decimal quantity)
        {
            //Validar item
            AddNotifications(
                new Contract()
                .Requires()
                .IsGreaterOrEqualsThan(quantity, product.QuantityOnHand, "Product.QuantityOnHand", $"{product.Title} não tem {quantity} em estoque.")
            );
            var item = new OrderItem(product, quantity);
            _items.Add(item);
        }

        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        //Criar um Pedido
        public void Place()
        {
            //Gera o número do pedido
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            //Validar
        }

        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }

        public void Ship()
        {
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;
            foreach (var item in _items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;
            }

            //* Envia todas as entregas
            deliveries.ForEach(x => x.Ship());

            //* Adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));
        }

        //* Cancela um pedido
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            _deliveries.ToList().ForEach(x => x.Cancel());
        }
    }
}