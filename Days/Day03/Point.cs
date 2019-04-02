using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    public class Point
    {
        public int X {get;set;}
        public int Y {get;set;}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Taxicab(Point Point2)
        {
            int Answer = Math.Abs(this.X - Point2.X) + Math.Abs(this.Y - Point2.Y);
            return Answer;
        }
        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}