using System;

namespace NWWInterface
{
    class Program 
    {
        static void Main(string[] args) 
        {
            NWWAlgorithm nww = new NWWAlgorithm();
            
            Console.WriteLine("Write 2 numbers: ");
            int firstUserNumber = int.Parse(Console.ReadLine());
            int secondUserNumber = int.Parse(Console.ReadLine());
            
            nww.x = firstUserNumber;
            nww.y = secondUserNumber;
            nww.countNWW(firstUserNumber, secondUserNumber);
        }
    }

    internal class NWWAlgorithm : NWWInterface
    {
        private int firstNumber, secondNumber, nwd, nww;
        public int x
        {
            get
            {
                return firstNumber;
            }
            set
            {
                firstNumber = value;
            }
        }

        public int y
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
            }
        }

        public int countNWW(int firstNumber, int secondNumber)
        {
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                    firstNumber = firstNumber - secondNumber;
                else
                    secondNumber = secondNumber - firstNumber;
            }

            nwd = firstNumber;
            nww = Math.Abs(firstNumber * secondNumber) / nwd;
            Console.WriteLine($"nww liczb {firstNumber} i {secondNumber} wynosi: " + nww);
            return nww;
        }
    }

    internal interface NWWInterface
    {
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }

        public int countNWW(int firstNumber, int secondNumber);
    }
}
