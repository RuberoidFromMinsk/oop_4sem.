using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class TextCalculator
    {
        public static string ConcatStrings(string str1, string str2)
        {
            return $"{str1}{str2}";
        }

        public static string SubstrReplace(string stringToBeReplaced, string oldSubstr, string newSubstr)
        {
            return stringToBeReplaced.Replace(oldSubstr, newSubstr);
        }

        public static string RemoveSubstr(string text, string substring)
        {
            return text.Replace(substring, "");
        }

        public static char GetCharByIndex(string text, int index)
        {
            return Convert.ToChar(text.Substring(index, 1));
        }

        public static int GetStringLength(string text)
        {
            return text.Length;
        }

        public static string GetDoubledVowels(string text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            List<char> vowelsDic = new List<char>(vowels);
            int amountOfNotVowels = 0;
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (!vowelsDic.Contains(stringBuilder[i]))
                    amountOfNotVowels++;
            }

            return $"NotVowels = {amountOfNotVowels}";
        }
    }
}
