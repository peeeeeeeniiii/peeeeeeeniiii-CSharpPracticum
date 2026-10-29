using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public interface IShape { double Area(); double Perimeter(); }
    public class Circle : IShape
    {
        private readonly double _radius; public Circle(double radius) { _radius = radius; }
        public double Area() { return Math.PI * _radius * _radius; }
        public double Perimeter() { return 2 * Math.PI * _radius; }
        public override string ToString() { return "Круг"; }
    }
    public class Rectangle : IShape
    {
        private readonly double _w, _h; public Rectangle(double w, double h) { _w = w; _h = h; }
        public double Area() { return _w * _h; } public double Perimeter() { return 2 * (_w + _h); }
        public override string ToString() { return "Прямоугольник"; }
    }
    public class Triangle : IShape
    {
        private readonly double _a, _b, _c; public Triangle(double a, double b, double c) { _a = a; _b = b; _c = c; }
        public double Area() { double p = (_a + _b + _c) / 2; return Math.Sqrt(Math.Max(0, p * (p - _a) * (p - _b) * (p - _c))); }
        public double Perimeter() { return _a + _b + _c; }
        public override string ToString() { return "Треугольник"; }
    }
    public class Task25_Shapes : TaskBase
    {
        public override string Title { get { return "25. Интерфейс IShape"; } }
        public override void Run()
        {
            List<IShape> shapes = new List<IShape> { new Circle(2), new Rectangle(3, 4), new Triangle(3, 4, 5), new Circle(1), new Rectangle(2, 5) };
            Console.WriteLine("До сортировки:");
            foreach (IShape shape in shapes) Console.WriteLine(shape + ": площадь " + shape.Area().ToString("F2") + ", периметр " + shape.Perimeter().ToString("F2"));
            shapes.Sort(delegate(IShape x, IShape y) { return x.Area().CompareTo(y.Area()); });
            Console.WriteLine("После сортировки по площади:");
            foreach (IShape shape in shapes) Console.WriteLine(shape + ": " + shape.Area().ToString("F2"));
        }
    }
}
