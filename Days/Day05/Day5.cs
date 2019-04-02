using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public static class Day5
    {
        // How many units remain after fully reacting the polymer you scanned?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create a string builer to make the whol FileInput into 1 string.
            StringBuilder Builder = new StringBuilder();
            foreach(string Input in FileInput)
            {
                Builder.Append(Input);
            }
            string StringFile = Builder.ToString();

            // Changes the string to a list of char's
            List<char> CharFile = new List<char>();
            CharFile.AddRange(StringFile);

            // Loop through each character removing if there is a match and starting over to compare new values.
            int TotalCharacterCount = CharFile.Count - 1;
            for(int Character = 0; Character < TotalCharacterCount; Character++)
            {
                // Use each charters integer value to compare with the next character in the lists integer value (Decimal ASCII Value).
                if((int)CharFile[Character] == (int)CharFile[Character + 1] + 32 || (int)CharFile[Character] == (int)CharFile[Character + 1] - 32)
                {
                    CharFile.RemoveAt(Character);
                    CharFile.RemoveAt(Character);
                    TotalCharacterCount = TotalCharacterCount - 2;
                    Character = -1;
                }
            }
            return CharFile.Count;
        }

        // What is the length of the shortest polymer you can produce by removing all units of exactly one type and fully reacting the result?
        public static int Part2(IEnumerable<string> FileInput)
        {
            // Create a string builer to make the whol FileInput into 1 string.
            StringBuilder Builder = new StringBuilder();
            foreach(string Input in FileInput)
            {
                Builder.Append(Input);
            }
            string StringFile = Builder.ToString();

            // Changes the string to a list of char's
            List<char> CharFile = new List<char>();

            // Create a Variable to keep track of the smallest variable
            int SmallestValue = int.MaxValue;

            // Loop through all letters A-Z
            for(int Letter = 0; Letter < 26; Letter++)
            {
                // Clear the list of char's and add StringFile again
                CharFile.Clear();
                CharFile.AddRange(StringFile);

                // Loop through the list of characters and remove the current letter
                int TotalCharacterCount = CharFile.Count - 1;
                for(int Character = 0; Character < TotalCharacterCount; Character++)
                {
                    if((int)CharFile[Character] == 65 + Letter || (int)CharFile[Character] == 97 + Letter)
                    {
                        CharFile.RemoveAt(Character);
                        Character--;
                        TotalCharacterCount--;
                    }
                }
                
                // Use each charters integer value to compare with the next character in the lists integer value (Decimal ASCII Value).
                for(int Character = 0; Character < CharFile.Count - 1; Character++)
                {
                    // Use each charters integer value to compare with the next character in the lists integer value (Decimal ASCII Value).
                    if((int)CharFile[Character] == (int)CharFile[Character + 1] + 32 || (int)CharFile[Character] == (int)CharFile[Character + 1] - 32)
                    {
                        CharFile.RemoveAt(Character);
                        CharFile.RemoveAt(Character);
                        TotalCharacterCount = TotalCharacterCount - 2;
                        Character = -1;
                    }
                }

                // Check the total character count after each letters loop
                if(SmallestValue > CharFile.Count)
                {
                    SmallestValue = CharFile.Count;
                }
            }
            return SmallestValue;
        }
    }
}