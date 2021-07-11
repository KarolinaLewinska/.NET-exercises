using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] table = new int[4][];
            int firstCounter = 1;
            int secondCounter = 10;

            for (int i = 0; i < 4; i++)
            {
                table[i] = new int[firstCounter];
                firstCounter = firstCounter + 1;
            }

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    table[i][j] = secondCounter--;
                }
            }

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    Console.Write(table[i][j] + "\n");
                }
            }
        }
    }
}
