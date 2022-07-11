using System;
using System.Collections.Generic;
using System.Text; 
using System.Text.RegularExpressions;

namespace RomanToNumber
{
    /// <summary>
    /// 
    /// </summary>
    public static class RomanToNum
    {
        /// <summary>
        /// Static Class to Convert Roman Numerals to Arobic numbers
        /// </summary>
        /// <param name="_temp">RomanNumeral in String</param>
        /// <returns></returns>
        public static int RomanNumeralToNumber(string _temp)
        {
            int _return = 0;
            for (int i = 0; i < _temp.Length; i++)
            {
                if (i > 0 && FindValue(_temp[i]) > FindValue(_temp[i - 1]))
                {
                    _return += FindValue(_temp[i]) - FindValue(_temp[i - 1]) * 2;
                }
                else
                {
                    _return += FindValue(_temp[i]);
                }
            }

            return _return;
        }

        /// <summary>
        /// Find Roman Letters Numeric Number
        /// </summary>
        /// <param name="_temp">Single Char</param>
        /// <returns></returns>
        public static int FindValue(char _temp)
        {
            switch (_temp)
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

        /// <summary>
        /// This function tests to see if there are any letter other than the regular roman numeral letters
        /// </summary>
        /// <param name="_temp"></param>
        /// <returns></returns>
        public static bool IsValidRomanNumeralLettersOnly(string _temp)
        {
            bool _return = true;
            for (int i = 0; i < _temp.Length; i++)
            {
                if (FindValue(_temp[i]) == 0)
                {
                    _return = false;
                }
            } 
            return _return;
        }

        /// <summary>
        /// IsValidRomanNumeral uses RegEx to test is a roman numeral is valid
        /// </summary>
        /// <param name="_Temp"></param>
        /// <returns></returns>
        public static bool IsValidRomanNumeralStrict(string _Temp)
        {
            bool _return;
            try
            {
                Regex _RegExp = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
                _return = _RegExp.IsMatch(_Temp);
            }
            catch (Exception)
            {
                _return = false;
            }
            return _return;
        
        }

    }
}
