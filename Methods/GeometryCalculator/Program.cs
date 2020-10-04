using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometryFigure = Console.ReadLine();

            switch (geometryFigure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleSideHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetTriangleArea(triangleSide, triangleSideHeight):f2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetSquareArea(squareSide):f2}");
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetRectangleArea(rectangleWidth, rectangleHeight):f2}");
                    break;
                case "circle":
                    double circleradius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetCircleArea(circleradius):f2}");
                    break;
            }
        }

        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2;
        }

        static double GetSquareArea(double side)
        {
            return side * side;
        }

        private static double GetRectangleArea(double height, double width)
        {
            return width * height;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
