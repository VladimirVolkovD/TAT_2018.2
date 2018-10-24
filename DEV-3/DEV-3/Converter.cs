using System;

namespace DEV_3
{
    /// <summary> 
    /// Decimal number converter to other numeral systems
    /// accept from the command line two arguments
    /// and convert number (1 argument) in the new numeral system (2 argument)
    /// </summary> 
    class Converter
    {       
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(args[0]);
                int newBaseOfNumberSystem = int.Parse(args[1]);                
                if (newBaseOfNumberSystem < 2 || newBaseOfNumberSystem > 20)
                {
                    throw new ArgumentOutOfRangeException("wrong base of new numeral system.");
                }                
                NumeralSystemConverter convertedNumber = new NumeralSystemConverter(number, newBaseOfNumberSystem);
                convertedNumber.DecimalToOtherNumeralSystem();
                convertedNumber.writeCovertedNumber();
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception message: strings contain wrong symbols or null.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception message: " + ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: " + ex.Message);
            }            
        }
    }
}

