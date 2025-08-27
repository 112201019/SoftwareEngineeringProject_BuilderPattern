using PizzaLibrary;
namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BuildFullPizza_ShouldReturnCorrectPizza()
        {
            // Arrange
            var builder = new PizzaBuilder();

            // Act
            Pizza pizza = builder
                .BuildSize("Large")
                .BuildToppings("Pepperoni, Mushrooms")
                .BuildFlavour("Spicy")
                .BuildSauce("BBQ")
                .BuildCheese("Cheddar")
                .BuildSpice("Hot")
                .Build();

            // Assert
            Assert.AreEqual("Large", pizza.Size);
            Assert.AreEqual("Pepperoni, Mushrooms", pizza.Toppings);
            Assert.AreEqual("Spicy", pizza.Flavour);
            Assert.AreEqual("BBQ", pizza.Sauce);
            Assert.AreEqual("Cheddar", pizza.Cheese);
            Assert.AreEqual("Hot", pizza.Spice);
        }
    }
}