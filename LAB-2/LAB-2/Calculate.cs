using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    class Calculate : ISum
    {
        public override void SumOfTwo(int a, int b)
        {
            Console.WriteLine($"Sum of {a} and {b} = {a+b} ");
        }
        public override void SumOfThree(int a, int b, int c)
        {
            Console.WriteLine($"Sum of {a},{b} and {c} = {a + b +c} ");
        }

    }
}
