using PizzaLibrary;
namespace UnitTests
{
    [TestClass]
    public sealed class Test4
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
                .BuildSpice("Sweet")
                .Build();

            // checking if the pizza has the same values as set above
            Assert.AreEqual("Small", pizza.Size);
            Assert.AreEqual("OreoBiscuits", pizza.Toppings);
            Assert.AreEqual("Sweet", pizza.Spice);
        }
    }
}