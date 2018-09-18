using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeCompositeAssessment.Application.Tests
{
    [TestClass]
    public class PrimeCompositeApplicationTests
    {
        PrimeCompositeApplication _app;

        [TestInitialize]
        public void Setup()
        {
            _app = new PrimeCompositeApplication();
        }

        [TestCleanup]
        public void Clean()
        {
            _app = null;
        }

        [TestMethod]
        public void GetNumbersFromRange_Test()
        {
            //Act & Assert
            Assert.IsNotNull(_app.GetNumbersFromRange(1,100));
        }

        [TestMethod]
        public void GetListWithReplacedPrimeNumberWithPrimeText_Test()
        {
            //Act
            var result =_app.GetListWithReplacedPrimeNumberWithPrimeText(1, 100);
            
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void GetListWithReplacedCompositeNumberAndNotEvenWithCompositeText_Test()
        {
            //Act
            var result = _app.GetListWithReplacedCompositeNumberAndNotEvenWithCompositeText(1, 100);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }

    }
}
