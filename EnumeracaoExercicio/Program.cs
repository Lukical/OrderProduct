using System.Globalization;
using EnumeracaoExercicio.Entities;
using EnumeracaoExercicio.Entities.Enums;

namespace EnumeracaoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(client, status, DateTime.Now);

            Console.Write("How many items to this order? ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                Product product = new Product(name, price);
                OrderItem item = new OrderItem(qtd, product);
                order.addItem(item);
            }
            Console.WriteLine(order);
        }
    }
}

