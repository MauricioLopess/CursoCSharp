using System;
using ExerciciosEnumEConst.ex03.Entities.Enums;
using System.Collections.Generic;


namespace ExerciciosEnumEConst.ex03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }
    }
}
