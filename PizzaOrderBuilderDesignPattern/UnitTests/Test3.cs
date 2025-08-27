using PizzaLibrary;
namespace UnitTests
{
    [TestClass]
    public sealed class Test3
    {
        [TestMethod]
        public void BuildFullPizza_ShouldReturnCorrectPizza()
        {
            // create the builder instance
            var builder = new PizzaBuilder();

            //using other way of the builder pattern
            Pizza pizza = builder
                .BuildSize("Small")
                .BuildToppings("OreoBiscuits")
                .BuildFlavour("Mint")
                .BuildSauce("BBQ")
                .BuildCheese("Cheddar")
                .BuildSpice("Sweet")
                .Build();

            // checking if the pizza has the same values as set above
            Assert.AreEqual("Small", pizza.Size);
            Assert.AreEqual("OreoBiscuits", pizza.Toppings);
            Assert.AreEqual("Mint", pizza.Flavour);
            Assert.AreEqual("BBQ", pizza.Sauce);
            Assert.AreEqual("Cheddar", pizza.Cheese);
            Assert.AreEqual("Sweet", pizza.Spice);
        }
    }
}