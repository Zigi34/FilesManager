using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FilesManager;
using System.IO;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var lList = new List<FileInfo>();
            lList.Add(new FileInfo("banan.txt"));
            lList.Add(new FileInfo("favorit.txt"));
            lList.Add(new FileInfo("hamburger.txt"));
            lList.Add(new FileInfo("janek.txt"));
            lList.Add(new FileInfo("karambol.txt"));
            lList.Add(new FileInfo("kolinka.txt"));
            lList.Add(new FileInfo("mesic.txt"));
            lList.Add(new FileInfo("PISTACIE.txt"));
            lList.Add(new FileInfo("utopie.txt"));

            Worker.RenameFiles(lList, "", "");
        }
    }
}
