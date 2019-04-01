using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public static class Day6
    {
        // What is the size of the largest area that isn't infinite?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // CreateListOfSpecificPoints
            List<Point> Cordinates = new List<Point>();

            

            foreach(var Line in FileInput)
            {
                string[] Input = Line.Split(',');
                Cordinates.Add(new Point(int.Parse(Input[0]), int.Parse(Input[1])));
            }

            

            int MaxX = Cordinates.Max(point => point.X);
            int MaxY = Cordinates.Max(point => point.Y);

            int MinX = Cordinates.Min(point => point.X);
            int MinY = Cordinates.Min(point => point.Y);
            
            var GraphPoints = new int[MaxX,MaxY];

            for(int x = 0; x < MaxX; x++)
            {
                for(int y = 0; y < MaxY; y++)
                {
                    Console.Write(GraphPoints[x,y]);
                }
                Console.WriteLine();
            }


            Console.WriteLine($"Max X: {MaxX} Max Y: {MaxY} Min X: {MinX} Min Y: {MinY}");
            // for(int i = 0; i < Cordinates.Count; i++)
            // {
            //     for(int j = 0; j < Cordinates.Count; j++)
            //     {
            //         Cordinates[i].Taxicab(Cordinates[j]);
            //     }
            //     Console.WriteLine();
            // }
            
            return -1;
        }

        public static int Part2(IEnumerable<string> FileInput)
        {
            return -1;
        }
    }
}