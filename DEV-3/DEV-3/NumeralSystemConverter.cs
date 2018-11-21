using System;
using System.Text;

namespace DEV_3
{
    /// <summary> 
    /// This class converts decimal number in other numeral system.
    /// </summary>
    public class NumeralSystemConverter
    {
        public int number;
        public int newBase;
        public int sign;
        public string covertedNumber;       

        /// <summary>
        /// Class constructor for NumeralSystemConverter.
        /// </summary>
        /// <param name="number">Number.</param>
        /// <param name="newBase">New base of numeral system.</param>
        public NumeralSystemConverter(int number,int newBase)
        {
            sign = Math.Sign(number);
            this.number =  Math.Abs(number);
            this.newBase = newBase;
        }

        /// <summary> 
        /// Creates a string that is a representation of a number in the new numeral system.
        /// </summary> 
        /// <returns>Value In New System.</returns>
        public string DecimalToOtherNumeralSystem()
        {
            if (newBase < 2 || newBase > 20)
            {
                throw new Exception("WrongBaseOfNumeralSystem.");
            }
            StringBuilder valueInNewSystem = new StringBuilder();            
            do
            {
                int numberToAdd = number % newBase;
                number = number / newBase;
                if (numberToAdd < 10)
                {
                    char tempCharSymbol = (char)(numberToAdd + '0');
                    valueInNewSystem.Append(tempCharSymbol.ToString());
                }
                else 
                {
                    char tempCharSymbol = (char)('A' + numberToAdd - 10);
                    valueInNewSystem.Append(tempCharSymbol.ToString());
                }

            } while (0 != number);

            covertedNumber = ReverseString(valueInNewSystem.ToString());            
            return covertedNumber;
        }

        /// <summary>
        /// Reverses the order of the elements in a  string.
        /// </summary>
        /// <param name="stringForReverse">String for reverse.</param>
        /// <returns>Reversed string.</returns>
        public string ReverseString(string stringForReverse)
        {
            char[] reversedString = stringForReverse.ToCharArray();
            Array.Reverse(reversedString);
            return new string(reversedString);
        }  
    }
}
