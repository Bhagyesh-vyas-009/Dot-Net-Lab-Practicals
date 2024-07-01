using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class LowerUpper
    {
        public string str;

        public LowerUpper(string str) {
            this.str = str;
        }

        public void Upper()
        {
            Console.WriteLine("String in UpperCase : "+str.ToUpper());
        }

        public void Lower()
        {
            Console.WriteLine("String in LowerCase : " + str.ToLower());
        }
    }

}
