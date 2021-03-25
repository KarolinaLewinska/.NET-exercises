using System;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, x0;
            double delta;

            Console.WriteLine("Podaj parametr a równania kwadratowego");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj parametr b równania kwadratowego");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj parametr c równania kwadratowego");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta równania wynosi: " + delta);
            
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("Rozwiązania równania kwadratowego:");
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2= " + x2);
            }
            else if (delta == 0) 
            {
                x0 = -b / 2 * a;

                Console.WriteLine("Rozwiązanie równania kwadratowego:");
                Console.WriteLine("x0= " + x0);
            }
            else
            {
                Console.WriteLine("Brak rozwiązania równania kwadratowego");
            }
        }   

    }
}
