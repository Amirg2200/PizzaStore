using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    // Defines a Customer with a name property and a method for displaying its details.
    internal class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public override string ToString() => $"Customer: {Name}";
    }
}
