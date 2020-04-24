using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AtvFixacaoSecao9.Entities.Enums;

namespace AtvFixacaoSecao9.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus orderStatus, Client client)
        {
            Moment = DateTime.Now;
            OrderStatus = orderStatus;
            Client = client;
        }
        
        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        
        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }
        
        public void PrintItens()
        {
            foreach(OrderItem item in OrderItems)
            {
                Console.WriteLine(item);
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
