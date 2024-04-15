using System.Globalization;
using System.Text;

namespace EnumeracaoExercicio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set;}
        public Product Product { get; set;}
        public OrderItem() { }
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }
        public double subTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Product.Name}, Quantity: {Quantity}, Subtotal: ${this.subTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
