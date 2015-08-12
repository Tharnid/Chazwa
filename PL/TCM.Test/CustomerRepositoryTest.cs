using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void GetNamesTest()
        {
            // Arrange
            CustomerRepository cr = new CustomerRepository();
            var customerList = cr.Retrieve();

            // Act
            var query = cr.GetNames(customerList);

            // Analyze
            foreach (var item in query)
            {
                TestContext.WriteLine(item);
            }

            // Assert
            Assert.IsNotNull(query);
        }

        [TestMethod]
        public void GetNamesAndEmailTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var query = repository.GetNamesAndEmail(customerList);

            // NOT REALLY A TEST
        }

        [TestMethod]
        public void GetNamesAndTypeTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            CustomerTypeRepository typeRepository = new CustomerTypeRepository();
            var customerTypeList = typeRepository.Retrieve();

            // Act
            var query = repository.GetNamesAndType(customerList, customerTypeList);

            // NOT REALLY A TEST
        }

        //[TestMethod]
        //public void GetOverdueCustomersTest()
        //{
        //    // Arrange
        //    CustomerRepository cr = new CustomerRepository();
        //    var customerList = cr.Retrieve();

        //    // Act
        //    var query = cr.GetOverdueCustomers(customerList);

        //    // Analyze
        //    foreach (var item in query)
        //    {
        //        TestContext.WriteLine(itemToString());
        //        //TestContext.WriteLine(item.ToString());
        //    }

        //    // Assert
        //    Assert.IsNotNull(query);
        //}

        [TestMethod]
        public void GetOverdueCustomersTest()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var query = repository.GetOverdueCustomers(customerList);

            // Analyze
            foreach (var item in query)
            {
                TestContext.WriteLine(item.LastName + ", " + item.FirstName);
            }

            // Assert
            Assert.IsNotNull(query);
        }
    }
}
