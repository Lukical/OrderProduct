using System.Globalization;
using System.Text;
using EnumeracaoExercicio.Entities.Enums;

namespace EnumeracaoExercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order() { }
        public Order(Client client, OrderStatus status, DateTime moment) 
        {
            Client = client;
            Status = status;
            Moment = moment;
        }
        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                sum += Items[i].subTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} {Client.BirthDate} - {Client.Email}");
            sb.AppendLine("Order Items: ");
            for (int i = 0; i < Items.Count; i++)
            {
                sb.Append(Items[i].ToString());
            }
            sb.AppendLine($"Total price: ${this.Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
