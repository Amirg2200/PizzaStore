using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // Defines an Order containing a Pizza and a Customer, with methods for calculating total price and displaying order details.
    internal class Order
    {
        // Properties for associated pizza, topping, and customer.
        public Pizza Pizza { get; set; }
        public Topping Topping { get; set; }
        public Customer Customer { get; set; }

        // Constructor to initialize order with pizza, topping, and customer.
        public Order(Pizza pizza, Topping topping, Customer customer)
        {
            Pizza = pizza;
            Topping = topping;
            Customer = customer;
        }

        // Calculates the total price by adding pizza price, topping price, and a service charge.
        public decimal CalculateTotalPrice() => Pizza.Price + Topping.Price + 40;

        // Method to return order details as a string.
        public override string ToString() => $"{Pizza}\n{Topping}\n{Customer}\nTotal Price: {CalculateTotalPrice()} kr.";
    }
}
