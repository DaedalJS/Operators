using System;
using System.Security.Cryptography.X509Certificates;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 5;
            int quotient = x / y;
            int remainder = x % y;
            Console.WriteLine($"for {x} and {y} \n" +
                $"{x} plus {y} equals {x + y} \n" +
                $"{x} minus {y} equals {x - y} \n" +
                $"{x} times {y} equals {x * y} \n" +
                $"{x} over {y} equals {quotient} with a remainder of {remainder} \n");


            Console.WriteLine("to find the radius of a circle we use the formula \n" +
                "pi (3.14~) times the radius squared");
            Console.WriteLine("what is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var rsquared = radius * radius;
            Console.WriteLine($"if your circle has a radius of {radius} it will have an area of {3.14 * rsquared}.");
        }
    }
}
