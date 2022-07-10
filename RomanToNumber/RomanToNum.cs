using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToNumber
{
    public class RomanToNum
    {



        public static int FindValue(char _Chr)
        {
            switch (_Chr)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
