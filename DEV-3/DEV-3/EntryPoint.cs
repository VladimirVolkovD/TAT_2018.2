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
                int newBaseOfNumberSystem = int.Parse(args[1]);                
                if (newBaseOfNumberSystem < 2 || newBaseOfNumberSystem > 20)
                {
                    throw new ArgumentOutOfRangeException("wrong base of new numeral system.");
                }                
                NumeralSystemConverter EntryPointObject = new NumeralSystemConverter();
                Console.WriteLine(number + " in the " + newBaseOfNumberSystem + " numeral system = " + Math.Sign(number) + EntryPointObject.DecimalToOtherNumeralSystem(number, newBaseOfNumberSystem));                
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

