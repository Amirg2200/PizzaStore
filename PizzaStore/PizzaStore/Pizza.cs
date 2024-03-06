using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Pizza(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"Pizza: {Name}, Price: {Price} kr.";
    }
}
