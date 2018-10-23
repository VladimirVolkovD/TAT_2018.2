using System;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// The Transliteration class accepts a string in Russian (or in Latin) language
    /// and translates the string into the required language
    /// </summary>
    class Transliteration
    {
        static void Main(string[] args)
        {
            try
            {
                if (args[0].Length == 0)
                {
                    throw new Exception("Incorrect of argument");
                }
                Console.OutputEncoding = Encoding.UTF8;//for adequate display Cyrillic
                Transliteration EntryPointObject = new Transliteration();
                string inputString = args[0]; // Form string from arguments array 
                AutoDecideTransliteration entryTransliteration = new AutoDecideTransliteration();
                entryTransliteration.AutoTransliteration(ref inputString);
                Console.WriteLine("your transliterated string: " + inputString);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
        }       
    }
}
