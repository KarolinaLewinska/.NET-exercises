using System;

namespace ConstructorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[100];

            Overload overload = new Overload(2.24);
            Overload overload2 = new Overload('K');
            Overload overload3 = new Overload(4.1, 'L');
            Overload overload4 = new Overload(12, 6);
            Overload overload5 = new Overload(table);

            overload.displayValueOfNumber();
            overload2.displayValueOfChar();
            overload3.displayValueOfNumberAndChar();
            overload4.displayNWD();
            overload5.displaySito();  
        }
    }

    public class Overload
    {
        double number;
        int[] table;
        char character;

        public Overload(double number)
        {
            this.number = number;
        }

        public Overload(char character)
        {
            this.character = character;
        }

        public Overload(double number, char character)
        {
            this.number = number;
            this.character = character;
        }

        public Overload(double firstNumber, double secondNumber)
        {
            this.number = firstNumber;

            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                    firstNumber -= secondNumber;
                else
                    secondNumber -= firstNumber;
            }
        }

        public Overload(int[] table)
        {
            this.table = table;

            int maxRangeOfPrimeNumbersh = 20;
            int rootOfRange = (int) Math.Floor(Math.Sqrt(maxRangeOfPrimeNumbersh));

            for (int i = 1; i <= maxRangeOfPrimeNumbersh; i++)
            {
                table[i] = i;
            }

            for (int i = 2; i <= rootOfRange; i++)
            {
                if (table[i] != 0)
                {
                    int j = i + i;
                    while (j <= maxRangeOfPrimeNumbersh)
                    {
                        table[j] = 0;
                        j += i;
                    }
                }
            }
        }

        public void displayValueOfNumber()
        {
            Console.WriteLine(number);
        }

        public void displayValueOfChar()
        {
            Console.WriteLine(character);
        }

        public void displayValueOfNumberAndChar()
        {
            Console.WriteLine(number + " " + character);
        }

        public void displayNWD()
        {
            Console.WriteLine("NWD equals: " + number);
        }

        public void displaySito()
        {
            Console.WriteLine("Sito equals:");
            for (int i = 2; i <= 10; i++)
                if (table[i] != 0)
                    Console.WriteLine(i + ", ");
        }
    }
}
