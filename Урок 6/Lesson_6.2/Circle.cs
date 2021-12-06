using System.Drawing;
using System;

namespace Lesson_6._2
{
    public class Circle : Point
    {
        private double _radius;
        public Circle(double x, double y, double radius, Color color, Visability visability) : base(x, y, color, visability)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.Pow(_radius, 2) * Math.PI, 2);
        }

        public override string ToString() => base.ToString() + $"\nРадиус: {_radius}";
    }
}
