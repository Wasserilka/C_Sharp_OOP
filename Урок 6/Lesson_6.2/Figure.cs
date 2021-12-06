using System.Drawing;

namespace Lesson_6._2
{
    public abstract class Figure
    {
        private Color _color;
        private Visability _visibility;

        public void ChangeColor(Color color)
        {
            _color = color;
        }

        public Visability GetVisability()
        {
            return _visibility;
        }

        public abstract void ChangeX(double x);
        public abstract void ChangeY(double y);
        public override string ToString() => $"Цвет: {_color}\nВидимость: {_visibility}";

        public Figure(Color color, Visability visability)
        {
            _color = color;
            _visibility = visability;
        }
    }

    public enum Visability
    {
        Visable,
        Hidden
    }
}
