using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Factorial
    {
        public delegate int factDelegate(int n);
        static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        public void run()
        {
            factDelegate fdel = factorial;
            Console.WriteLine($"Factorial = {fdel(5)}");
        }
    }
}
