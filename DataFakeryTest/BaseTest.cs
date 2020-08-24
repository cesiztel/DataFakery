using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataFakery.Provider;

namespace DataFakeryTest
{
    [TestClass]
    public class BaseTest
    {
        [TestMethod]
        public void TestRandomDigitBetweenZeroAndNine()
        {
            var randomDigit = Base.RandomDigit();

            Assert.IsTrue(randomDigit >= 0 && randomDigit <= 9, "Expected result: number from 0 to 9");
        }

        [TestMethod]
        public void TestRandomDigitNotNullBetweenOneAndNine()
        {
            var randomDigitNotNull = Base.RandomDigitNotNull();

            Assert.IsTrue(randomDigitNotNull > 0 && randomDigitNotNull <= 9, "Expected result: number from 1 to 9");
        }

        [TestMethod]
        public void TestNumberBetWeenWithDefaultValuesReturnsAValueInReturnParameters()
        {
            var numberBetween = Base.NumberBetween();

            Assert.IsTrue(numberBetween >= 0 && numberBetween <= 2147483647, "Expected result: number from 0 to 2147483647");
        }

        [TestMethod]
        public void TestNumberBetWeenValuesReturnsAValueInReturnParameters()
        {
            var numberBetween = Base.NumberBetween(0, 100);

            Assert.IsTrue(numberBetween >= 0 && numberBetween <= 100, "Expected result: number from 0 to 100");
        }
    }
}
