using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            // Console.WriteLine(Day1.Part1(ReadFile("Input/Problem1.txt")));
            // Console.WriteLine(Day1.Part2(ReadFile("Input/Problem1.txt")));

            // Day 2
            // Console.WriteLine(Day2.Part1(ReadFile("Input/Problem2.txt")));
            // Console.WriteLine(Day2.Part2(ReadFile("Input/Problem2.txt")));

            // Day 3
            // Console.WriteLine(Day3.Part1(ReadFile("Input/Problem3.txt")));
            // Console.WriteLine(Day3.Part2(ReadFile("Input/Problem3.txt")));

            // Day 4
            Console.WriteLine(Day4.Part1(ReadFile("Input/Problem4.txt")));
            //Console.WriteLine(Day4.Part2(ReadFile("Input/Problem4.txt")));
        }

        // Function reads each line in from file and outputs an IEnumerable of strings.
        private static IEnumerable<string> ReadFile(string InputFile)
        {
            using(StreamReader Reader = new StreamReader(InputFile))
            {
                string Line;
                while((Line = Reader.ReadLine()) != null)
                {
                    yield return Line;
                }
            }
        }
    }
}
