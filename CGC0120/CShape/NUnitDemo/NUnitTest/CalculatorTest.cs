using NUnit.Framework;
using NUnitDemo;

namespace NUnitTest
{
    public class CalculatorTest
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AdditionalTest()
        {
            Assert.AreEqual(11.2, calculator.Additional(3.5 ,7.7));
            Assert.AreEqual(20, calculator.Additional(15, 5));
        }

        [Test]
        public void DivisonTest()
        {
            Assert.IsTrue(calculator.Divison(10, 5) == 2);
            Assert.GreaterOrEqual(calculator.Divison(20, 5), 4);
            Assert.AreEqual(2.5, calculator.Divison(5, 2));
        }
    }
}
