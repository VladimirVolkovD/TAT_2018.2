using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_2
{
    class CyrillicLatinTransliteration
    {
        public  void autoTransliteration(ref String stringArgument)
        {
            string check = String.Copy(stringArgument);
            String.Concat(check.OrderBy(c => c));


            if (Enumerable.Range(1072, 1103).Contains(check[0]) && (Enumerable.Range(1072, 1103).Contains(check[check.Length - 1]))) CyrillicToLatinTransliteration(ref stringArgument);
            else if (Enumerable.Range(97, 122).Contains(check[0]) && (Enumerable.Range(97, 122).Contains(check[check.Length - 1]))) LatinToCyrillicTransliteration(ref stringArgument);
            else
            {
                Console.WriteLine("The string must contain only Russian or English letters");
                System.Environment.Exit(0);
            }
        }


        static void CyrillicToLatinTransliteration(ref String stringArgument)
        {
            StringBuilder transliteratedString = new StringBuilder();
            transliteratedString.Append(stringArgument);
            Dictionary<string, string> cyrillicToLatinDictionary = new Dictionary<string, string>
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
                ["ъ"] = String.Empty,
                ["ы"] = "y",
                ["ь"] = String.Empty,
                ["э"] = "e",
                ["ю"] = "yu",
                ["я"] = "ya"

            };

            foreach (string i in cyrillicToLatinDictionary.Keys)
            {
                transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
            }

            stringArgument = transliteratedString.ToString();
        }

        static void LatinToCyrillicTransliteration(ref String stringArgument)
        {
            StringBuilder transliteratedString = new StringBuilder();
            transliteratedString.Append(stringArgument);
            Dictionary<string, string> cyrillicToLatinDictionary = new Dictionary<string, string>
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
            };

            foreach (string i in cyrillicToLatinDictionary.Keys)
            {
                transliteratedString.Replace(i, cyrillicToLatinDictionary[i]);
            }

            stringArgument = transliteratedString.ToString();
        }
    }
}
