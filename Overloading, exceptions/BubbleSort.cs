using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[10];
            int ordinalNumber = 1;

            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine("Write " + ordinalNumber + "." + " number");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);
                table[i] = userNumber;
                ordinalNumber++;
            }

            BubbleSort bubbleSort = new BubbleSort(table);
            bubbleSort.displaySortedNumbers(); 
        }
    }

    class BubbleSort
    {
        int[] table;
        public BubbleSort(int[] table)
        {
            this.table = table;
            int tableLength = table.Length;
            try
            {
                do
                {
                    for (int i = 0; i < tableLength - 1; i++)
                    {
                        if (table[i] > table[i + 1])
                        {
                            int tmp = table[i];
                            table[i] = table[i + 1];
                            table[i + 1] = tmp;
                        }
                    }
                    tableLength--;
                }
                while (tableLength > 1);
                
                Console.WriteLine("Sorted numbers: ");
            }
            catch (IndexOutOfRangeException exc)
            {
                exc.ToString();
            }
        }

        public void displaySortedNumbers()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }
    }
}
