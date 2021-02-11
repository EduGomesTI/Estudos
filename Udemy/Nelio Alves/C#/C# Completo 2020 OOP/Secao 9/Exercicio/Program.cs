using Exercicio.Entities;
using Exercicio.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            string birthDate = Console.ReadLine();
            Console.WriteLine("Emter Order data:");
            Client client = new Client(name, email, DateTime.Parse(birthDate));
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtdeItems = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= qtdeItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);                
                order.AddItem(orderItem);
            }

            Console.WriteLine();

            Console.WriteLine(order);
        }
    }
}
