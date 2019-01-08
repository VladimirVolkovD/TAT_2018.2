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
                var number = int.Parse(args[0]);
                var newBaseOfNumberSystem = int.Parse(args[1]);
                var numeralSystemConverter = new NumeralSystemConverter(number, newBaseOfNumberSystem);
                
                Console.WriteLine("Number in decimal = {0} in the {1} numeral system  = {2}", number,
                    newBaseOfNumberSystem, numeralSystemConverter.DecimalToOtherNumeralSystem());

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

            Console.ReadKey();
        }
    }
}