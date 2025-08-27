using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class Pizza
    {
        public string Size { get; set; } = string.Empty;
        public string Toppings { get; set; } = string.Empty;
        public string Flavour { get; set; } = string.Empty;
        public string Base { get; set; } = string.Empty;
        public string Sauce { get; set; } = string.Empty;
        public string Spice { get; set; } = string.Empty;
        public string Cheese { get; set; } = string.Empty;


        public void PizzaDescription()
        {
            Console.WriteLine("Pizza Details: \n");
            Console.WriteLine($"Size: {Size}\n");
            Console.WriteLine($"Toppings: {Toppings}\n");
            Console.WriteLine($"Flavour: {Flavour}\n");
            Console.WriteLine($"Sauce: {Sauce}\n");
            Console.WriteLine($"Spice: {Spice}\n");
            Console.WriteLine($"Cheese: {Cheese}\n");
        }

    }
}