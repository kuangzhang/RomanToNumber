using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToNumber;

namespace RomanToNumber.UnitTests.Services
{
    [TestClass]
    public class RomanToNumber_IsValid
    {
        //[TestMethod]
        //public void IsRomanToNumber_Simple()
        //{
        //    string _temp = "IV";

        //    bool result = RomanToNum.IsValidRomanNumeralStricked(_temp);
        //    Assert.IsFalse(false);
        //}

        [TestMethod]
        public void IsRomanToNumber_StrictTrue()
        {
            string _temp = "XIV";
            Assert.IsTrue(RomanToNum.IsValidRomanNumeralLettersOnly(_temp), _temp + " is a valid Roman Numeral");
        }

        [TestMethod]
        public void IsRomanToNumber_StrictFase()
        {
            string _temp = "XIVB";
            Assert.IsFalse(RomanToNum.IsValidRomanNumeralLettersOnly(_temp), _temp + " is not a valid Roman Numeral");
        }

      
    }
}
 