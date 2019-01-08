using System;

namespace DEV_3
{
    /// <summary> 
    /// Decimal number converter to other numeral systems
    /// accept from the command line two arguments
    /// and convert number (1 argument) in the new numeral system (2 argument).
    /// </summary> 
    class Converter
    {
        static void Main(string[] args)
        {
            try
            {
                var number = int.Parse(args[0]);
                var newBaseOfNumberSystem = int.Parse(args[1]);
                var numeralSystemConverter = new NumeralSystemConverter(number, newBaseOfNumberSystem);
                
                Console.WriteLine("Number in decimal = {0} in the {1} numeral system  = {2}", number,
                    newBaseOfNumberSystem, numeralSystemConverter.DecimalToOtherNumeralSystem());
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

            Console.ReadKey();
        }
    }
}

