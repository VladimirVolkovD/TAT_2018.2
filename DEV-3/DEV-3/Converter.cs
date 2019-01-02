using System;

namespace DEV_3
{
    /// <summary> 
    /// Decimal number converter to other numeral systems
    /// accept from the command line two arguments
    /// and convert number (1 argument) in the new numeral system (2 argument).
    /// </summary> 
    public class Converter
    {
        public static void Main(string[] args)
        {
            try
            {                
                int number = int.Parse(args[0]);
                int newBaseOfNumberSystem = int.Parse(args[1]);                
                NumeralSystemConverter convertedNumber = new NumeralSystemConverter(number, newBaseOfNumberSystem);
                convertedNumber.DecimalToOtherNumeralSystem();
                WriteCovertedNumber(convertedNumber, number);                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("WrongNumberOfParametersException: You should enter two decimal numbers.");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: You should enter only decimal numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Method depending on the sign of number correctly displays the converted number.
        /// </summary>
        static void WriteCovertedNumber(NumeralSystemConverter convertedNumber,int number)
        {
            if (convertedNumber.sign != 1)
            {
                Console.WriteLine(number + " in the " + convertedNumber.newBase + " numeral system =  -" + convertedNumber.covertedNumber);
            }
            else
            {
                Console.WriteLine(number + " in the " + convertedNumber.newBase + " numeral system = " + convertedNumber.covertedNumber);
            }
        }
    }
}

