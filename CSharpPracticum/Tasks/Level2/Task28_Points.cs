using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class Point : IEquatable<Point>
    {
        public int X { get; private set; } public int Y { get; private set; }
        public Point(int x, int y) { X = x; Y = y; }
        public bool Equals(Point other) { return other != null && X == other.X && Y == other.Y; }
        public override bool Equals(object obj) { return Equals(obj as Point); }
        public override int GetHashCode() { unchecked { return (X * 397) ^ Y; } }
        public override string ToString() { return "(" + X + ", " + Y + ")"; }
    }
    public class Task28_Points : TaskBase
    {
        public override string Title { get { return "28. Equals, GetHashCode, HashSet"; } }
        public override void Run()
        {
            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(1, 2)); points.Add(new Point(3, 4)); points.Add(new Point(1, 2));
            Console.WriteLine("Уникальных точек: " + points.Count);
            foreach (Point p in points) Console.WriteLine(p);
        }
    }
}
