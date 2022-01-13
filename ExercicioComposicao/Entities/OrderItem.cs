using System.Globalization;
using ExercicioComposicao.Entities;
namespace ExercicioComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Name { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Name = product;
        }

        public double SubTotal()
        {
            return  (Quantity) * Price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${SubTotal()}";
        }
    }
}
