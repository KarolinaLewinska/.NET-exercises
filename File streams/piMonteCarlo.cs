using System;
using System.IO;
using System.Text;

namespace piMonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę losowych punktów (nie mniej niż 3): ");
            int points = int.Parse(Console.ReadLine());
            int middle = 0;
            double x;
            double y;
            Random random = new Random();
            decimal piEstimation;
            string filePath = @"C:\Users\lewin\AppData\Local\Temp\pi_estimation.txt";

            try
            {
                if (points < 3)
                    Console.WriteLine("Za mało liczba losowych punktów");
                else
                {
                    for (int i = 0; i < points; i++)
                    {
                        x = random.NextDouble() * 2;
                        y = random.NextDouble() * 2;
                        if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1)
                            middle++;
                    }

                    piEstimation = 4 * middle / (decimal)points;
                    
                    FileInfo fi = new FileInfo(filePath);
                    FileStream fileStream = fi.Create();
                    byte[] piToFile =
                        new UTF8Encoding(true).GetBytes(piEstimation.ToString());
                    fileStream.Write(piToFile, 0, piToFile.Length);
                    fileStream.Close();

                    Console.WriteLine("Liczba PI w przybliżeniu wynosi: " + piEstimation.ToString());
                }

            }
            catch (Exception exc)
            {
                exc.ToString();
            }
           
        }
    }
}
