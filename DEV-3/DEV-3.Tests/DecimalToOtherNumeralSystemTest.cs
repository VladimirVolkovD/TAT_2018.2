using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_3.Tests
{
    [TestClass]
    public class DecimalToOtherNumeralSystemTest
    {
        [TestMethod]
        public void DecimalToOtherNumeralSystemTests()
        {
            NumeralSystemConverter convertedNumber1 = new NumeralSystemConverter(255, 16);
            string actial = convertedNumber1.DecimalToOtherNumeralSystem();
            Assert.AreEqual("FF", actial);

            convertedNumber1 = new NumeralSystemConverter(0, 10);
            actial = convertedNumber1.DecimalToOtherNumeralSystem();
            Assert.AreEqual("0", actial);

            convertedNumber1 = new NumeralSystemConverter(20, 20);
            actial = convertedNumber1.DecimalToOtherNumeralSystem();
            Assert.AreEqual("10", actial);

            convertedNumber1 = new NumeralSystemConverter(int.MaxValue, 20);
            actial = convertedNumber1.DecimalToOtherNumeralSystem();
            Assert.AreEqual("1DB1F927", actial);           
        }
    }
}
