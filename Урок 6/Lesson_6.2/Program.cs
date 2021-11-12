using System.Drawing;
using System;

namespace Lesson_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var NewPoint = new Point(10, -20, Color.White, Visability.Visable);
            NewPoint.ChangeX(-5);
            NewPoint.ChangeY(5);
            NewPoint.ChangeColor(Color.Red);
            Console.WriteLine($"Точка\n{NewPoint}");

            var NewCircle = new Circle(15, 0, 4, Color.White, Visability.Visable);
            NewCircle.ChangeX(-5);
            NewCircle.ChangeY(5);
            NewCircle.ChangeColor(Color.Black);
            Console.WriteLine($"Окружность\n{NewCircle}");
            Console.WriteLine($"Площадь: {NewCircle.GetArea()}");

            var NewRectangle = new Rectangle(-10, -10, 20, 15, Color.White, Visability.Visable);
            NewRectangle.ChangeX(-10);
            NewRectangle.ChangeY(-10);
            NewRectangle.ChangeColor(Color.Green);
            Console.WriteLine($"Прямоугольник\n{NewRectangle}");
            Console.WriteLine($"Площадь: {NewRectangle.GetArea()}");
        }
    }
}
