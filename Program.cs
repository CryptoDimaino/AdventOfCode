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
            string UserSelection = "";
            bool ContinueLoop = true;
            do
            {
                // Ask for userinput to select problem 1-25
                // Select Test Input or Input
                Console.WriteLine("Please select a Day Number(1-25): ");
                UserSelection = Console.ReadLine();
                string PartSelection = "";
                string TestSelection = "";
                
                switch(UserSelection)
                {
                    case "1":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day1.Part1(ReadFile("Input/Problem1.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day1.Part1(ReadFile("TestInput/Problem1.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day1.Part2(ReadFile("Input/Problem1.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day1.Part2(ReadFile("TestInput/Problem1.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day2.Part1(ReadFile("Input/Problem2.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day2.Part1(ReadFile("TestInput/Problem2.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day2.Part2(ReadFile("Input/Problem2.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day2.Part2(ReadFile("TestInput/Problem2.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day3.Part1(ReadFile("Input/Problem3.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day3.Part1(ReadFile("TestInput/Problem3.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day3.Part2(ReadFile("Input/Problem3.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day3.Part2(ReadFile("TestInput/Problem3.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day4.Part1(ReadFile("Input/Problem4.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day4.Part1(ReadFile("TestInput/Problem4.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day4.Part2(ReadFile("Input/Problem4.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day4.Part2(ReadFile("TestInput/Problem4.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day5.Part1(ReadFile("Input/Problem5.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day5.Part1(ReadFile("TestInput/Problem5.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day5.Part2(ReadFile("Input/Problem5.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day5.Part2(ReadFile("TestInput/Problem5.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day6.Part1(ReadFile("Input/Problem6.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day6.Part1(ReadFile("TestInput/Problem6.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day6.Part2(ReadFile("Input/Problem6.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day6.Part2(ReadFile("TestInput/Problem6.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day7.Part1(ReadFile("Input/Problem7.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day7.Part1(ReadFile("TestInput/Problem7.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day7.Part2(ReadFile("Input/Problem7.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day7.Part2(ReadFile("TestInput/Problem7.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "8":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day8.Part1(ReadFile("Input/Problem8.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day8.Part1(ReadFile("TestInput/Problem8.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day8.Part2(ReadFile("Input/Problem8.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day8.Part2(ReadFile("TestInput/Problem8.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "9":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day9.Part1(ReadFile("Input/Problem9.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day9.Part1(ReadFile("TestInput/Problem9.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day9.Part2(ReadFile("Input/Problem9.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day9.Part2(ReadFile("TestInput/Problem9.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "10":
                        Console.WriteLine("Please Select Part Number 1 or 2: ");
                        PartSelection = Console.ReadLine();
                        switch(PartSelection)
                        {
                            case "1":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day10.Part1(ReadFile("Input/Problem10.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day10.Part1(ReadFile("TestInput/Problem10.txt")));
                                        break;
                                }
                                break;
                            case "2":
                                Console.WriteLine("Please Select Input or Test Input 1 or 2: ");
                                TestSelection = Console.ReadLine();
                                switch(TestSelection)
                                {
                                    case "1":
                                        Console.WriteLine(Day10.Part2(ReadFile("Input/Problem10.txt")));
                                        break;
                                    case "2":
                                        Console.WriteLine(Day10.Part2(ReadFile("TestInput/Problem10.txt")));
                                        break;
                                }
                                break;
                        }
                        break;
                    case "X": case "x":
                        ContinueLoop = false;
                        break;
                    default:
                        Console.WriteLine("Sorry please select a number between 1-25");
                        break;
                }
            }while(ContinueLoop == true);

            
            // Day 1
            

            // Day 2
            // Console.WriteLine(Day2.Part1(ReadFile("Input/Problem2.txt")));
            // Console.WriteLine(Day2.Part2(ReadFile("Input/Problem2.txt")));
            // Console.WriteLine(Day2.Part1(ReadFile("TestInput/Problem2.txt")));
            // Console.WriteLine(Day2.Part2(ReadFile("TestInput/Problem2.txt")));

            // Day 3
            // Console.WriteLine(Day3.Part1(ReadFile("Input/Problem3.txt")));
            // Console.WriteLine(Day3.Part2(ReadFile("Input/Problem3.txt")));
            // Console.WriteLine(Day3.Part1(ReadFile("TestInput/Problem3.txt")));
            // Console.WriteLine(Day3.Part2(ReadFile("TestInput/Problem3.txt")));

            // Day 4
            // Console.WriteLine(Day4.Part1(ReadFile("Input/Problem4.txt")));
            // Console.WriteLine(Day4.Part2(ReadFile("Input/Problem4.txt")));
            // Console.WriteLine(Day4.Part1(ReadFile("TestInput/Problem4.txt")));
            // Console.WriteLine(Day4.Part2(ReadFile("TestInput/Problem4.txt")));

            // Day 5
            // Console.WriteLine(Day5.Part1(ReadFile("Input/Problem5.txt")));
            // Console.WriteLine(Day5.Part2(ReadFile("Input/Problem5.txt")));
            // Console.WriteLine(Day5.Part1(ReadFile("TestInput/Problem5.txt")));
            // Console.WriteLine(Day5.Part2(ReadFile("TestInput/Problem5.txt")));

            // Day 6
            // Console.WriteLine(Day6.Part1(ReadFile("Input/Problem6.txt")));
            // Console.WriteLine(Day6.Part2(ReadFile("Input/Problem6.txt")));
            // Console.WriteLine(Day6.Part1(ReadFile("TestInput/Problem6.txt")));
            // Console.WriteLine(Day6.Part2(ReadFile("TestInput/Problem6.txt")));

            // Day 7
            // Console.WriteLine(Day7.Part1(ReadFile("Input/Problem7.txt")));
            // Console.WriteLine(Day7.Part2(ReadFile("Input/Problem7.txt")));
            // Console.WriteLine(Day7.Part1(ReadFile("TestInput/Problem7.txt")));
            // Console.WriteLine(Day7.Part2(ReadFile("TestInput/Problem7.txt")));

            // Day 8
            // Console.WriteLine(Day8.Part1(ReadFile("Input/Problem8.txt")));
            // Console.WriteLine(Day8.Part2(ReadFile("Input/Problem8.txt")));
            // Console.WriteLine(Day8.Part1(ReadFile("TestInput/Problem8.txt")));
            // Console.WriteLine(Day8.Part2(ReadFile("TestInput/Problem8.txt")));

            // Day 9
            // Console.WriteLine(Day9.Part1(ReadFile("Input/Problem9.txt")));
            // Console.WriteLine(Day9.Part2(ReadFile("Input/Problem9.txt")));
            // Console.WriteLine(Day9.Part1(ReadFile("TestInput/Problem9.txt")));
            // Console.WriteLine(Day9.Part2(ReadFile("TestInput/Problem9.txt")));

            // Day 10
            // Console.WriteLine(Day10.Part1(ReadFile("Input/Problem10.txt")));
            // Console.WriteLine(Day10.Part2(ReadFile("Input/Problem10.txt")));
            // Console.WriteLine(Day10.Part1(ReadFile("TestInput/Problem10.txt")));
            // Console.WriteLine(Day10.Part2(ReadFile("TestInput/Problem10.txt")));
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
