using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MultiplesOf3Or5
{
    public class MultiplesOf3Or5App
    {
        [Fact]
        public void Should_Returns_23_When_Input_10()
        {
            var app = new KataService();

            var actual = app.Calculate(10);

            Assert.Equal(23, actual);
        }

        [Fact]
        public void Should_Returns_45_When_Input_15()
        {
            var app = new KataService();

            var actual = app.Calculate(15);

            Assert.Equal(45, actual);
        }

        [Fact]
        public void Should_Returns_33_When_Input_12()
        {
            var app = new KataService();

            var actual = app.Calculate(12);

            Assert.Equal(33, actual);
        }

    }

    public class KataService
    {
        public int Calculate(int number)
        {
            var numbers = new List<int>();

            for (var i = 0; i < number; i += 3)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < number; i += 5)
            {
                numbers.Add(i);
            }

            return numbers.Distinct().Sum();
        }
    }
}
