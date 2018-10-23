using System;
using System.Text;

namespace DEV_3
{
    /// <summary> 
    /// This class converts decimal number in other numeral system
    /// </summary>
    class NumeralSystemConverter
    {
        /// <summary> 
        /// Method DecimalToOtherNumeralSystem
        /// A method that creates a string that is a representation of a number in the new numeral system
        /// </summary> 
        /// <returns>Value In New System</returns>
        public string DecimalToOtherNumeralSystem(int number, int newBase)
        {            
            StringBuilder valueInNewSystem = new StringBuilder();            
            do
            {
                int numberToAdd;
                numberToAdd = number % newBase;
                valueInNewSystem.Append(FigureConverter(numberToAdd));
                number = number / newBase;

            } while (0 != number);
            string ConvertedString;             
            return ReverseString(valueInNewSystem.ToString());
        }

        /// <summary>
        /// Converts decimal numeral to new numeral  numeral system
        /// </summary>
        /// <param name="numbertForTranslation"></param>
        /// <returns></returns>
        private string FigureConverter(int numbertForTranslation)
        {
            char figureInNewSystem;
            string possibleValues = "0123456789ABCDEFGHIJ";
            figureInNewSystem = possibleValues[Math.Abs(numbertForTranslation)];
            return Convert.ToString(figureInNewSystem);
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
    }
}
