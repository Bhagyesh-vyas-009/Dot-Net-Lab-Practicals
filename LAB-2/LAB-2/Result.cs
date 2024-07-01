using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{

    class Result : ICalculate
    {
        public void Addition(double a, double b)
        {
            Console.WriteLine($"Addition = {a + b}");
        }

        public void Subtraction(double a, double b)
        {
            Console.WriteLine($"Subtraction = {a - b}");
        }
    }
}
