using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCompositeAssessment.Infrastructure.Helpers;

namespace PrimeCompositeAssessment.Infrastructure.Tests
{
    [TestClass]
    public class NumberExtensionTests
    {
        [TestClass]
        public class NumberExtensionTest
        {
            [TestMethod]
            public void NumberExtensions_Not_Prime_Test()
            {
                // Arrange 
                long value = 10;

                // Act & Assert
                Assert.IsFalse(value.IsPrimeNumber());
            }

            [TestMethod]
            public void NumberExtensions_Prime_Test()
            {
                // Arrange 
                long value = 3;

                // Act & Assert
                Assert.IsTrue(value.IsPrimeNumber());
            }

            [TestMethod]
            public void NumberExtensions_Not_Even_Test()
            {
                // Arrange 
                long value = 5;

                // Act & Assert
                Assert.IsFalse(value.IsEven());
            }

            [TestMethod]
            public void NumberExtensions_Even_Test()
            {
                // Arrange 
                long value = 100;

                // Act & Assert
                Assert.IsTrue(value.IsEven());
            }
        }
    }
}
