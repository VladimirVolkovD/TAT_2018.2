using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlTask
{
    class StringManager
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1) // Checking the condition for the argument
            {
                throw new Exception("Wrong number of arguments");                
            }
            else if (args.Length == 0) // Checking for the presence of elements in a row
            {
                throw new Exception("Enter a non-empty string");                
            }
                var EntryPointObject = new StringManager();
                var couple = EntryPointObject.FindMostСommonSequence(args[0]);
                couple.Show();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public CoupleOfCharacters FindMostСommonSequence(String inputedString)
        {
            var currentCouple = new CoupleOfCharacters();
            var coupleForCompare = new CoupleOfCharacters();
            var maxMatchesCouple = new CoupleOfCharacters();
            var List = new List<CoupleOfCharacters>();

            for (int i = 0; i < inputedString.Length - 1; i++)
            {
                currentCouple.FirstCharacter = inputedString[i];
                currentCouple.SecondCharacter = inputedString[++i];
                currentCouple.AmountOfmatches = 0;
                i--;

                for (int j = i; j < inputedString.Length - 1; j++)
                {
                    coupleForCompare.FirstCharacter = inputedString[j];
                    coupleForCompare.SecondCharacter = inputedString[++j];
                    j--;
                    currentCouple.CountMatches(coupleForCompare);
                }
                List.Add(currentCouple);
            }

            foreach (var i in List)
            {
                if (List.Select(p => p.AmountOfmatches).Max() == i.AmountOfmatches) maxMatchesCouple = i;
            }
            return maxMatchesCouple;
        }
    }

}

