namespace PizzaLibrary
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _pizza = new Pizza
            {
                Size = "Medium",
                Toppings = "None",
                Flavour = "Classic",
                Sauce = "Tomato",
                Spice = "Mild",
                Cheese = "Mozzarella"
            };
        }

        public IPizzaBuilder BuildSize(string size)
        {
            _pizza.Size = size;
            return this;
        }
        public IPizzaBuilder BuildToppings(string toppings)
        {
            _pizza.Toppings = toppings;
            return this;
        }
        public IPizzaBuilder BuildFlavour(string flavour)
        {
            _pizza.Flavour = flavour;
            return this;
        }
        public IPizzaBuilder BuildSauce(string sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }
        public IPizzaBuilder BuildSpice(string spice)
        {
            _pizza.Spice = spice;
            return this;
        }
        public IPizzaBuilder BuildCheese(string cheese)
        {
            _pizza.Cheese = cheese;
            return this;
        }

        public Pizza Build()
        {
            Pizza result = _pizza;
            Reset();
            return result;
        }
    }
}