using System;
using NUnit.Framework;

namespace DEV_3
{
    [TestFixture]
    public class NumeralSystemConverterTests
    {
        [TestCase(0, 10, "0")]
        [TestCase(30, 20, "1A")]
        [TestCase(10, 2, "1010")]
        [TestCase(255, 16, "FF")]        
        [TestCase(123, 16, "7B")]
        [TestCase(13587, 8, "32423")]
        [TestCase(123, 2, "1111011")]
        [TestCase(10005678, 20, "32AE3I")]
        [TestCase(int.MaxValue, 20, "1DB1F927")]        
        public void DecimalToOtherNumeralSystemTest(int acceptedNumber, int ecceptedFoundetion, string expected)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedFoundetion);
            string actual = convertedNumber.DecimalToOtherNumeralSystem();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ABCDEFG", "GFEDCBA")]
        [TestCase("0123456", "6543210")]
        public void ReverseString_ReverseString_ReversedString(string acceptedString, string expectedString)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(10, 10);
            String actualValue = convertedNumber.ReverseString(acceptedString);
            Assert.AreEqual(expectedString, actualValue);
        }

        [TestCase(int.MinValue, 11)]        
        public void DecimalToOtherNumeralSystem_OverflowException(int acceptedNumber, int ecceptedFoundetion)
        {
            NumeralSystemConverter convertedNumber;
            Assert.Throws<OverflowException>(() => convertedNumber= new NumeralSystemConverter(acceptedNumber, ecceptedFoundetion));
        }

        [TestCase(20, 1)]
        [TestCase(20, -1)]
        [TestCase(10, 21)]
        [TestCase(10, -21)]        
        public void CreatingRepresentationOfNumberInNewSystemTest_ArgumentOutOfRangeException(int acceptedNumber, int ecceptedFoundetion)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedFoundetion);
            Assert.Throws<ArgumentOutOfRangeException>(() => convertedNumber.DecimalToOtherNumeralSystem());
        }
    }
}
