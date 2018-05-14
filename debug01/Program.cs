using System;

namespace debug01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var chosenNumber = rand.Next(1, 1000);
            var answer = (chosenNumber < 500) ? "bigger" : "smaller";

            Console.WriteLine($"The number is {chosenNumber} and is {answer} than 500");
        }
    }
}
