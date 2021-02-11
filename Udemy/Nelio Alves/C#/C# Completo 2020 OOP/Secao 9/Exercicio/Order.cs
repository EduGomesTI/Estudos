using Exercicio.Entities;
using Exercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Exercicio
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } = new OrderStatus();
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client = new Client();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public  double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += (item.Price * item.Quantity);             
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order items:");
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.Product.Name + " $" + item.Price + ", Quantity: " + item.Quantity + ", Subtotal: $" + item.SubTotal(item.Quantity, item.Price).ToString("F2", CultureInfo.InvariantCulture));
                sum += item.SubTotal(item.Quantity, item.Price);
            }
            sb.AppendLine("Total Price: $" + sum);
            return sb.ToString();
        }
    }
}
