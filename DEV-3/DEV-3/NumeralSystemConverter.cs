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
        /// A method that creates a string that is a representation of a number in the new numeral system.
        /// </summary> 
        /// <returns>Value In New System.</returns>
        public string DecimalToOtherNumeralSystem()
        {            
            var valueInNewSystem = new StringBuilder();
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

            if (_negativeNumber)
            {
                valueInNewSystem.Append('-');
            }

            return new string(valueInNewSystem.ToString().Reverse().ToArray());
        } 
    }
}