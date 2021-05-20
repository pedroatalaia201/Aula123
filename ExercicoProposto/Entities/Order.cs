using System;
using System.Collections.Generic;
using ExercicoProposto.Entities.Enums;

namespace ExercicoProposto.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();

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

            foreach (var price in Orders) {
                if(price.Price != 0.0) {
                    total += price.Price;
                }
            }

            return total;
        }

    }
}
