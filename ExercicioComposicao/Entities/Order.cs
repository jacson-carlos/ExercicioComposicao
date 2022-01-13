using System;
using System.Collections.Generic;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order( OrderStatus status, Client client)
        {
            Date = DateTime.Now;
            Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void Removeitem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                
                sum += item.SubTotal();
            }

            return sum;
        }


        public override string ToString()
        {
            return "Order moment: "
                + Date 
                + "\r\nOrder Status: "
                + Status
                + $"\r\nClient: {Client.Name} ({Client.BirthDate}) - {Client.Email}";
        }
    }
}
