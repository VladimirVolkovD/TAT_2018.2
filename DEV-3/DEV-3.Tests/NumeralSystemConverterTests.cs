using System;
using NUnit.Framework;

namespace DEV_3
{
    [TestFixture]
    public class NumeralSystemConverterTests
    {
        [TestCase(10, 2, "1010")]
        [TestCase(6, 3, "20")]
        [TestCase(125, 4, "1331")]
        [TestCase(264, 5, "2024")]
        [TestCase(264, 6, "1120")]
        [TestCase(9, 7, "12")]
        [TestCase(13587, 8, "32423")]
        [TestCase(364, 9, "444")]
        [TestCase(101, 10, "101")]
        [TestCase(1010, 11, "839")]
        [TestCase(30, 12, "26")]
        [TestCase(198, 13, "123")]
        [TestCase(888, 15, "3E3")]
        [TestCase(123, 16, "7B")]
        [TestCase(123, 17, "74")]
        [TestCase(30, 18, "1C")]
        [TestCase(30, 19, "1B")]
        [TestCase(30, 20, "1A")]
        [TestCase(int.MaxValue, 20, "1DB1F927")]     
        public void DecimalToOtherNumeralSystemTest(int acceptedNumber, int ecceptedBase, string expectedNumber)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedBase);
            string actual = convertedNumber.DecimalToOtherNumeralSystem();
            Assert.AreEqual(expectedNumber, actual);
        }

        [TestCase(10, 1)]
        [TestCase(6, 21)]        
        public void DecimalToOtherNumeralSystemTest_WrongBaseException(int acceptedNumber, int ecceptedBase)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedBase);
            Assert.Throws<Exception>(() => convertedNumber.DecimalToOtherNumeralSystem());
        }

        [TestCase(int.MinValue, 11)]        
        public void DecimalToOtherNumeralSystem_OverflowException(int acceptedNumber, int ecceptedBase)
        {
            NumeralSystemConverter convertedNumber;
            Assert.Throws<OverflowException>(() => convertedNumber= new NumeralSystemConverter(acceptedNumber, ecceptedBase));
        }

        [TestCase(20, 1)]
        [TestCase(20, -1)]
        [TestCase(10, 21)]
        [TestCase(10, -21)]        
        public void CreatingRepresentationOfNumberInNewSystemTest_ArgumentOutOfRangeException(int acceptedNumber, int ecceptedBase)
        {
            NumeralSystemConverter convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedBase);
            Assert.Throws<Exception>(() => convertedNumber.DecimalToOtherNumeralSystem());
        }
    }
}
