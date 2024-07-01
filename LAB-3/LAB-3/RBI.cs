using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class RBI
    {
        public void calculateInterest() { }
    }

    class HDFC : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Calculate Interest " + this.GetType().Name);
        }
    }
    class SBI : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Calculate Interest " + this.GetType().Name);
        }
    }
    class ICICI : RBI
    {
        public void calculateInterest()
        {
            Console.WriteLine("Calculate Interest " + this.GetType().Name);
        }
    }

    class Prog3
    {
        public void run()
        {
            new HDFC().calculateInterest();
            new SBI().calculateInterest();
            new ICICI().calculateInterest();
        }
    }
}
