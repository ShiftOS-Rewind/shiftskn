using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace shiftskn
{
    public abstract class Pic2PNG
    {
        public static void Convert(string input, string output = "")
        {
            if (output == "" || output == null)
            {
                output = input;
            }
            Image pic = Image.FromFile(input);
            output = Path.ChangeExtension(output, "png");
            pic.Save(output, ImageFormat.Png);
            Console.WriteLine("Converted " + Path.GetFileName(input) + " to " + Path.GetFileName(output));
        }
    }
}
