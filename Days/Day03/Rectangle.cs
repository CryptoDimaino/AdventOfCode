using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace AdventOfCode
{
    public class Rectangle
    {
        public int Id {get;set;}
        public int LeftOffset {get;set;}
        public int TopOffset {get;set;}
        public int Height {get;set;}
        public int Width {get;set;}

        public Rectangle(string Input)
        {
            int[] AllMatches = Parse.Match(Input).Groups.Skip(1).Select(match => int.Parse(match.Value)).ToArray();
            
            Id = AllMatches[0];
            LeftOffset = AllMatches[1];
            TopOffset = AllMatches[2];
            Height = AllMatches[4];
            Width = AllMatches[3];
        }

        public IEnumerable<Point> Point()
        {
            for(int x = LeftOffset; x < LeftOffset + Width; x++)
            {
                for(int y = TopOffset; y < TopOffset + Height; y++)
                {
                    yield return new Point(x, y);
                }
            }
        }

        private static readonly Regex Parse = new Regex(@"#(\d+) @ (\d+),(\d+): (\d+)x(\d+)");
    }
}