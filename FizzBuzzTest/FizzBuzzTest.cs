using System;
using FizzBuzzApp;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_Returns_Fizz_For_MultipleOfThree()
        {
            var app = new FizzBuzz();
            const string expected = "Fizz";
            var actual = app.Calculate(9);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Should_Returns_Buzz_For_MultipleOfFive()
        {
            var app = new FizzBuzz();
            const string expected = "Buzz";
            var actual = app.Calculate(20);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Should_Returns_FizzBuzz_For_MultipleBothThreeAndFive()
        {
            var app = new FizzBuzz();
            const string expected = "FizzBuzz";
            var actual = app.Calculate(15);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Should_ThrowsErrors_WhenNumberOutOfRange()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var app = new FizzBuzz();
                app.Calculate(101);
            });

        }
    }
}
