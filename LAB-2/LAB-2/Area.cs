using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public class Area : Shape
    {
        public void Circle(double r)
        {
            Console.WriteLine($"Area of Circle = {Math.PI * r * r}");
        }

        public void Square(double l)
        {
            Console.WriteLine($"Area of Square = {l * l}");
        }

        public void Triangle(double b, double h)
        {
            Console.WriteLine($"Area of Triangle = {0.5 * b * h}");
        }
    }
}
