using System;
using System.Drawing;

namespace Lesson_6._2
{
    public class Rectangle : Point
    {
        private double _width; 
        private double _length;
        public Rectangle(double x, double y, double width, double height, Color color, Visability visability) : base(x, y, color, visability)
        {
            _width = width;
            _length = height;
        }

        public double GetArea()
        {
            return Math.Round(_width * _length, 2);
        }

        public override string ToString() => base.ToString() + $"\nШирина: {_width}\nДлина: {_length}";
    }
}
