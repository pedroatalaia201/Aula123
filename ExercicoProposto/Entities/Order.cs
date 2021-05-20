using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicoProposto.Entities.Enums;

namespace ExercicoProposto.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
        public OrderItem Item { get; set; }

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status) {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem order) {
            Orders.Add(order);
        }

        public void RemoveItem(OrderItem order) {
            Orders.Remove(order);
        }

        public double Total() {
            double total = 0;
            double aux = 0;

            foreach (OrderItem item in Orders) {
                aux = item.Price * item.Quantity;
                total += aux;
            }

            return total;
        }

      public void GetList() {
            foreach (OrderItem item in Orders) {
                Console.WriteLine(item.Products.Name + ", $" + item.Price.ToString("F2", CultureInfo.InvariantCulture) + 
                    ", Quantity: " + item.Quantity + "Subtotal: $" + item.SubTotal());
            }
            Console.WriteLine("Total price $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
