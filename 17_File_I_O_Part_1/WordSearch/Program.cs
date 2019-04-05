using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilePath:  C:\Users\Warren Stowe\exercises\17_File_I_O_Part_1\alices_adventures_in_wonderland.txt

            //1. Ask the user for the search string
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fileName = Console.ReadLine().ToLower();
            //2. Ask the user for the file path
            Console.WriteLine("What is the search word you are looking for?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Is the word case sensitive?  (Enter y)");
            string caseInput = Console.ReadLine().ToLower();

            bool caseSensitive = false;

            if (caseInput.Equals("y"))
            {
                caseSensitive = true;
            }

            int lineCounter = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    //4. Loop through each line in the file
                    while (!sr.EndOfStream)
                    {
                        lineCounter++;
                        string line = "";

                        line = sr.ReadLine();

                        //5. If the line contains the search string, print it out along with its line number
                        if (CheckLine(line, searchWord, caseSensitive))
                        {
                            Console.WriteLine($"Line {lineCounter}: {line}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            Console.ReadKey();
        }

        // This method returns true if the searched word appears in the current string.  It accounts for case sensitive and non-
        // case sensitive requests
        public static bool CheckLine(string line, string word, bool caseSensitive)
        {
            if (!caseSensitive)
            {
                // converts the current line and the search word to lowercase if the user doesn't care about case sensitivity
                line = line.ToLower();
                word = word.ToLower();
            } 

            if (line.Contains(word))
            {
                return true;
            }

            return false;

        }
    }
}
