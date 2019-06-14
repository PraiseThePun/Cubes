using System;
using System.Text.RegularExpressions;

namespace Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            var cube1 = TryReadCube();
            var cube2 = TryReadCube();

            var result = CollisionCalculator.CalculateCubesIntersection(cube1, cube2);

            if (result == null)
            {
                Console.WriteLine("The cubes do not collide.");
            }
            else
            {
                Console.WriteLine("The cubes collide, and the intersection volume is: " + result.CalculateVolume());
            }

            Console.ReadKey();
        }

        protected static Cube ReadCube()
        {
            Cube cube = null;

            Console.WriteLine("Enter the cube's position and size (x y z side). One decimal maximum: ");
            string input = Console.ReadLine();

            cube = InputParser.ParseCube(input);
            Console.WriteLine("Cube successfully created.");

            return cube;
        }

        protected static Cube TryReadCube()
        {
            Cube cube = null;

            do
            {
                try
                {
                    cube = ReadCube();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (cube == null);

            return cube;
        }
    }
}
