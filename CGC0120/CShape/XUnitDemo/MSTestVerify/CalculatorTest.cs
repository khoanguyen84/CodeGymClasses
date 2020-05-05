using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestDemo;

namespace MSTestVerify
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator;
        [TestMethod]
        public void AdditionalTest_1()
        {
            calculator = new Calculator();
            Assert.IsTrue(calculator.Additional(30, 40) == 70);
        }
    }
}
