using System;

namespace InsertSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Table tab = new Table(8);

            tab.SetTableValue(0, 12);
            tab.SetTableValue(1, 333);
            tab.SetTableValue(2, 1);
            tab.SetTableValue(3, 11);
            tab.SetTableValue(4, 0);
            tab.SetTableValue(5, 125);
            tab.SetTableValue(6, 1242);
            tab.SetTableValue(7, 66);
            tab.SetTableValue(8, 121);
            tab.SetTableValue(9, 100);

            Console.WriteLine("Wartości przed posortowaniem: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tab[" + i + "] = " + tab.GetIndex(i));
            }

            Console.WriteLine("Wartości po posortowaniu: ");
            tab.InsertSort(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tab[" + i + "] = " + tab.GetIndex(i));
            }
        }
    }

    public class Table
    {
        private int[] tab;

        public Table (int tabSize)
        {
            if (tabSize < 0)
                throw new ArgumentOutOfRangeException("Błędny rozmiar tablicy!");

            tab = new int[tabSize];
        }

        public int GetIndex(int index)
        {
            if (index >= tab.Length || index < 0)
                throw new IndexOutOfRangeException
                    ("Indeks nie może być większy niż rozmiar tablicy lub mniejszy niż 0!");

            return tab[index];
        }

        public void SetTableValue(int index, int value)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Indeks nie może być mniejszy niż 0!");

            if (index >= tab.Length)
                Resize(index + 1);

            tab[index] = value;
        }

        public void Resize(int size)
        {
            int[] newTab = new int[size];
            
            for (int i = 0; i < tab.Length; i++)
            {
                newTab[i] = tab[i];
            }
            tab = newTab;
        }

        public void InsertSort(int size)
        {
            int temp, j;

            for (int i = 1; i < size; i++)
            {
                temp = tab[i];

                for (j = i - 1; j >= 0 && tab[j] > temp; j--)
                {
                    tab[j + 1] = tab[j];
                }
                tab[j + 1] = temp;
            }
        }
    }
}
