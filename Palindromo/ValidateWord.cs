using System;
namespace Palindromo
{
    public class ValidateWord
    {
        public bool IsPalindrome(string word)
        {
            int wordLength = word.Length;
            char[] characters = word.ToLower().ToCharArray();
            int lastCharacterIndex = wordLength - 1;
            int middleCharacterIndex = wordLength / 2;

            for (int i = 0; i < middleCharacterIndex; i++)
            {
                if (characters[i] != characters[lastCharacterIndex - i])
                    return false;
            }

            return true;
        }
    }
}
