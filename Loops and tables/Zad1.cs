using System;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 100;
            int licznik = 100;

            for (int i = 100; i >= 1; i--)
            {
                if (i % 3 == 0 && !(i % 2 == 0))
                {
                    liczba = i;
                    Console.WriteLine(liczba);
                }
            }

            while (licznik >= 1)
            {
                licznik--;
                if (licznik % 3 == 0 && !(licznik % 2 == 0))
                {
                    liczba = licznik;
                    Console.WriteLine(liczba);
                }
            }

            do
            {
                if (licznik % 3 == 0 && !(licznik % 2 == 0))
                {
                    liczba = licznik;
                    Console.WriteLine(liczba);
                }
                licznik--;
            } while (licznik >= 1);
        }
    }
}
