using System;
using System.Collections.Generic;
using System.Text;

namespace shiftskn
{
    public abstract class Help
    {
        public static void PrintHelp()
        {
            Console.WriteLine("ShiftOS Skin Decoder v1.0 - By AShifter\n");
            Console.WriteLine("args:\n" +
                              "decode [INPUTPATH] [OUTPUTPATH] [SKINVER] [FLAGS] | Decode a SKN file\n" +
                              "picpng [INPUTPATH] [(optional)OUTPUTPATH] [FLAGS] | convert a .PIC to a .PNG");
        }
    }
}
