using System;
using System.Globalization;
using ExercicoProposto.Entities;
using ExercicoProposto.Entities.Enums;

namespace ExercicoProposto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string e_mail = Console.ReadLine();

            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, e_mail, birth);

            Console.WriteLine("\nEnter order data:");

            DateTime moment = DateTime.Now;

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How may itens to this order?  ");
            int itens = int.Parse(Console.ReadLine());

            Order order = new Order(moment, status);
            Product product = new Product();

            for (int i = 1; i <= itens; i++) {
                Console.WriteLine($"\nEnter the {i} iten data:");

                Console.Write("Product Name: ");
                string prod = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                product = new Product(prod, price);
                order.AddItem(new OrderItem(quant, price, product));
            }

            Console.WriteLine("\nORDER SUMMARY:\n");

            Console.WriteLine("Order moment: " + order.Moment.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine("Order stauts: " + order.Status.ToString());
            Console.WriteLine("Client: " + client.Name + "(" + client.BirthDate.ToString("dd/MM/yyyy") + ") -" +
                 client.Email);
            Console.WriteLine("Order Itens");
          
            order.GetList();

            Console.ReadKey();
        }
    }
}
