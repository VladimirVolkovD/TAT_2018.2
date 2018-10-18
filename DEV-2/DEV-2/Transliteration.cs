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
               Console.OutputEncoding = Encoding.UTF8;//for adequate display Cyrillic
               Transliteration EntryPointObject = new Transliteration();
               string inputString = args.ArrayToString(); // Form string from arguments array 
               AutoDecideTransliteration entryTransliteration = new AutoDecideTransliteration();
               entryTransliteration.AutoTransliteration(ref inputString);
               Console.WriteLine("your transliterated string: " + inputString); 
        }       
    }
}
