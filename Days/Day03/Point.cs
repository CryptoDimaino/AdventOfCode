using System;

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
            Console.WriteLine($"|{this.X} - {Point2.X}| + |{this.Y} - {Point2.Y}| = {Answer}");
            return Answer;
        }
        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}