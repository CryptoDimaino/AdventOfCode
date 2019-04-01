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
            // Ask for userinput to select problem 1-25
            // Select Test Input or Input
            
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
            // Console.WriteLine(Day4.Part1(ReadFile("Input/Problem4.txt")));
            // Console.WriteLine(Day4.Part2(ReadFile("Input/Problem4.txt")));

            // Day 5
            // Console.WriteLine(Day5.Part1(ReadFile("Input/Problem5.txt")));
            // Console.WriteLine(Day5.Part2(ReadFile("Input/Problem5.txt")));
            // Console.WriteLine(Day5.Part1(ReadFile("TestInput/Problem5.txt")));
            // Console.WriteLine(Day5.Part2(ReadFile("TestInput/Problem5.txt")));

            // Day 6
            Console.WriteLine(Day6.Part1(ReadFile("TestInput/Problem6.txt")));
            // Console.WriteLine(Day6.Part2(ReadFile("Input/Problem6.txt")));

            // Day 7
            // Console.WriteLine(Day7.Part1(ReadFile("Input/Problem7.txt")));
            // Console.WriteLine(Day7.Part2(ReadFile("Input/Problem7.txt")));

            // Day 8
            // Console.WriteLine(Day8.Part1(ReadFile("Input/Problem8.txt")));
            // Console.WriteLine(Day8.Part2(ReadFile("Input/Problem8.txt")));

            // Day 9
            // Console.WriteLine(Day9.Part1(ReadFile("Input/Problem9.txt")));
            // Console.WriteLine(Day9.Part2(ReadFile("Input/Problem9.txt")));

            // Day 10
            // Console.WriteLine(Day10.Part1(ReadFile("Input/Problem10.txt")));
            // Console.WriteLine(Day10.Part2(ReadFile("Input/Problem10.txt")));
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
