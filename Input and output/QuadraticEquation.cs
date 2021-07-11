using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x0;
            double delta;

            Console.WriteLine("Write parameter a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Write parameter b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Write parameter c");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta equals: " + delta);
            
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("Solution:");
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2= " + x2);
            }
            else if (delta == 0) 
            {
                x0 = -b / 2 * a;

                Console.WriteLine("Solution:");
                Console.WriteLine("x0= " + x0);
            }
            else
            {
                Console.WriteLine("Solution doesn't exist");
            }
        }   

    }
}
