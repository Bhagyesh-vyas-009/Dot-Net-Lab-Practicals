using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class ShapeArea
    {
        public void CalculateArea(double l, double w)
        {
            Console.WriteLine($"Area of Rectangle with length={l} and width={w} = {l * w}");
        }
   
        public void CalculateArea(float r)
        {
            Console.WriteLine($"Area of Circle with radius={r} =  {Math.PI * r * r}");
        }
        public void CalculateArea(double s)
        {
            Console.WriteLine($"Area of Circle with side={s} =  {s * s}");
        }

        public void run()
        {
            ShapeArea area = new ShapeArea();
            area.CalculateArea(Convert.ToDouble(5));
            area.CalculateArea(Convert.ToDouble(5), Convert.ToDouble(5));
            area.CalculateArea(5.4f);
        }
    }
}
