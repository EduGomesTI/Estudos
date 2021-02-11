using Aula_11_Enumeradores.Entities;
using Aula_11_Enumeradores.Entities.Enums;
using System;

namespace Aula_11_Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
