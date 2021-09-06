using System;
using System.Text;

namespace AlphabetAndNumbers.Utils
{
    public static class StringToInt
    {
        private const int numGap = 31;
        public static string StringChallenge(string str)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    builder.Append((str[i] & numGap));
                }
                else
                {
                    builder.Append(str[i]);
                }
            }

            return builder.ToString();
        }
    }
}
