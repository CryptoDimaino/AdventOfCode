using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdventOfCode
{
    public static class Day1
    {
        // Starting with a frequency of zero, what is the resulting frequency after all of the changes in frequency have been applied?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create integer to keep track of the frequency
            int frequency = 0;

            // foreach - Loops through every value in file
            // FileInput.Select - Selects the number in each line and adds on the number being negative or positive
            foreach(var number in FileInput.Select(line => int.Parse(line, CultureInfo.InvariantCulture)))
            {
                frequency += number;
            }
            return frequency;
        }

        // What is the first frequency your device reaches twice?
        public static int Part2(IEnumerable<string> FileInput)
        {
            // Create integer to keep track of the frequency
            int frequency = 0;

            // Create a list to iterate through until the number is found twice
            List<int> Frequencies = FileInput.Select(freq => int.Parse(freq, CultureInfo.InvariantCulture)).ToList();

            // Create a list to keep track of frequencies
            List<int> AllFrequencies = new List<int>();

            // Infinite loop until a repeat freqency is found
            while(true)
            {
                foreach(int num in Frequencies)
                {
                    frequency += num;

                    // Check to see if current frequency is in the list
                    if(AllFrequencies.Contains(frequency))
                    {
                        return frequency;
                    }
                    AllFrequencies.Add(frequency);
                }
            }
        }
    }
}