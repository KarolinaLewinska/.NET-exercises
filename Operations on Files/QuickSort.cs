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

            Console.WriteLine("Write name of directory");
            string directoryName = Console.ReadLine();
            string directoryPath = mainPath + directoryName;

            Console.WriteLine("Write name of file");
            string fileName = Console.ReadLine();
            string filePath = mainPath + fileName;
            
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                FileInfo fi = new FileInfo(filePath);
                FileStream fileStream = fi.Create();
                Byte[] numbersToWrite =
                    new UTF8Encoding(true).GetBytes("12,333,55,1,5,76,9,54,23,64");
                fileStream.Write(numbersToWrite, 0, numbersToWrite.Length);
                fileStream.Close();

                TextReader textReader = new StreamReader(filePath);
                string fileReader = textReader.ReadLine();
                string allTextReader = File.ReadAllText(filePath);
                string[] splittedNumbers = allTextReader.Split(",");

                int[] tableWithNumbers = new int[splittedNumbers.Length];
                for (int i = 0; i < splittedNumbers.Length; i++)
                {
                    tableWithNumbers[i] = Convert.ToInt32(splittedNumbers[i]);
                }
               
                QuickSort(tableWithNumbers, 0, tableWithNumbers.Length-1);
                string[] sortedNumbers = new string[tableWithNumbers.Length];

                for (int i = 0; i < tableWithNumbers.Length; i++)
                {
                    sortedNumbers[i] = Convert.ToString(tableWithNumbers[i]);
                }

                string stringOfNumbers = string.Join(" ", sortedNumbers);
                Console.WriteLine(stringOfNumbers);
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
