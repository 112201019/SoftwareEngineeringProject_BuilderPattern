using PizzaLibrary;
namespace UnitTests
{
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void BuildFullPizza_ShouldReturnCorrectPizza()
        {
            // create the builder instance
            IPizzaBuilder builder = new PizzaBuilder();
            //using other way of the builder pattern
            builder = builder.BuildSize("Small");
            builder = builder.BuildToppings("OreoBiscuits");
            builder = builder.BuildFlavour("Mint");
            builder = builder.BuildSauce("BBQ");
            builder = builder.BuildCheese("Cheddar");
            builder = builder.BuildSpice("Sweet");
            Pizza pizza = builder.Build();


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