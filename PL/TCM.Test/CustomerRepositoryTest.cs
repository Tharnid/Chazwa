using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCM.BL;

namespace TCM.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        //[TestMethod]
        //public void FindTestExistingCustomers()
        //{
        //    // Arrange
        //    CustomerRepository repository = new CustomerRepository();
        //    var customerList = repository.Retrieve();

        //    // Act
        //    var result = repository.Find(customerList, 2);

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(2, result.CustomerId);
        //    Assert.AreEqual("Baggins", result.LastName);
        //    Assert.AreEqual("Bilbo", result.FirstName);
        //}

        [TestMethod]
        public void SortByNameTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var result = repository.SortByName(customerList);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            // Arrange
            CustomerRepository cr = new CustomerRepository();
            var customerList = cr.Retrieve();

            // Act
            var result = cr.SortByName(customerList);        
   
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.First().CustomerTypeId);
        }
    }
}
