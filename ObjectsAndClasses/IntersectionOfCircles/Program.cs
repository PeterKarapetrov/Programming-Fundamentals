using System;
using System.Linq;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputLine = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point() { X = inputLine[0], Y = inputLine[1]};
            Circle firstCircle = new Circle() { Center = point, Radius = inputLine[2] };
            inputLine = Console.ReadLine().Split().Select(double.Parse).ToArray();
            point = new Point() { X = inputLine[0], Y = inputLine[1] };
            Circle secondCircle = new Circle() { Center = point, Radius = inputLine[2] };

            if (firstCircle.Intersect(secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }


    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Circle
    {
        public Point Center{ get; set; }
        public double Radius { get; set; }

        public bool Intersect(Circle circle)
        {
            bool isIntersect = false;

            if (Math.Sqrt((Center.X - circle.Center.X) * (Center.X - circle.Center.X) + (Center.Y - circle.Center.Y) * (Center.Y - circle.Center.Y)) <= Radius + circle.Radius)
            {
                isIntersect = true;
            }

            return isIntersect;
        }
    }
}
