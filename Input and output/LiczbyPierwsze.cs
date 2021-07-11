using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daneUzytkownika;
            Console.WriteLine("Podaj ciąg liczb oddzielonych przecinkiem");
            daneUzytkownika = Console.ReadLine().Split(",");

            foreach (var element in daneUzytkownika)
            {
                int liczba = int.Parse(element);
                if (liczba == 2)
                {
                    Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                }
                else if (liczba % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
                }
                else
                {
                    bool liczbaPierwsza = true;
                    for (int i = 3; i < Math.Sqrt(liczba) + 1; i+=2)
                    {
                        if (liczba % i == 0)
                        {
                            liczbaPierwsza = false;
                            Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
                        }
                    }
                    if (liczbaPierwsza)
                    {
                        Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                    }
                }
            }
        }
    }
}
