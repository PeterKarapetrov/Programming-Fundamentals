using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameterToCalculate = Console.ReadLine();
            switch (parameterToCalculate)
            {
                case "face":
                    Console.WriteLine($"{GetCubeFaceDiagonal(sideOfTheCube):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{GetCubeSpaceDiagonal(sideOfTheCube):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{GetCubeVolume(sideOfTheCube):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{GetCubeSurfaceArea(sideOfTheCube):f2}");
                    break;
            }

        }

        static double GetCubeFaceDiagonal(double side)
        {
            return Math.Sqrt(side * side + side * side);
        }

        static double GetCubeSpaceDiagonal(double side)
        {
            return Math.Sqrt(side * side + side * side + side * side);
        }

        static double GetCubeSurfaceArea(double side)
        {
            return 6 * side * side;
        }

        static double GetCubeVolume(double side)
        {
            return side * side * side;
        }
    }
}
