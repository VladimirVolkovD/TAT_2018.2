using System.Text;

namespace Dev1
{
    static class ArgsToString
    {
        /// <summary>
        /// The ArgsToString class that forms a string from the command line arguments
        /// </summary>
        public static string ArrayToString(this string[] args)
        {
            StringBuilder concatenatedString = new StringBuilder();

            foreach (string i in args)
            {
                concatenatedString.Append(i + " ");
            }

            concatenatedString.Remove(concatenatedString.Length - 1, 1); // Delete last space bar

            return concatenatedString.ToString();
        }
    }
}