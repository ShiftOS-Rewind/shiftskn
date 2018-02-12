using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace shiftskn
{
    public abstract class Decode
    {
        public static void DecodeSkinToDir(string inputFile, string outputPath)
        {
            string folderName = @"\" + Path.GetFileNameWithoutExtension(inputFile);
            outputPath = outputPath.TrimEnd(Path.DirectorySeparatorChar);
            outputPath = outputPath + folderName;
            ZipFile.ExtractToDirectory(inputFile, outputPath);
            Console.WriteLine("Extracted " + Path.GetFileName(inputFile) + " to " + outputPath);
        }
    }
}
