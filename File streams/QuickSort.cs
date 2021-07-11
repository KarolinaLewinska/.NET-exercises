using System;
using System.IO;
using System.Text;

namespace FileWithQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPath = @"C:\Users\lewin\AppData\Local\Temp\";

            Console.WriteLine("Podaj nazwę katalogu do utworzenia");
            string directoryName = Console.ReadLine();
            string directoryPath = mainPath + directoryName;

            Console.WriteLine("Podaj nazwę pliku do utworzenia");
            string fileName = Console.ReadLine();
            string filePath = mainPath + fileName;
            
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                FileInfo fi = new FileInfo(filePath);
                FileStream fileStream = fi.Create();
                Byte[] fileNumbers =
                    new UTF8Encoding(true).GetBytes("12,333,55,1,5,76,9,54,23,64");
                fileStream.Write(fileNumbers, 0, fileNumbers.Length);
                fileStream.Close();

                TextReader textReader = new StreamReader(filePath);
                string fileReader = textReader.ReadLine();
                string readText = File.ReadAllText(filePath);
                string[] textFromFile = readText.Split(",");

                int[] numbersFromFile = new int[textFromFile.Length];
                for (int i = 0; i < textFromFile.Length; i++)
                {
                    numbersFromFile[i] = Convert.ToInt32(textFromFile[i]);
                }
               
                QuickSort(numbersFromFile, 0, numbersFromFile.Length-1);
                string[] sortedNumbers = new string[numbersFromFile.Length];

                for (int i = 0; i < numbersFromFile.Length; i++)
                {
                    sortedNumbers[i] = Convert.ToString(numbersFromFile[i]);
                }

                string st = string.Join(" ", sortedNumbers);
                Console.WriteLine(st);
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    var tmp = array[i];
                    array[i++] = array[j]; 
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }
}
