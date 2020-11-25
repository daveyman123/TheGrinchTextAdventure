using System;
using System.IO;

namespace TheGrinch.HelperFunctions
{
    class ArtReadHelper
    {
        public static String ascii(string FileName)
        {
            
            string FileUrl = "Art/" + FileName + ".txt";

            string text = File.ReadAllText(FileUrl);
            return text;
        }
    }
}
