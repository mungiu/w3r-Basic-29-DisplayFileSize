using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3R_Basics_29_Display_File_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\Andrei\Pictures\Camera Roll\WIN_20170710_19_56_49_Pro.mp4");
            var size = fileInfo.Length;
            Console.WriteLine("File Size in Bytes: {0}", size);
        }
    }
}
