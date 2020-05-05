using System;
using Xunit;
using XUnitDemo;

namespace XUnitTest
{
    public class CalculatorTest
    {
        private Calculator calculator;
        public CalculatorTest()
        {
            calculator = new Calculator();
        }
        [Fact]
        public void AdditionalTest()
        {
            Assert.Equal(10,calculator.Additional(5, 5));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(15.5)]
        public void AdditionalTest_100(double number)
        {
            Assert.Equal(number, calculator.Additional(0, number));
        }
    }
}
