using System;
using System.Collections.Generic;
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
            string[] spliters = { ",", "-", " ", ":", ";",  "!", "?", "\r", "\n"};
            string[]  ClearArrayOfWords = fileText.Split(spliters, StringSplitOptions.RemoveEmptyEntries);
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

    public static class Algorithms
    {
        public static SortedList<string, int> CountWordsPlease(string text)
        {
            SortedList<string, int> WordAmountList = new SortedList<string, int>();
            text = text.Replace(",", "").Replace("!", "").Replace(".", "").Replace("\n", " ").Replace(";", "").Replace("\r", "");
            string[] words = text.Split(' ');
            words = words.Select(s => s.ToLowerInvariant()).ToArray();
            foreach (string x in words)
            {
                Console.WriteLine(x);
                if (WordAmountList.ContainsKey(x))
                {
                    WordAmountList[x] += 1;
                }
                else
                    WordAmountList.Add(x, 1);
            }
            return WordAmountList;
        }

        public static int LongestCommonSubstring(string stringOne, string stringTwo)
        {
            string longestSubstring = "";
            int[,] table = CreateTable(stringOne, stringTwo);
            int[] MaximumInfo = GetMaxElement(table);

            for (int i = MaximumInfo[0] + 1 - MaximumInfo[1]; i <= MaximumInfo[0]; i++)
            {
                longestSubstring += stringOne[i];

            }
            return longestSubstring.Length;
        }

        private static int[,] CreateTable(string stringOne, string stringTwo)
        {
            int[,] table = new int[stringOne.Length, stringTwo.Length];
            for (int i = 0; i < stringOne.Count(); i++)
            {
                for (int j = 0; j < stringTwo.Count(); j++)
                {
                    if ((i == 0 || j == 0) && stringOne[i] == stringTwo[j]) table[i, j] = 1;
                    else
                    {
                        if (stringOne[i] == stringTwo[j])
                            table[i, j] = table[i - 1, j - 1] + 1;
                        else
                            table[i, j] = 0;
                    }

                }
            }
            return table;
        }

        private static int[] GetMaxElement(int[,] array)
        {
            int[] result = new int[2];
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            int max = array[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        result[0] = i; // index of row
                        result[1] = max; // maximum value
                    }
                }
            }
            return result;
        }
        /* pat -> pattern  
            txt -> text  
            q -> A prime number  
        */
        // LengthOfDictionary is the number of characters in the input alphabet  

        public readonly static int LengthOfDictionary = 256;

        public static int[] search(String pat, String txt)
        {
            int PrimeNumber = 101;
            List<int> result= new List<int>();
            int M = pat.Length;
            int N = txt.Length;
            int i, j;
            int pattern = 0; // hash value for pattern   
            int text = 0; // hash value for txt  
            int hash = 1;

            for (i = 0; i < M - 1; i++)
                hash = (hash * LengthOfDictionary) % PrimeNumber;

            // Calculate the hash value of pattern and text  
            for (i = 0; i < M; i++)
            {
                pattern = (LengthOfDictionary * pattern + pat[i]) % PrimeNumber;
                text = (LengthOfDictionary * text + txt[i]) % PrimeNumber;
            }

            // rolling hashing 
            for (i = 0; i <= N - M; i++)
            {

                // if match found
                if (pattern == text)
                {
                    // check characters one by one
                    for (j = 0; j < M; j++)
                    {
                        if (txt[i + j] != pat[j])
                            break;
                    }

                    if (j == M)
                        result.Add(i);
                }

                // Calculate hash value for next window of text: Remove  
                // leading digit, add trailing digit  
                if (i < N - M)
                {
                    text = (LengthOfDictionary * (text - txt[i] * hash) + txt[i + M]) % PrimeNumber;

                    // We might get negative value of t, converting it  
                    // to positive  
                    if (text < 0)
                        text = (text + PrimeNumber);
                }
            }
            return result.ToArray();
        }
        
    }
}
    

