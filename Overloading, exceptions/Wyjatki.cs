using System;

namespace Wyjątki
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int x = 20;
                    int y = 0;
                    int z = x / y;
                }
                catch (ArithmeticException e)
                {
                    throw new ArithmeticException("Dzielenie przez zero niedozwolone!", e);
                }
            }
            catch(Exception exc)
            {
                throw new Exception("Wyjątek systemowy!", exc);
            }
        }
    }
}
