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
            Problem1();
        }
        // Functon reads each line in from file and outputs a list of strings.
        private static List<string> ReadFile(string file)
        {
            List<string> FileContents = new List<string>();
            string line;
            try
            {
                using(StreamReader Reader = new StreamReader(file))
                {
                    while((line = Reader.ReadLine()) != null)
                    {
                        FileContents.Add(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e);
            }
            return FileContents;
        }


        private static void Problem1()
        {
            List<string> file = ReadFile("Problem1.txt");
            int frequency = 0;
            foreach(var line in file)
            {
                if(line.Substring(0, 1) == "+")
                {
                    frequency += Int32.Parse(line.Substring(1, line.Length - 1));
                }
                else
                {
                    frequency -= Int32.Parse(line.Substring(1, line.Length - 1));
                }
            }
            Console.WriteLine("Problem 1");
            Console.WriteLine("Part 1: " + frequency);

            List<int> FrequencyList = new List<int>();
            frequency = 0;
            while(true)
            {
                foreach(var line in file)
                {
                    if(line.Substring(0, 1) == "+")
                    {
                        frequency += Int32.Parse(line.Substring(1, line.Length - 1));
                    }
                    else
                    {
                        frequency -= Int32.Parse(line.Substring(1, line.Length - 1));
                    }
                    if(FrequencyList.Contains(frequency))
                    {
                        Console.WriteLine("Part 2: " + frequency);
                        System.Environment.Exit(1);
                    }
                    FrequencyList.Add(frequency);
                }
            }
        }

        private static void Problem2()
        {
            // Use ReadFile Function to make a list to iterate through.
            List<string> file = ReadFile("Problem2.txt");

            // Create counter variables
            int CountTwo = 0;
            int CountThree = 0;

            // Create a dictionary with each letter in it.
            Dictionary<char, int> IDCharacters = new Dictionary<char, int>();
            for(char c = 'a'; c <= 'z'; c++)
            {
                IDCharacters.Add(c, 0);
            }
            
            // Loop through all lines in a file
            foreach(var line in file)
            {
                // Increment by 1 to each character in the ID
                foreach(char c in line)
                {
                    IDCharacters[c]++;
                }

                // Reset Count
                int CounterTwo = 0;
                int CounterThree = 0;
                foreach(var t in IDCharacters.Keys.ToList())
                {
                    
                    if(IDCharacters[t] == 2)
                    {
                        if(CounterTwo == 0)
                        {
                            CountTwo++;
                            CounterTwo++;
                        }
                        Console.WriteLine($"Key: {t} Value: {IDCharacters[t]} - Count Two: {CounterTwo}");
                    }
                    else if(IDCharacters[t] == 3)
                    {
                        if(CounterThree == 0)
                        {
                            CountThree++;
                            CounterThree++;
                        }
                        Console.WriteLine($"Key: {t} Value: {IDCharacters[t]} - Count Three: {CounterThree}");
                    }
                    IDCharacters[t] = 0;
                }
            }
            int CheckSum = CountTwo * CountThree;
            Console.WriteLine(CheckSum);
        }

        // Compares each line to itself looking for 1 offset.
        private static void Problem22()
        {
            // Use ReadFile Function to make a list to iterate through.
            List<string> file = ReadFile("Problem2.txt");

            int linecount = 1;

            string answer = "";
            for(int i = 0; i < file.Count; i++)
            {
                for(int j = i + 1; j < file.Count - 1; j++)
                {
                    int count = 0;
                    for(int letter = 0; letter < file[i].Length; letter++)
                    {
                        
                        if(file[i][letter] == file[j][letter])
                        {
                            count++;
                        }
                        if(count > 24)
                        {
                            for(int letter1 = 0; letter1 < file[i].Length; letter1++)
                            {
                                if(file[i][letter1] == file[j][letter1])
                                {
                                    answer += file[i][letter1];
                                }
                            }
                            Console.WriteLine($"Line Count: {linecount} Word 1: {file[i]} Word 2: {file[j]}");
                        }
                    }
                }
                linecount++;
            }
            Console.WriteLine(answer);
        }


        // #1 @ 493,113: 12x14
        // #2 @ 791,235: 17x27

        // #1 @ 493,113: 12x14

        // Finds the area covered by at least 2 claims
        private static void Problem3()
        {
            List<string> file = ReadFile("Problem3.txt");

            int[,] arr = new int[1000, 1000];
            foreach(var line in file)
            {
                // Create an array of the line read in using delimeters
                string[] split = line.Split(new Char[] {' ', ',', 'x'});

                int Left = Int32.Parse(split[2].ToString());
                int Width = Int32.Parse(split[4].ToString());
                int Top = Int32.Parse(split[3].Substring(0, split[3].Length - 1));
                int Height = Int32.Parse(split[5].ToString());

                int count = 1;
                for(int height = 0; height < arr.GetLength(0); height++)
                {
                    for(int width = 0; width < arr.GetLength(1); width++)
                    {
                        if(width > Left - 1 && height > Top - 1 && width < Left + Width && height < Top + Height)
                        {
                            //Console.Write("X");
                            arr[height, width]++;
                        }
                        else
                        {
                            //Console.Write(".");
                        }
                    }
                    //Console.WriteLine();
                    count++;
                }
                //Console.WriteLine();
            }
            for(int height = 0; height < arr.GetLength(0); height++)
            {
                for(int width = 0; width < arr.GetLength(1); width++)
                {
                    if(arr[height, width] > 1)
                    {
                        Console.WriteLine($"arr[{height},{width}]");
                        //Console.Write("X");
                    }
                    else
                    {
                        //Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
        private class Box
        {
            public int Id { get; private set; }

            public int LeftOffset { get; private set; }
            public int TopOffset { get; private set; }
            public int Height { get; private set; }
            public int Width { get; private set; }

            public IEnumerable<(int, int)> ToPoints()
            {
                for (var x = LeftOffset; x < LeftOffset + Width; x++)
                for (var y = TopOffset; y < TopOffset + Height; y++)
                    yield return (x, y);
            }

            private static readonly Regex Parse = new Regex(@"#(\d+) @ (\d+),(\d+): (\d+)x(\d+)");

            public static Box ParseBox(string line)
            {
                int[] m = Parse.Match(line).Groups.Skip(1).Select(gr => int.Parse(gr.Value)).ToArray();
                return new Box
                {
                    Id = m[0],
                    LeftOffset = m[1],
                    TopOffset = m[2],
                    Width = m[3],
                    Height = m[4]
                };
            }
        }
    }
}
