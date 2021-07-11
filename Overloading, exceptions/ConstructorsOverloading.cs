using System;

namespace ConstructorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb = new int[100];

            Konstruktory obiekt1 = new Konstruktory(2.24);
            Konstruktory obiekt2 = new Konstruktory('K');
            Konstruktory obiekt3 = new Konstruktory(4.1, 'L');
            Konstruktory obiekt4 = new Konstruktory(12, 6);
            Konstruktory obiekt5 = new Konstruktory(tablicaLiczb);

            obiekt1.wypiszWartoscLiczby();
            obiekt2.wypiszWartoscZnaku();
            obiekt3.wypiszWartoscLiczbyOrazZnaku();
            obiekt4.wypiszNWDLiczb();
            obiekt5.wypiszLiczbyPierwszeSito();  
        }
    }

    class Konstruktory
    {
        double liczba;
        int[] tablica;
        char znak;

        public Konstruktory(double liczba)
        {
            this.liczba = liczba;
        }

        public Konstruktory(char znak)
        {
            this.znak = znak;
        }

        public Konstruktory(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
        }

        public Konstruktory(double liczba, double liczba2)
        {
            this.liczba = liczba;

            while (liczba != liczba2)
            {
                if (liczba > liczba2)
                    liczba -= liczba2;
                else
                    liczba2 -= liczba;
            }
        }

        public Konstruktory(int[]tablicaLiczb)
        {
            this.tablica = tablicaLiczb;

            int maxZakresLiczbPierwszych = 20;
            int pierwiastekZakresu = (int)Math.Floor(Math.Sqrt(maxZakresLiczbPierwszych));

            for (int i = 1; i <= maxZakresLiczbPierwszych; i++)
            {
                tablica[i] = i;
            }

            for (int i = 2; i <= pierwiastekZakresu; i++)
            {
                if (tablica[i] != 0)
                {
                    int j = i + i;
                    while (j <= maxZakresLiczbPierwszych)
                    {
                        tablica[j] = 0;
                        j += i;
                    }
                }
            }
        }

        public void wypiszWartoscLiczby()
        {
            Console.WriteLine(liczba);
        }

        public void wypiszWartoscZnaku()
        {
            Console.WriteLine(znak);
        }

        public void wypiszWartoscLiczbyOrazZnaku()
        {
            Console.WriteLine(liczba + " " + znak);
        }

        public void wypiszNWDLiczb()
        {
            Console.WriteLine("NWD liczb to: " + liczba);
        }

        public void wypiszLiczbyPierwszeSito()
        {
            Console.WriteLine("Liczby pierwsze z zakresu:");
            for (int i = 2; i <= 10; i++)
                if (tablica[i] != 0)
                    Console.WriteLine(i + ", ");
        }
    }
}
