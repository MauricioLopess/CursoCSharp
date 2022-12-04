using System;
using ExerciciosEnumEConst.ex03.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosEnumEConst.ex03.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Client Client { get; set; }

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

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.AppendLine("ORDER SUMMARY");
            sBuilder.AppendLine($"Order moment: {Moment:dd/MM/yyyy HH:mm:ss}");
            sBuilder.AppendLine($"Order status: {Status}");
            sBuilder.AppendLine($"Client: {Client.Name} ({Client.BirthDate:dd/MM/yyyy}) - {Client.Email}");
            sBuilder.AppendLine("Order items: ");
            foreach (OrderItem i in Items)
            {
                sBuilder.AppendLine($"{i.Product.Name}, {i.Product.Price}, quantity: {i.Quantity}, subtotal: R$ {i.SubTotal()} ");
            }
            sBuilder.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sBuilder.ToString();
        }
    }
}
