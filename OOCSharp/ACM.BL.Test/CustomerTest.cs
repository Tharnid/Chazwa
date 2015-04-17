using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCM.BL;

namespace TCM.BL.Test

{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Han";
            customer.LastName = "Solo";

            string expected = "Solo, Han";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Solo";
            string expected = "Solo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Han";
            string expected = "Han";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerTypeTest()
        {
            //-- Arrange
            int i1;
            i1 = 42;

            //-- Act
            int i2 = i1;
            i2 = 2;

            //-- Assert
            Assert.AreEqual(42, i1);
        }


        [TestMethod]
        public void ObjectTypeTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Han";

            //-- Act
            var c2 = c1;
            c2.FirstName = "Lando";

            //-- Assert
            Assert.AreEqual("Lando", c1.FirstName);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Han";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Chewie";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Lando";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
