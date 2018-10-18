using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// Arguments to string.
    /// </summary>
    static class ArgsToString
    {
        /// <summary>
        /// The ArgsToString class that forms a string from the command line arguments
        /// and converts resault to lowercase 
        /// </summary>
        public static string ArrayToString(this string[] args)
        {
            StringBuilder concatenatedString = new StringBuilder();
            String returnString = String.Empty;

            foreach (string i in args)
            {
                concatenatedString.Append(i + " ");
            }

            concatenatedString.Remove(concatenatedString.Length - 1, 1); // Delete last space bar
            returnString = concatenatedString.ToString();   

            return returnString.ToLower();
        }
    }
}