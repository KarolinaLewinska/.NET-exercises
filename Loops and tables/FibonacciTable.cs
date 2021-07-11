using System;

namespace FibonacciTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] table = new int[10][];
			int a = 0;
			int b = 1;

			for (int i = 0; i < 10; i++)
			{
				table[i] = new int[b];
				for (int j = 0; j < table[i].Length; j++)
				{
					table[i][j] = table[i].Length - j;
				}
				int c = a + b;
				a = b;
				b = c;
			}

			for (int i = 0; i < 10; i++)
			{
				Console.Write("table[{0}]= ", i);

				for (int j = 0; j < table[i].Length; j++)
				{
					Console.Write(table[i][j] + ", ");
				}
				Console.WriteLine("");
			}
		}
	}
}
