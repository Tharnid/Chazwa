using Microsoft.VisualStudio.TestTools.UnitTesting;
using TharnApp.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TharnApp.Biz.Tests
{
    [TestClass()]
    public class VendorTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            // Arrange
            var vendor = new Vendor();
            var product = new Product(1, "Saw", "");
            var expected = true;

            // Act
            var actual = vendor.PlaceOrder(product, 12); // product and 12 are arguments

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrder_NullProduct_Exception()
        {
            // Arrange
            var vendor = new Vendor();

            // Act
            var actual = vendor.PlaceOrder(null, 12);

            // Assert
            // Expected exception
        }
    }
}