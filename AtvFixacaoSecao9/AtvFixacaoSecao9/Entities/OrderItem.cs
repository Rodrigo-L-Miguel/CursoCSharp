using System;
using System.Collections.Generic;
using System.Text;

namespace AtvFixacaoSecao9.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            return Product.Name + ", $" 
                + Price + 
                "Quantity: " + 
                Quantity + 
                ", Subtotal: $" + 
                SubTotal();
        }

    }
}
