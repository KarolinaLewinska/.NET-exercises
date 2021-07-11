using System;
using System.IO;
using System.Text;

namespace PiMonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            decimal piEstimation;
            int middle = 0
            string pathOfFile = @"C:\Users\lewin\AppData\Local\Temp\pi_estimation.txt";
            Random random = new Random();

            Console.WriteLine("Write number of random userPoints");
            int userPoints = int.Parse(Console.ReadLine());

            try
            {
                if (userPoints < 3)
                    Console.WriteLine("Minimal number must be 3");
                else
                {
                    for (int i = 0; i < userPoints; i++)
                    {
                        x = random.NextDouble() * 2;
                        y = random.NextDouble() * 2;
                        if (Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1)
                            middle++;
                    }

                    piEstimation = 4 * middle / (decimal) userPoints;
                    
                    FileInfo fi = new FileInfo(pathOfFile);
                    FileStream fileStream = fi.Create();
                    byte[] piValueToFile =
                        new UTF8Encoding(true).GetBytes(piEstimation.ToString());
                    fileStream.Write(piValueToFile, 0, piValueToFile.Length);
                    fileStream.Close();

                    Console.WriteLine("Estimated PI value equals: " + piEstimation.ToString());
                }

            }
            catch (Exception exc)
            {
                exc.ToString();
            }
           
        }
    }
}
