using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdventOfCode
{
    public static class Day2
    {
        // What is the checksum for your list of box IDs?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create counter variables
            int CountTwo = 0;
            int CountThree = 0;

            // Create a dictionary with each letter in it
            Dictionary<char, int> IDCharacters = new Dictionary<char, int>();
            for(char c = 'a'; c <= 'z'; c++)
            {
                IDCharacters.Add(c, 0);
            }
            
            // Loop through all lines in a file
            foreach(string Line in FileInput)
            {
                // Increment by 1 to each character in the ID
                foreach(char c in Line)
                {
                    IDCharacters[c]++;
                }

                // Reset Duplicates found (Only count once)
                bool DuplicateTwoExists = false;
                bool DuplicateThreeExists = false;

                // Loop through the line and count characters
                foreach(var t in IDCharacters.Keys.ToList())
                {
                    // If character has 2 of the same characters
                    if(IDCharacters[t] == 2 && DuplicateTwoExists == false)
                    {
                        CountTwo++;
                        DuplicateTwoExists = true;
                    }
                    else if(IDCharacters[t] == 3 && DuplicateThreeExists == false)
                    {
                        CountThree++;
                        DuplicateThreeExists = true;
                    }

                    // Reset dictionary values to zero
                    IDCharacters[t] = 0;
                }
            }
            return CountTwo * CountThree;
        }

        // What letters are common between the two correct box IDs?
        public static string Part2(IEnumerable<string> FileInput)
        {
            List<string> file = FileInput.ToList();

            string answer = "";
            
            // Loop through every line in the file
            for(int i = 0; i < file.Count; i++)
            {
                // Loop through every line in the file starting at the second value
                for(int j = i + 1; j < file.Count - 1; j++)
                {
                    int count = 0;
                    // Loop though every character in the current line
                    for(int letter = 0; letter < file[i].Length; letter++)
                    {
                        // Evaluate if charters of the first word and second word are the same
                        if(file[i][letter] == file[j][letter])
                        {
                            count++;
                        }

                        // If all but on letter is the same
                        if(count > 24)
                        {
                            // Loop through the 2 words that are similar
                            for(int letter1 = 0; letter1 < file[i].Length; letter1++)
                            {
                                // If the letters are the same build the new string
                                if(file[i][letter1] == file[j][letter1])
                                {
                                    answer += file[i][letter1];
                                }
                            }
                        }
                    }
                }
            }
            return answer;
        }
    }
}