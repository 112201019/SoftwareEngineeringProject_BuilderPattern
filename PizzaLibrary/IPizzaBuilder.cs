using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder BuildSize(string size);
        IPizzaBuilder BuildToppings(string Toppings);
        IPizzaBuilder BuildFlavour(string Flavour);
        IPizzaBuilder BuildSpice(string Spice);
        IPizzaBuilder BuildSauce(string Sauce);
        IPizzaBuilder BuildCheese(string Cheese);
        public Pizza Build();

    }
}