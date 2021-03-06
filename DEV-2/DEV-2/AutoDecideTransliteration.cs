﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_2
{
    /// <summary>
    /// The AutoDecideTransliteration class accepts a string in Russian (or in Latin) language,
    /// converts the string to lower case, and transliterate to Latin (Russian) language.
    /// </summary>
    class AutoDecideTransliteration
    {
        /// <summary> 
        /// Method autoTransliteration
        /// function for determine from which language to which we will transliteration the string
        /// and catches exceptions.
        /// </summary> 
        /// <param name="stringArgument">String, which was inputed.</param>
        public void AutoTransliteration(ref string stringArgument)
        {
            stringArgument = stringArgument.ToLower();
            var checkString = string.Copy(stringArgument);
            checkString = string.Concat(checkString.OrderBy(c => c));
            checkString = checkString.Replace(" ", string.Empty);
            //Check for Russian symbol, it's Cyrillic a.
            if (Enumerable.Range('а', 34).Contains(checkString[0]) &&
                (Enumerable.Range('а', 34).Contains(checkString[checkString.Length - 1])))
            {
                CyrillicToLatinTransliteration(ref stringArgument);
            }//Check for Latin symbol, it's Latin a.
            else if (Enumerable.Range('a', 26).Contains(checkString[0]) &&
                     (Enumerable.Range('a', 26).Contains(checkString[checkString.Length - 1])))
            {
                LatinToCyrillicTransliteration(ref stringArgument);
            }
            else
            {
                Console.WriteLine("The string must contain only Russian or English letters");
                Environment.Exit(0);
            }
        }

        /// <summary> 
        /// Method CyrillicToLatinTransliteration
        /// Function for transliteration string from Cyrillic to Latin.
        /// </summary> 
        /// <param name="stringArgument">String for transliteration.</param>
        static void CyrillicToLatinTransliteration(ref string stringArgument)
        {
            var transliteratedString = new StringBuilder();
            transliteratedString.Append(stringArgument);
            var cyrillicToLatinDictionary = new Dictionary<string, string>
            {
                ["а"] = "a",
                ["б"] = "b",
                ["в"] = "v",
                ["г"] = "g",
                ["д"] = "d",
                ["е"] = "e",
                ["ё"] = "yo",
                ["ж"] = "zh",
                ["з"] = "z",
                ["и"] = "i",
                ["й"] = "y",
                ["к"] = "k",
                ["л"] = "l",
                ["м"] = "m",
                ["н"] = "n",
                ["о"] = "o",
                ["п"] = "p",
                ["р"] = "r",
                ["с"] = "s",
                ["т"] = "t",
                ["у"] = "u",
                ["ф"] = "f",
                ["х"] = "kh",
                ["ц"] = "ts",
                ["ч"] = "ch",
                ["ш"] = "sh",
                ["щ"] = "sch",
                ["ъ"] = string.Empty,
                ["ы"] = "y",
                ["ь"] = string.Empty,
                ["э"] = "e",
                ["ю"] = "yu",
                ["я"] = "ya",
                ["ѐ"] = string.Empty
            };

            foreach (var i in cyrillicToLatinDictionary.Keys)
            {
                transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
            }

            stringArgument = transliteratedString.ToString();
        }

        /// <summary> 
        /// Method LatinToCyrillicTransliteration
        /// Function for transliteration string from Latin to Cyrillic.
        /// </summary> 
        /// <param name="stringArgument">String for transliteration.</param>
        static void LatinToCyrillicTransliteration(ref string stringArgument)
        {
            var transliteratedString = new StringBuilder();
            transliteratedString.Append(stringArgument);
            var cyrillicToLatinDictionary = new Dictionary<string, string>
            {
                ["sch"] = "щ",
                ["sh"] = "ш",
                ["yo"] = "ё",
                ["yu"] = "ю",
                ["ya"] = "я",
                ["kh"] = "х",
                ["ts"] = "ц",
                ["ch"] = "ч",
                ["zh"] = "ж",
                ["a"] = "а",
                ["b"] = "б",
                ["v"] = "в",
                ["g"] = "г",
                ["d"] = "д",
                ["e"] = "е",
                ["z"] = "з",
                ["i"] = "и",
                ["k"] = "к",
                ["l"] = "л",
                ["m"] = "м",
                ["n"] = "н",
                ["o"] = "о",
                ["p"] = "п",
                ["r"] = "р",
                ["s"] = "с",
                ["t"] = "т",
                ["u"] = "у",
                ["f"] = "ф",
                ["y"] = "ы",
                ["j"] = string.Empty,
                ["h"] = string.Empty,
                ["w"] = string.Empty,
                ["q"] = string.Empty
            };

            foreach (var i in cyrillicToLatinDictionary.Keys)
            {
                transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
            }

            stringArgument = transliteratedString.ToString();
        }
    }
}
