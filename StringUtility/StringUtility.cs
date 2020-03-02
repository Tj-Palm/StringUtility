using System;

namespace StringUtility
{
    public class StringUtility
    {
        public int CountOccurences(string stringToCheck, char stringToFind)
        {
            int result = 0;

            if (stringToCheck == null || stringToFind == null)
            {
                return -1;
            }

            foreach (var character in stringToCheck)
            {
                if (character.ToString().ToUpper() == stringToFind.ToString().ToUpper())
                {
                    result++;
                }
            }

            return result;
        }

    }
}
