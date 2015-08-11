using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCM.Library.Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildingIntegerSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.BuildingIntegerSequence();

            // Analyze ???
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            // Arrange
            Builder listBuilder = new Builder();

            // Act
            var result = listBuilder.BuildStringSequence();

            // Analyze ???
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            // Assert
            Assert.IsNotNull(result);

        }
    }
}
