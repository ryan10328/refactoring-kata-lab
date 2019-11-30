using System;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            if (number < 0 || number > 100)
                throw new InvalidOperationException();
            if (number % 5 == 0 && number % 3 == 0)
                return "FizzBuzz";
            if (number % 5 == 0)
                return "Buzz";
            return "Fizz";
        }
    }
}