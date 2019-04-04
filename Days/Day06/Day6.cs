    
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day6
    {
        // What is the size of the largest TotalArea that isn't infinite?
        public static int Part1(IEnumerable<string> FileInput)
        {
            // Create a List of Point's
            List<Point> Points = new List<Point>();

            // Loop through the file and add a point every line
            foreach(string Input in FileInput)
            {
                Points.Add(new Point(int.Parse(Input.Substring(0, Input.IndexOf(','))), int.Parse(Input.Substring(Input.IndexOf(',') + 1))));
            }

            // X and Y Max for Array of Point's
            int MaxX = Points.Max(point => point.X);
            int MaxY = Points.Max(point => point.Y);

            // X and Y Min for Array of Point's
            int MinX = Points.Min(point => point.X);
            int MinY = Points.Min(point => point.Y);

            // The total area of the grid
            int[,] TotalArea = new int[MaxX, MaxY];
            
            // Loop through all values in a range of the total area
            for(int X = MinX; X < MaxX; X++)
            {
                for(int Y = MinY; Y < MaxY; Y++)
                {
                    // Create a max value to grab the lowest distance
                    int NearestPoint = int.MaxValue;

                    // Used to tell if the points are the same in which case they are not counted
                    int Index = -1;

                    // Loop throuugh each plotted point's 
                    for(int Point = 0; Point < Points.Count; Point++)
                    {
                        // Create new point and use the Taxicab formula to find the distance
                        Point TempPoint = new Point(X, Y);
                        int Distance = Points[Point].Taxicab(TempPoint);

                        // Test to see if the new calcualted distance is smaller than the nearest point
                        // else if - Don't allow the same distance to make a new nearest point.
                        if(Distance < NearestPoint)
                        {
                            Index = Point;
                            NearestPoint = Distance;
                        }
                        else if(Distance == NearestPoint)
                        {
                            Index = -1;
                        }
                    }
                    // Give an index value to every X and Y point to identify which point is closest
                    TotalArea[X, Y] = Index;
                }
            }

            // Count they area of all the points
            int[] PointsCount = new int[Points.Count];
            for(int X = MinX; X < MaxX; X++)
            {
                for(int Y = MinY; Y < MaxY; Y++)
                {
                    // Make sure the area doesn't have an area of -1 because they are not counted
                    if(TotalArea[X, Y] != -1)
                    {
                        PointsCount[TotalArea[X, Y]]++;
                    }
                }
            }
            
            // The last 2 loops are used to make sure the view is a partial view
            // Loop through all X cordinates
            // Change all the Y = 0; and Y = MaxY - 1; To -1
            for(int X = MinX; X < MaxX; X++)
            {
                if(TotalArea[X, 0] != -1)
                {
                    PointsCount[TotalArea[X, 0]] = -1;
                }
                if(TotalArea[X, MaxY - 1] != -1)
                {
                    PointsCount[TotalArea[X, MaxY - 1]] = -1;
                }
            }

            // Remove all the X = 0; and Y = MaxX - 1; To -1
            for(int Y = MinY; Y < MaxY; Y++)
            {
                if(TotalArea[0, Y] != -1)
                {
                    PointsCount[TotalArea[0, Y]] = -1;
                }
                if(TotalArea[MaxX - 1, Y] != -1)
                {
                    PointsCount[TotalArea[MaxX - 1, Y]] = -1;
                }
            }
            return PointsCount.Max(val => val);
        }

        // What is the size of the region containing all locations which have a total distance to all given coordinates of less than 10000?
        public static int Part2(IEnumerable<string> FileInput)
        {
            // Create a List of Point's
            List<Point> Points = new List<Point>();

            // Loop through the file and add a point every line
            foreach(string Input in FileInput)
            {
                Points.Add(new Point(int.Parse(Input.Substring(0, Input.IndexOf(','))), int.Parse(Input.Substring(Input.IndexOf(',') + 1))));
            }

            // X and Y Max for Array of Point's
            int MaxX = Points.Max(point => point.X);
            int MaxY = Points.Max(point => point.Y);

            // X and Y Min for Array of Point's
            int MinX = Points.Min(point => point.X);
            int MinY = Points.Min(point => point.Y);

            int RegionSize = 0;

            // Loop through all values in a range of the the Points Min and Max for X and Y
            for(int X = MinX; X <= MaxX; X++)
            {
                for(int Y = MinY; Y <= MaxY; Y++)
                {
                    int DistanceSum = 0;
                    foreach(var Point in Points)
                    {
                        // Create new point and use the Taxicab formula to find the distance
                        // Add to a DistanceSum to check what the the total distance is to each point.
                        Point TempPoint = new Point(X, Y);
                        DistanceSum += Point.Taxicab(TempPoint);
                    }
                    // Check if the total distance to the points is less than 10000
                    if(DistanceSum < 10000)
                    {
                        RegionSize++;
                    }
                }
            }
            return RegionSize;
        }
    }
}