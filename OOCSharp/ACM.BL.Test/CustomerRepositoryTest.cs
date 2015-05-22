using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCM.BL;

namespace TCM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                // CustomerId = 1,
                //EmailAddress = "hsolo@solo.com",
                //FirstName = "Han",
                //LastName = "Solo"

                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
                
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            // Assert.AreEqual(expected, actual);  // fails because they do not reference the same object

            // Compare individual properties
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}

// Collaboration ("uses a")

// Composition("has a")


