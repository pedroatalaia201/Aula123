using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicoProposto.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Products { get; set; }

        public OrderItem() {
        }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Products = product;
        }
    }
}
