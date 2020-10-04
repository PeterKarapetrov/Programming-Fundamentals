using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double point1X = double.Parse(Console.ReadLine());
            double point1Y = double.Parse(Console.ReadLine());
            double point2X = double.Parse(Console.ReadLine());
            double point2Y = double.Parse(Console.ReadLine());
            if (PointDistanceToCenter(point1X, point1Y) <= PointDistanceToCenter(point2X, point2Y))
            {
                Console.WriteLine($"({point1X}, {point1Y})");
            }
            else
            {
                Console.WriteLine($"({point2X}, {point2Y})");
            }
        }

        static double PointDistanceToCenter(double x, double y)
        {
            double distance = 0.0;
            if (x == 0)
            {
                distance = y;
            }
            else if (y == 0)
            {
                distance = x;
            }
            else
            {
                distance = Math.Sqrt(x * x + y * y);
            }
            return distance;
        }
    }
}
