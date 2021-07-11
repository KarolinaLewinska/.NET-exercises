using System;
using System.IO;

namespace DeleteFileOrDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            string userPath;
            string userAnswer;

            Console.WriteLine("Co chcesz usunąć: katalog/plik ?");
            userChoice = Console.ReadLine();
            try
            {
                if (userChoice == "katalog")
                {
                    Console.WriteLine("Podaj ścieżkę katalogu do usunięcia");
                    userPath = Console.ReadLine();
                    DirectoryInfo directory = new DirectoryInfo(userPath);
                   
                    if (Directory.Exists(userPath))
                    {
                        Console.WriteLine("Czy na pewno chcesz usunąć: " + userPath + " ?");
                        userAnswer = Console.ReadLine();
                        if (userAnswer == "tak")
                        {
                            directory.Delete();
                            Console.WriteLine("Usunięto katalog");
                        }
                        else
                        {
                            Console.WriteLine("Nie usunięto katalogu");
                        }
                    }
                }
                else if (userChoice == "plik")
                {
                    Console.WriteLine("Podaj ścieżkę pliku do usunięcia");
                    userPath = Console.ReadLine();
                    FileInfo file = new FileInfo(userPath);
                    
                    if (File.Exists(userPath))
                    {
                        Console.WriteLine("Czy na pewno chcesz usunąć: " + userPath + " ?");
                        userAnswer = Console.ReadLine();
                        if (userAnswer == "tak")
                        {
                            file.Delete();
                            Console.WriteLine("Usunięto plik");
                        }
                        else
                        {
                            Console.WriteLine("Nie usunięto pliku");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Możliwe jest usunięcie tylko katalogu lub pliku!");
                }
            } catch (Exception exc)
            {
                exc.ToString();
            }
        }   
    }
}
