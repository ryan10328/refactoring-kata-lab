using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new FizzBuzz();
            var result = app.Calculate(135);
            Console.WriteLine(result);
        }
    }
}
