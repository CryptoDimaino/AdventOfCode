using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AdventOfCode
{
    public static class Day3
    {
        // How many square inches of fabric are within two or more claims?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create array of Rectangle Objects
            Rectangle[] rec = FileInput.Select(l => new Rectangle(l)).ToArray();

            // Create a multidimensional array of the furthest points
            var maxWidth = rec.Max(b => b.LeftOffset + b.Width) + 1;
            var maxHeight = rec.Max(b => b.TopOffset + b.Height) + 1;
            var Matrix = new int[maxWidth, maxHeight];

            // Loops through all Rectangles in Rectangle Array
            foreach(Rectangle rect in rec)
            {
                // Loops through all Points (Offsets to either Width, or Height) and adds 1
                foreach(var point in rect.Point())
                {
                    Matrix[point.X, point.Y]++;
                }
            }

            // Using LINQ to cast the whole array to int then using LINQ to count all values over 1
            return Matrix.Cast<int>().Count(point => point > 1);
        }

        // What is the ID of the only claim that doesn't overlap?
        public static int Part2(IEnumerable<string> FileInput)
        {
            // Create array of Rectangle Objects
            Rectangle[] rec = FileInput.Select(l => new Rectangle(l)).ToArray();
            
            // Create a multidimensional array of the furthest points
            var maxWidth = rec.Max(b => b.LeftOffset + b.Width) + 1;
            var maxHeight = rec.Max(b => b.TopOffset + b.Height) + 1;
            var Matrix = new int[maxWidth, maxHeight];

            // Loops through all Rectangles in Rectangle Array
            foreach(Rectangle rect in rec)
            {
                // Loops through all Points (Offsets to either Width, or Height) and adds 1
                foreach(var point in rect.Point())
                {
                    Matrix[point.X, point.Y]++;
                }
            }

            // Using LINQ Select first rectangle with the point that equals 1 and get the ID
            return rec.First(recx => recx.Point().All((point => Matrix[point.X, point.Y] == 1))).Id;
        }
    }
}