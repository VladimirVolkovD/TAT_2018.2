using System;
using NUnit.Framework;

namespace DEV_3.Tests
{
    [TestFixture]
    public class NumeralSystemConverterTests
    {
        [TestCase(10, 2, "1010")]
        [TestCase(30, 20, "1A")]
        [TestCase(-30, 20, "-1A")]
        [TestCase(int.MaxValue, 20, "1DB1F927")]
        public void DecimalToOtherNumeralSystemTest(int acceptedNumber, int acceptedBase, string expectedNumber)
        {
            var convertedNumber = new NumeralSystemConverter(acceptedNumber, acceptedBase);
            var actual = convertedNumber.DecimalToOtherNumeralSystem();
            Assert.AreEqual(expectedNumber, actual);
        }

        [TestCase(int.MinValue, 11)]        
        public void DecimalToOtherNumeralSystem_OverflowException(int acceptedNumber, int acceptedBase)
        {
            Assert.Throws<OverflowException>(() => new NumeralSystemConverter(acceptedNumber, acceptedBase));

        }

        [TestCase(20, 1)]
        [TestCase(20, -1)]
        [TestCase(10, 21)]
        [TestCase(10, -21)]        
        public void CreatingRepresentationOfNumberInNewSystemTest_ArgumentOutOfRangeException(int acceptedNumber, int ecceptedBase)
        {
            try
            {
                var convertedNumber = new NumeralSystemConverter(acceptedNumber, ecceptedBase);
                convertedNumber.DecimalToOtherNumeralSystem();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.IsTrue(e.ToString()!= string.Empty);
            }
        }
    }
}
