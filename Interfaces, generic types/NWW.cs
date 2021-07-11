using System;

namespace NWW
{
    class Program 
    {
        static void Main(string[] args) 
        {
            NWWalgorithm nww = new NWWalgorithm();
            
            Console.WriteLine("Podaj 2 liczby: ");
            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());
            
            nww.x = userNumber1;
            nww.y = userNumber2;
            nww.countNWW(userNumber1, userNumber2);
        }
    }

    internal class NWWalgorithm : NWWInterface
    {
        private int num1, num2, NWD, NWW;
        public int x
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        public int y
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

        public int countNWW(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }

            NWD = x;
            NWW = Math.Abs(x * y) / NWD;
            Console.WriteLine($"NWW liczb {num1} i {num2} wynosi: " + NWW);
            return NWW;
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

        public int countNWW(int x, int y);
    }
}
