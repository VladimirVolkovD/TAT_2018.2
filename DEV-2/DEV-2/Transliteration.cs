using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_2
{
    class Transliteration
    {
        static void Main(string[] args)
        {            
               Transliteration EntryPointObject = new Transliteration();
               string inputString = args.ArrayToString(); // Form string from arguments array 
               CyrillicLatinTransliteration entryTransliteration = new CyrillicLatinTransliteration();
               entryTransliteration.autoTransliteration(ref inputString);
               Console.WriteLine("your transliterated string: " + inputString);          
                       
        }       
    }
}
