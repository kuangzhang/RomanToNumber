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
            _Test = "IV";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (Age of My Neice)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNumber.RomanToNum.RomanNumeralToNumber(_Test));
   
            //Ramdom Test
            _Test = "LVI";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (This year Super Bowl)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNumber.RomanToNum.RomanNumeralToNumber(_Test));

            //Ramdom Test
            _Test = "MMXXII";
            Console.WriteLine("Roman Numeric value: " + _Test + " Hint (Current Year)");
            Console.WriteLine("Numeric value:");
            Console.WriteLine(RomanToNumber.RomanToNum.RomanNumeralToNumber(_Test)); 

        }






    }
}
