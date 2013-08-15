using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Extensions
{
    public static class FileExtension
    {
        private static char[] mInvalidChars = Path.GetInvalidFileNameChars();
        public static string FormatFileName(this FileInfo aFile, string aPrexif, string aSuffix, int aValue, int aNumericCount)
        {
            if (aFile != null)
            {
                if (!aFile.Exists)
                    throw new FileNotFoundException("Soubor (" + aFile.FullName + ") neexistuje");

                var lZeroCount = (int)(aNumericCount - (Math.Truncate(Math.Log10(aValue)) + 1));
                if (lZeroCount < 0)
                    throw new Exception("Chybný počet číslic pro formátování názvu souboru");

                var lNewFileName = string.Format("{0}{1}{2}{3}{4}",
                    aPrexif,
                    "".AppendChars('0', lZeroCount),
                    aValue,
                    aSuffix,
                    Path.GetExtension(aFile.Name)
                    );

                if (lNewFileName.IndexOfAny(mInvalidChars) >= 0)
                    throw new NotSupportedException("Byly použity nepodporované znaky pro název souboru. Soubor: \"" + lNewFileName + "\"");

                return lNewFileName;
            }
            return "";
        }
    }
}
