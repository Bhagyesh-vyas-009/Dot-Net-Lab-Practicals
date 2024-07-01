using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    public class Area
    {
        public void area(double l)
        {
            Console.WriteLine($"Area of Square = {l * l}");
        }

        public void area(double l,double b)
        {
            Console.WriteLine($"Area of Rectangle = {l * b}");
        }
    }
}
