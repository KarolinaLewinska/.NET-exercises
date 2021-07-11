using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write lowercase letters to cipher");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar >= 97 && keyInfo.KeyChar <= 122)
                {
                    char character = (char) (((keyInfo.KeyChar - 96) % 27) + 97);
                    Console.Write(character);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
