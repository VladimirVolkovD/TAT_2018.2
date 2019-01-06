using System;

namespace ControlTask
{
    struct CoupleOfCharacters
    {
        public char FirstCharacter;
        public char SecondCharacter;
        public int AmountOfmatches;

        public int CountMatches(CoupleOfCharacters compare)
        {
            AmountOfmatches += ((FirstCharacter == compare.FirstCharacter) && (SecondCharacter == compare.SecondCharacter)) ? 1 : 0;
            return AmountOfmatches;
        }

        public void Show()
        {
            Console.WriteLine("\nCouple of characters: " + FirstCharacter +  SecondCharacter + "\nAmount: " + AmountOfmatches);
        }
    }
}
