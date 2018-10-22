using System;
using System.Linq;

namespace Dev1
{
	/// <summary>
	/// MaximuNumberOfUnequalConsecutive
	/// searches maximum number of unequal symbols in the string
	/// and searches some exceptions
	/// </summary>
	class MaximuNumberOfUnequalConsecutive
	{
		static void Main(string[] args)
		{
            try
            {
                if (args[0].Length == 0)
                {
                    throw new Exception("Incorrect of argument");
                }
                MaximuNumberOfUnequalConsecutive EntryPointObject = new MaximuNumberOfUnequalConsecutive();
                Console.WriteLine(EntryPointObject.SearchLengthofUnequalSymbol(args[0]));
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }

		/// <summary> 
		/// Method SearchLengthofUnequalSymbol
		/// Function for finding the maximum number of consecutive unidentical elements in succession
		/// </summary> 
		/// <param name="stringArgument">String, which was inputed</param> 
		/// <returns>Maximum number of unequal consecutive symbol in a string</returns>
		int SearchLengthofUnequalSymbol(String stringArgument)
		{
			string buffer = String.Empty; //Temporal storage for subsequences
			int maximumUniqueCharsCount = 0;

			for (int i = 0; i < stringArgument.Length; i++)
			{
				if (buffer.Contains(stringArgument[i]))
				{
					i -= (buffer.Length - buffer.LastIndexOf(stringArgument[i]));
					buffer = String.Empty;
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
