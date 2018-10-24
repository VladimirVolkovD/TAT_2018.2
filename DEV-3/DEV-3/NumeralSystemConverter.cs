using System;
using System.Text;

namespace DEV_3
{   
    /// <summary> 
    /// This class converts decimal number in other numeral system
    /// </summary>
    class NumeralSystemConverter
    {
        int number;
        int newBase;
        int sign;
        string covertedNumber;
        
        /// <summary>
        /// Constructor class for NumeralSystemConverter
        /// </summary>
        /// <param name="number">number</param>
        /// <param name="newBase">new base of numeral system</param>
        public NumeralSystemConverter(int number,int newBase)
        {
            sign = Math.Sign(number);
            this.number =  Math.Abs(number);
            this.newBase = newBase;
        }

        /// <summary> 
        /// Method DecimalToOtherNumeralSystem
        /// A method that creates a string that is a representation of a number in the new numeral system
        /// </summary> 
        /// <returns>Value In New System</returns>
        public void DecimalToOtherNumeralSystem()
        {            
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
        }       

        /// <summary>
        /// Reverses the order of the elements in a  string
        /// </summary>
        /// <param name="stringForReverse">string for reverse</param>
        /// <returns></returns>
        private string ReverseString(string stringForReverse)
        {
            char[] reversedString = stringForReverse.ToCharArray();
            Array.Reverse(reversedString);
            return new string(reversedString);
        }

        /// <summary>
        /// Method depending on the sign of number correctly displays the converted number
        /// </summary>
        public void writeCovertedNumber()
        {
            if (sign != 1)
            {
                Console.WriteLine(number + " in the " + newBase + " numeral system =  -" + covertedNumber);
            }
            else
            {
                Console.WriteLine(number + " in the " + newBase + " numeral system = " + covertedNumber);
            }
        }
    }
}
