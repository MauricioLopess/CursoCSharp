using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEnumEConst.ex03.Entities
{
    internal class OrderItem
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
            Price = Product.Price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
