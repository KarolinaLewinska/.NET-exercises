using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput;
            Console.WriteLine("Write number sequence separated by a comma");
            userInput = Console.ReadLine().Split(",");

            foreach (var element in userInput)
            {
                int userNumber = int.Parse(element);
                if (userNumber == 2)
                {
                    Console.WriteLine("Number {0} is a prime", userNumber);
                }
                else if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Number {0} is not a prime", userNumber);
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 3; i < Math.Sqrt(userNumber) + 1; i += 2)
                    {
                        if (userNumber % i == 0)
                        {
                            isPrime = false;
                            Console.WriteLine("Number {0} is not a prime", userNumber);
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("Number {0} is prime", userNumber);
                    }
                }
            }
        }
    }
}
