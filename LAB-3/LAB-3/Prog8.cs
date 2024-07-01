using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Prog8
    {
        public delegate T Calculator<T>(T a, T b);
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiplication(double a, double b) => a * b;
        public static int Division(int a, int b) { return a / b;  }

        public void run()
        {
            Calculator<double> add = Add;
            Calculator<double> sub = Subtract;
            Calculator<double> mul = Multiplication;
            Calculator<int> div = Division;

            Console.WriteLine($"Addition = {add(2.5, 4)}");
            Console.WriteLine($"Subtraction = {sub(2.3, 4)}");
            Console.WriteLine($"Multiplication = {mul(5, 4)}");
            Console.WriteLine($"Division = {div(4, 2)}");
        }
    }
}
