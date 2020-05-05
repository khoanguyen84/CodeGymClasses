using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitDemo;

namespace XUnitTest
{
    public class MathTest
    {
        private MathDemo math;
        public MathTest()
        {
            math = new MathDemo();
        }

        [Fact]
        public void RectangleTest_1()
        {
            Assert.True(math.RectangleArea(10, 5) == 50);
        }

        [Theory]
        [InlineData(30)]
        public void RectangleTest_10(double execpted)
        {
            Assert.True(math.RectangleArea(6, 5) == execpted);
        }
    }
}
