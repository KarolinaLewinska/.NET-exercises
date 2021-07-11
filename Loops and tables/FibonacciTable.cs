using System;

namespace FibonacciTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] tab = new int[10][];
			int a = 0;
			int b = 1;

			for (int i = 0; i < 10; i++)
			{
				tab[i] = new int[b];
				for (int j = 0; j < tab[i].Length; j++)
				{
					tab[i][j] = tab[i].Length - j;
				}
				int c = a + b;
				a = b;
				b = c;
			}

			for (int i = 0; i < 10; i++)
			{
				Console.Write("tab[{0}]= ", i);

				for (int j = 0; j < tab[i].Length; j++)
				{
					Console.Write(tab[i][j] + ", ");
				}
				Console.WriteLine("");
			}
		}
	}
}
