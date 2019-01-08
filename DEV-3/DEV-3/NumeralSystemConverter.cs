using System;
using System.Linq;
using System.Text;

namespace DEV_3
{
    /// <summary> 
    /// This class converts decimal number in other numeral system.
    /// </summary>
    public class NumeralSystemConverter
    {
        private int _number;
        private readonly int _newBase;
        private readonly bool _negativeNumber;

        private const int MaxRadix = 20;
        private const int MinRadix = 2;

        /// <summary>
        /// Class constructor for NumeralSystemConverter.
        /// </summary>
        /// <param name="number">Number.</param>
        /// <param name="newBase">New base of numeral system.</param>
        public NumeralSystemConverter(int number,int newBase)
        {
            if (newBase >= MinRadix && newBase <= MaxRadix)
            {
                _negativeNumber = number < 0;
                _number = Math.Abs(number);
                _newBase = newBase;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Wrong base of new numeral system.");
            }
        }

        /// <summary> 
<<<<<<< HEAD
        /// A method that creates a string that is a representation of a number in the new numeral system.
        /// </summary> 
        /// <returns>Value In New System.</returns>
        public string DecimalToOtherNumeralSystem()
        {            
            var valueInNewSystem = new StringBuilder();
=======
        /// Creates a string that is a representation of a number in the new numeral system.
        /// </summary> 
        /// <returns>Value In New System.</returns>
        public string DecimalToOtherNumeralSystem()
        {
            if (newBase < 2 || newBase > 20)
            {
                throw new Exception("WrongBaseOfNumeralSystemException: Value of new numeral system must be between 2 and 20.");
            }
            StringBuilder valueInNewSystem = new StringBuilder();            
>>>>>>> 64eab100493a289255a16e47bf771741751d31e7
            do
            {
                var numberToAdd = _number % _newBase;
                _number = _number / _newBase;
                if (numberToAdd < 10)
                {
                    var tempCharSymbol = (char)(numberToAdd + '0');
                    valueInNewSystem.Append(tempCharSymbol.ToString());
                }
                else 
                {
                    var tempCharSymbol = (char)('A' + numberToAdd - 10);
                    valueInNewSystem.Append(tempCharSymbol.ToString());
                }

            } while (0 != _number);

<<<<<<< HEAD
            if (_negativeNumber)
            {
                valueInNewSystem.Append('-');
            }

            return new string(valueInNewSystem.ToString().Reverse().ToArray());
        }   
=======
            covertedNumber = ReverseString(valueInNewSystem.ToString());            
            return covertedNumber;
        }

        /// <summary>
        /// Reverses the order of the elements in a  string.
        /// </summary>
        /// <param name="stringForReverse">String for reverse.</param>
        /// <returns>Reversed string.</returns>
        string ReverseString(string stringForReverse)
        {
            char[] reversedString = stringForReverse.ToCharArray();
            Array.Reverse(reversedString);
            return new string(reversedString);
        }  
>>>>>>> 64eab100493a289255a16e47bf771741751d31e7
    }
}