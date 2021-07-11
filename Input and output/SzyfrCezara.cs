using System;

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz małe litery do zaszyfrowania");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar >= 97 && keyInfo.KeyChar <= 122)
                {
                    char znak = (char)(((keyInfo.KeyChar - 96) % 27) + 97);
                    Console.Write(znak);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
