using System;

namespace DEV_3
{
    /// <summary> 
    /// EntryPoint accept from the command line two arguments
    /// and convert number (1 argument) in the new numeral system (2 argument)
    /// </summary> 
    class EntryPoint
    {       
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(args[0]);
                int newBase = int.Parse(args[1]);                
                if (newBase < 2 || newBase > 20)
                {
                    throw new ArgumentOutOfRangeException("wrong base of new numeral system.");
                }                
                NumeralSystemConverter EntryPointObject = new NumeralSystemConverter();
                if (number >= 0)
                {
                    Console.WriteLine(number + " in the " + newBase + " numeral system = " + EntryPointObject.DecimalToOtherNumeralSystem(number, newBase));
                }
                else
                {
                    Console.WriteLine(number + " in the " + newBase + " numeral system =  -" + EntryPointObject.DecimalToOtherNumeralSystem(number, newBase));
                }
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

