using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // Contains the logic for running the pizza store, handling user input, and displaying output.
    internal class Store
    {
        // Main method to start the store interaction.
        public static void Start()
        {
            // Welcomes the user to the Pizzaria.
            Console.WriteLine("Welcome to Big Mama Pizzaria!");

            // Display available pizza types and prices.
            Console.WriteLine("Available Pizza Types:");
            Console.WriteLine("1. Margherita - 60 kr.");
            Console.WriteLine("2. Pepperoni - 75 kr.");
            Console.WriteLine("3. Vegetarian - 65 kr.");
            Console.WriteLine("The service charge is 40 kr.");
            Console.Write("Enter the number for your chosen Pizza type: ");

            // Parse and validate pizza choice input.
            if (int.TryParse(Console.ReadLine(), out int pizzaChoice) && pizzaChoice >= 1 && pizzaChoice <= 3)
            {
                // Retrieve pizza type and price based on choice.
                (string pizzaType, decimal pizzaPrice) = GetPizzaTypeAndPrice(pizzaChoice);

                // Display available toppings and prices.
                Console.WriteLine("Available Toppings:");
                Console.WriteLine("1. Cheese - 10 kr.");
                Console.WriteLine("2. Chilli - 15 kr.");
                Console.WriteLine("3. Mushrooms - 12 kr.");
                Console.Write("Enter the number for your chosen topping: ");

                // Parse and validate topping choice input.
                if (int.TryParse(Console.ReadLine(), out int toppingChoice) && toppingChoice >= 1 && toppingChoice <= 3)
                {
                    // Retrieve topping type and price based on choice.
                    (string toppingName, decimal toppingPrice) = GetToppingTypeAndPrice(toppingChoice);

                    // Create topping object.
                    Topping topping = new Topping(toppingName, toppingPrice);

                    Console.Write("Enter Pizza amount: ");
                    // Parse and validate pizza amount input.
                    if (int.TryParse(Console.ReadLine(), out int pizzaAmount))
                    {
                        // Create pizza object with selected type, price, and amount.
                        Pizza pizza = new Pizza(pizzaType, pizzaPrice * pizzaAmount);

                        // Input and create customer object.
                        Console.Write("Enter Customer name: ");
                        string customerName = Console.ReadLine() + ".";
                        Customer customer = new Customer(customerName);

                        // Create and display order object with pizza, topping, and customer details.
                        Order order = new Order(pizza, topping, customer);
                        Console.WriteLine(order);
                    }
                    else
                    {
                        // Error message for invalid pizza amount input.
                        Console.WriteLine("Invalid input for Pizza amount. Please enter a valid integer.");
                    }
                }
                else
                {
                    // Error message for invalid topping choice input.
                    Console.WriteLine("Invalid topping choice. Please enter a number between 1 and 3.");
                }
            }
            else
            {
                // Error message for invalid pizza choice input.
                Console.WriteLine("Invalid pizza choice. Please enter a number between 1 and 3.");
            }
        }

        // Method to get pizza type and price based on user choice.
        private static (string, decimal) GetPizzaTypeAndPrice(int choice)
        {
            switch (choice)
            {
                case 1: return ("Margherita", 60);
                case 2: return ("Pepperoni", 75);
                case 3: return ("Vegetarian", 65);
                default: return ("Unknown", 0);
            }
        }

        // Method to get topping type and price based on user choice.
        private static (string, decimal) GetToppingTypeAndPrice(int choice)
        {
            switch (choice)
            {
                case 1: return ("Cheese", 10);
                case 2: return ("Chilli", 15);
                case 3: return ("Mushrooms", 12);
                default: return ("Unknown", 0);
            }
        }
    }
}
