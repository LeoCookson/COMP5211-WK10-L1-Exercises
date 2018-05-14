using System;

namespace debug03
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            
            var someRandomNumber = rand.Next(1, 20);

            for(var i = 0; i < someRandomNumber; i ++) {
                var chosenNumber1 = rand.Next(1, 100);
                var chosenNumber2 = rand.Next(1, 100);
                Console.WriteLine(AddNumber(chosenNumber1, chosenNumber2));
            }

        }

        int AddNumber (int num1, int num2) {
            return num1 x num2;
        }
    }
}
