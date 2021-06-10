using System;

namespace Operators_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("{0}/{1} is {2} remainder {3}", a, b, quotient, remainder);
        }
    }
}
