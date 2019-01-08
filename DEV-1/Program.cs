using System;
using System.Linq;

namespace DEV_1
{
    /// <summary>
    /// MaximumNumberOfUnequalConsecutive
    /// searches maximum number of unequal symbols in the string
    /// and searches some exceptions
    /// </summary>
    class MaximumNumberOfUnequalConsecutive
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0].Length == 0)
                {
                    throw new Exception("Incorrect of argument");
                }
                Console.WriteLine(SearchLengthOfUnequalSymbol(args[0]));
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }

        /// <summary> 
        /// Method Search length of a unequal symbol
        /// Function for finding the maximum number of consecutive unidentical elements in succession
        /// </summary> 
        /// <param name="stringArgument">String, which was inputed</param> 
        /// <returns>Maximum number of unequal consecutive symbol in a string</returns>
        private static int SearchLengthOfUnequalSymbol(string stringArgument)
        {
            var buffer = string.Empty; //Temporal storage for subsequences
            var maximumUniqueCharsCount = 0;

            for (var i = 0; i < stringArgument.Length; i++)
            {
                if (buffer.Contains(stringArgument[i]))
                {
                    i -= (buffer.Length - buffer.LastIndexOf(stringArgument[i]));
                    buffer = string.Empty;
                }
                else
                {
                    buffer = buffer + stringArgument[i];
                    if (maximumUniqueCharsCount < buffer.Length)
                    {
                        maximumUniqueCharsCount = buffer.Length;
                    }
                }
            }
            return maximumUniqueCharsCount;
        }
    }
}
