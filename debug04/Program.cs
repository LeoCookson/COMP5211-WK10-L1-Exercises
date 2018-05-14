using System;

namespace debug04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get user input for Farenheit");

            var input = int.Parse(Console.ReadLine());

            var conversion = (input - 32) * 10 / 18;

            Console.WriteLine($"The degrees in Celsius is {conversion}");
        }
    }
}
