using System;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int counter = 100;

            for (int i = 100; i >= 1; i--)
            {
                if (i % 3 == 0 && !(i % 2 == 0))
                {
                    number = i;
                    Console.WriteLine(number);
                }
            }

            while (counter >= 1)
            {
                counter--;
                if (counter % 3 == 0 && !(counter % 2 == 0))
                {
                    number = counter;
                    Console.WriteLine(number);
                }
            }

            do
            {
                if (counter % 3 == 0 && !(counter % 2 == 0))
                {
                    number = counter;
                    Console.WriteLine(number);
                }
                counter--;
            } while (counter >= 1);
        }
    }
}
