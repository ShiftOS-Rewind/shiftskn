using System;
using System.IO;
using System.IO.Compression;

namespace shiftskn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            int argsLength = args.Length;

            if (argsLength < 2)
            {
                ShowHelp();
            }

            if (argsLength >= 2)
            {
                if (args[0] == "picpng")
                {
                    try
                    {
                        if (args.Length >= 3)
                        {
                            Pic2PNG.Convert(args[1], args[2]);
                        }
                            Pic2PNG.Convert(args[1]);
                    }
                    catch
                    {
                        ShowHelp();
                    }
                }
                else if (args[0] == "decode")
                {
                    try
                    {
                        Decode.DecodeSkinToDir(args[1], args[2]);
                    }
                    catch
                    {
                        ShowHelp();
                    }
                }
                else
                {
                    ShowHelp();
                }
            }
        }

        static void ShowHelp()
        {
            Help.PrintHelp();
        }
    }
}