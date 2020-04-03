using System;
using System.Collections.Generic;
using System.Text;
using AtvFixacaoSecao9.Entities.Enums;

namespace AtvFixacaoSecao9.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
            Date = DateTime.Now;
        }

        public Order(OrderStatus orderStatus, Client client)
        {
            Date = DateTime.Now;
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
        
    }
}
