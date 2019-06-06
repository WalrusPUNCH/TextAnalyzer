using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextAnalyzer
{
    public static class Parser
    {
        public static string[] ParseFirstFile(string Path)
        {
            string fileText = System.IO.File.ReadAllText(Path, Encoding.UTF8).ToLower();
            string[] spliters = { ",", "-", " ", ":", ";", "!", "?", "\r", "\n" };
            string[] ClearArrayOfWords = fileText.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
            ClearArrayOfWords = ClearArrayOfWords.Where(val => val != "").ToArray();

            return ClearArrayOfWords;
        }

        public static string ParseSecondFile(string Path)
        {
            string fileText = System.IO.File.ReadAllText(Path, Encoding.UTF8);
            return Regex.Replace(fileText, "[-?!)(,:]", "").ToLower().Replace("\r\n", "\n");
        }

        public static string GetRawText(string Path)
        {
            return System.IO.File.ReadAllText(Path, Encoding.UTF8);
        }

    }
}
