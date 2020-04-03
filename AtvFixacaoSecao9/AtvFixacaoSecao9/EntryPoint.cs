using System;
using AtvFixacaoSecao9.Entities;
using AtvFixacaoSecao9.Entities.Enums;

namespace AtvFixacaoSecao9
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("E-mail:");
            String email = Console.ReadLine();
            Console.Write("Birth date: (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How much items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());



            for(int i = 0; i < quantityItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");                
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(productQuantity, price, product);
                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);






        }
    }
}
