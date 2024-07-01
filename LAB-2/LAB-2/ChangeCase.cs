using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    public  class ChangeCase
    {
        public char methodChangeCase(char ch)
        {
            if (char.IsLetter(ch))
            {
                if (char.IsUpper(ch))
                {
                    return char.ToLower(ch);
                }
                else
                {
                    return char.ToUpper(ch);
                }
            }
            else
            {
                return ch;
            }
        }
    }
}
