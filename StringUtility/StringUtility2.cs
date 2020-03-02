using System;
using System.Collections.Generic;
using System.Text;

namespace StringUtility
{
    public class StringUtility2
    {
        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            int result = 0;

            if (stringToCheck == null || stringToFind == null)
            {
                return -1;
            }

            if (stringToCheck == "" || stringToFind == "")
            {
                return 0;
            }

            if (stringToFind.Length > 1)
            {
                for (int i = 0; i < stringToCheck.Length-stringToFind.Length; i++)
                {
                    for (int t = 0; t < stringToFind.Length; t++)
                    {
                        if (stringToCheck[i+t].ToString().ToUpper() == stringToFind[t].ToString().ToUpper())
                        {
                            result++;
                        }
                        else
                        {
                            result = 0;
                        }
                    }

                }

                return result / stringToFind.Length;
            }
            else
            {
                foreach (var character in stringToCheck)
                {
                    if (character.ToString().ToUpper() == stringToFind[0].ToString().ToUpper())
                    {
                        result++;
                    }
                }
            }


            return result;
        }
    }
}
