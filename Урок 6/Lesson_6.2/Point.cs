using System.Drawing;

namespace Lesson_6._2
{
    public class Point : Figure
    {
        private double _x;
        private double _y;
        public Point(double x, double y, Color color, Visability visability) : base(color, visability)
        {
            _x = x;
            _y = y;
        }
        public override void ChangeX(double x)
        {
            _x += x;
        }

        public override void ChangeY(double y)
        {
            _y += _y;
        }

        public override string ToString() => base.ToString() + $"\nКоордината X: {_x}\nКоордината Y: {_y}";
    }
}
