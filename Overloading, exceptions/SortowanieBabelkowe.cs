using System;

namespace SortowanieBabelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb = new int[10];
            int numerLiczby = 1;

            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.WriteLine("Podaj " + numerLiczby + "." + " liczbę");
                string inputUzytkownika = Console.ReadLine();
                int liczbaUzytkownika = int.Parse(inputUzytkownika);
                tablicaLiczb[i] = liczbaUzytkownika;
                numerLiczby++;
            }

            SortowanieBabelkowe sort1 = new SortowanieBabelkowe(tablicaLiczb);
            sort1.wypiszWynikSortowaniaBabelkowego(); 
        }
    }

    class SortowanieBabelkowe
    {
        int[] tablicaLiczb;
        public SortowanieBabelkowe(int[] tablica)
        {
            this.tablicaLiczb = tablica;

            int dlugoscTablicy = tablica.Length;
            try
            {
                do
                {
                    for (int i = 0; i < dlugoscTablicy - 1; i++)
                    {
                        if (tablica[i] > tablica[i + 1])
                        {
                            int tmp = tablica[i];
                            tablica[i] = tablica[i + 1];
                            tablica[i + 1] = tmp;
                        }
                    }
                    dlugoscTablicy--;
                }
                while (dlugoscTablicy > 1);
                
                Console.WriteLine("Liczby posortowane metodą bąbelkową: ");
            }
            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("Przekroczono zakres tablicy:");
                exc.ToString();
            }
        }

        public void wypiszWynikSortowaniaBabelkowego()
        {
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                Console.WriteLine(tablicaLiczb[i]);
            }
        }
    }
}
