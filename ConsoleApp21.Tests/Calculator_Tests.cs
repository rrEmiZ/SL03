using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp21.Tests
{
   public class Calculator_Tests
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        [InlineData(2, 4, 6)]
        [InlineData(-1, -2, -3)]
        public void Add_for_a_and_b_returns_c(int a, int b, int c)
        {
            var calc = new Calculator();

            int result = calc.Add(a, b);

            Assert.Equal(c, result);
        }


        [Fact]
        public void Add_for_1_and_2_returns_3()
        {
            var calc = new Calculator();
            int a = 1;
            int b = 2;
            int c = 3;

            int result = calc.Add(a, b);

            Assert.Equal(c, result);
        }

        [Fact]
        public void Add_for_2_and_4_returns_6()
        {
            var calc = new Calculator();
            int a = 2;
            int b = 4;
            int c = 6;

            int result = calc.Add(a, b);

            Assert.Equal(c, result);
        }

    }
}
