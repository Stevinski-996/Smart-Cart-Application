using Xunit;
using Smart_Cart_Application;
using System.Collections.Generic;

namespace SmartCartTests
{
    public class CartTests
    {
        [Fact]
        public void Add()
        {
            // Arrange
            var cart = new Shoppingcart();
            var product = new Product("Test Product", 99.99, ProductCategory.Electronics);

            cart.Add(product);

            Assert.Single(cart.GetItems());
        }

        [Fact]
        public void RemoveItem()
        {
            var cart = new Shoppingcart();
            var product = new Product("Test Product", 99.99, ProductCategory.Electronics);
            cart.Add(product);

            cart.Removeitem(product);

            Assert.Empty(cart.GetItems());
        }

        [Fact]
        public void CalculateTotalCost()
        {
            var cart = new Shoppingcart();
            var product1 = new Product("Test Product 1", 50.00, ProductCategory.Electronics);
            var product2 = new Product("Test Product 2", 75.00, ProductCategory.Electronics);
            cart.Add(product1);
            cart.Add(product2);

            double totalCost = cart.CalculateTotalCost();

            Assert.Equal(125.00, totalCost);
        }
    }
}
