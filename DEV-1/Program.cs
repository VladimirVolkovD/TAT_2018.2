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
			if (args.Length != 0)// Checking the condition for the argument
			{
				MaximuNumberOfUnequalConsecutive EntryPointObject = new MaximuNumberOfUnequalConsecutive();
				string inputString = args.ArrayToString(); // Form string from arguments array

				Console.WriteLine(EntryPointObject.SearchLengthofUnequalSymbol(inputString));
			}
			else
			{
				Console.WriteLine("Exception message: wrong arguments number.");
				return;
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
			string buffer = ""; //Temporal storage for subsequences
			int MaximumSubsequenceLength = 0;

			for (int i = 0; i < stringArgument.Length; i++)
			{
				if (buffer.Contains(stringArgument[i]))
				{
					i -= (buffer.Length - buffer.LastIndexOf(stringArgument[i]));
					buffer = "";
				}
				else
				{
					buffer = buffer + stringArgument[i];
					if (MaximumSubsequenceLength < buffer.Length)
					{
						MaximumSubsequenceLength = buffer.Length;
					}
				}
			}

			return MaximumSubsequenceLength;
		}
	}
}
