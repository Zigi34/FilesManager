using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Extensions;

namespace FilesManager
{
    public class Worker
    {
        public static void RenameFiles(IEnumerable<FileInfo> aFilesCollection, string aPrexif, string aSuffix)
        {
            if (aFilesCollection != null && (aFilesCollection.Count() > 0))
            {
                var lNumber = 1;
                var lNumberCount = Math.Truncate(Math.Log10(aFilesCollection.Count())) + 1;
                var lInvalidChars = Path.GetInvalidFileNameChars();
                foreach (var lFile in aFilesCollection)
                {
                    if (!lFile.Exists)
                        throw new FileNotFoundException("Soubor (" + lFile.FullName + ") neexistuje");

                    var lNewFileName = string.Format("{0}{1}{2}{3}{4}", 
                        aPrexif, 
                        "".AppendChars('0', ZeroCountPrefix(lNumber, (int)lNumberCount)),
                        lNumber,
                        aSuffix,
                        Path.GetExtension(lFile.Name).ToLower()
                        );
                    
                    if (lNewFileName.IndexOfAny(lInvalidChars) > 0)
                        throw new NotSupportedException("Byly použity nepodporované znaky pro název souboru. Soubor: \"" + lNewFileName + "\"");

                    File.Move(lFile.FullName, lFile.DirectoryName + @"\" + lNewFileName);

                    lNumber++;
                }
            }
        }

        private static int ZeroCountPrefix(int aValue, int aMaxNumberCount)
        {
            if (aValue < 0 || aMaxNumberCount <= 0)
                return 0;

            var lNumberCount = Math.Truncate(Math.Log10(aValue)) + 1;
            if (lNumberCount > aMaxNumberCount)
                return 0;
            return (int)(aMaxNumberCount - lNumberCount);
        }
    }
}
