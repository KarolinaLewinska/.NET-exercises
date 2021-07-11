using System;

namespace Exceptions
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
                catch (ArithmeticException exc)
                {
                    throw new ArithmeticException("Dividing by zero is forbidden", exc);
                }
            }
            catch (Exception exc)
            {
                throw new Exception("System Exception", exc);
            }
        }
    }
}
