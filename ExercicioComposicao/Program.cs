using System;
using System.Globalization;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;
namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter order data: ");

            Console.Write("Order status");
            OrderStatus Status = Enum.Parse<OrderStatus>( Console.ReadLine());
            Console.Write("Hoe many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(Name, Email, BirthDate);
            Order order = new Order( Status, client);
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());
                Product product = new Product(ProductName, ProductPrice);
                OrderItem item = new OrderItem(Quantity, ProductPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.WriteLine("Order items: ");
            foreach(OrderItem item in order.Items) 
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"Total price: ${order.Total()}");

        }
    }
}
