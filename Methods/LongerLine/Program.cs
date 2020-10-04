using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPointX1 = double.Parse(Console.ReadLine());
            double firstPointY1 = double.Parse(Console.ReadLine());
            double secondPointX2 = double.Parse(Console.ReadLine());
            double secondPointY2 = double.Parse(Console.ReadLine());
            double thirdPointX3 = double.Parse(Console.ReadLine());
            double thirdPointY3 = double.Parse(Console.ReadLine());
            double fourthPointX4 = double.Parse(Console.ReadLine());
            double fourthPointY4 = double.Parse(Console.ReadLine());
            double firstLineDistance = FindDistanceBetweenTwoPoint(firstPointX1, firstPointY1, secondPointX2, secondPointY2);
            double secondLineDistance = FindDistanceBetweenTwoPoint(thirdPointX3, thirdPointY3, fourthPointX4, fourthPointY4);
            bool firstLineIsLonger = FirstLineIsLonger(firstLineDistance, secondLineDistance);

            if (firstLineIsLonger)
            {
                double point1DistanceToCenter = PointDistanceToCenter(firstPointX1, firstPointY1);
                double point2DistanceToCenter = PointDistanceToCenter(secondPointX2, secondPointY2);
                if (point1DistanceToCenter <= point2DistanceToCenter)
                {
                    Console.WriteLine($"({firstPointX1}, {firstPointY1})({secondPointX2}, {secondPointY2})"); ;
                }
                else
                {
                    Console.WriteLine($"({secondPointX2}, {secondPointY2})({firstPointX1}, {firstPointY1})"); ;
                }
            }
            else
            {
                double point3DistanceToCenter = PointDistanceToCenter(thirdPointX3, thirdPointY3);
                double point4DistanceToCenter = PointDistanceToCenter(fourthPointX4, fourthPointY4);
                if (point3DistanceToCenter <= point4DistanceToCenter)
                {
                    Console.WriteLine($"({thirdPointX3}, {thirdPointY3})({fourthPointX4}, {fourthPointY4})"); ;
                }
                else
                {
                    Console.WriteLine($"({fourthPointX4}, {fourthPointY4})({thirdPointX3}, {thirdPointY3})"); ;
                }
            }
        }

        static double FindDistanceBetweenTwoPoint(double x1, double y1, double x2, double y2)
        {
            return (x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2);
        }

        static bool FirstLineIsLonger(double firstDistance, double secondDistance)
        {
            if (firstDistance >= secondDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double PointDistanceToCenter(double x, double y)
        {
            double distance = 0.0;
            if (x == 0)
            {
                distance = Math.Abs(y);
            }
            else if (y == 0)
            {
                distance = Math.Abs(x);
            }
            else
            {
                distance = Math.Sqrt(x * x + y * y);
            }
            return distance;
        }
    }
}