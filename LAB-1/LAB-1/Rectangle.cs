using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Rectangle
    {
        double l,w;
        public Rectangle(double l, double w)
        {
            this.l = l;
            this.w = w;
            Console.WriteLine("Area of Rectangle = {0}",(l * w));
        }   
    }
}
