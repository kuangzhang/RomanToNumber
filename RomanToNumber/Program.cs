using System;
using RomanToNumber;

namespace RomanToNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string _Test;

            //Test for Case 4
            _Test = "III";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (Age of My Neice)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNumber.RomanToNum.RomanNumeralToNumber(_Test));
   
            //Ramdom Test
            _Test = "IV";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (This year Super Bowl)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNum.RomanNumeralToNumber(_Test));

            //Ramdom Test
            _Test = "VI";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (Current Year)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNum.RomanNumeralToNumber(_Test));
             
            _Test = "VIXCMB";
            if (!RomanToNum.IsValidRomanNumeralLettersOnly(_Test))
            {
                Console.WriteLine("Roman Numeral value:" + _Test + " is Not Valid!");
            }
            else
            {
                Console.WriteLine("Roman Numeral value " + _Test + " is Valid!");
            }  
            _Test = "III";
            if (!RomanToNum.IsValidRomanNumeralLettersOnly(_Test))
            {
                Console.WriteLine("Roman Numeral value:" + _Test + " is Not Valid!");
            }
            else
            {
                Console.WriteLine("Roman Numeral value " + _Test + " is Valid!");
            }

            _Test = "VIXCMB";
            if (!RomanToNum.IsValidRomanNumeralStrict(_Test))
            {
                Console.WriteLine("Roman Numeral value:" + _Test + " is Not Valid!");
            }
            else
            {
                Console.WriteLine("Roman Numeral value " + _Test + " is Valid!");
            }
            _Test = "XIV";
            if (!RomanToNum.IsValidRomanNumeralStrict(_Test))
            {
                Console.WriteLine("Roman Numeral value:" + _Test + " is Not Valid!");
            }
            else
            {
                Console.WriteLine("Roman Numeral value " + _Test + " is Valid!");
            }

        }
         






    }
}
