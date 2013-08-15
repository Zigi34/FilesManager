using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Extensions
{
    public static class StringExtension
    {
        public static string AppendChars(this string aString, char aChar, int aCount)
        {
            if (Char.IsWhiteSpace(aChar) || aCount <= 0)
                return aString;

            StringBuilder lSb = new StringBuilder();
            lSb.Append(aString);
            for (int lIndex = 0; lIndex < aCount; lIndex++)
            {
                lSb.Append(aChar);
            }
            return lSb.ToString();
        }
    }
}
