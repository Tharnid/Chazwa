using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCM.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();
            //{
            //    CurrentPrice = 1545.50M,
            //    ProductDescription = "Ummm...a part of a ship",
            //    ProductName = "Flux Capacitor"
            //};

            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }
    }
}
