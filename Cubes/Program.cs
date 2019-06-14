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

            var collisionCalculator = new CollisionCalculator();
            double result = collisionCalculator.CalculateCubesIntersection(cube1, cube2);

            if (result == 0)
            {
                Console.WriteLine("The cubes do not collide.");
            }
            else
            {
                Console.WriteLine("The cubes collide, and the intersection volume is: " + result);
            }

            Console.ReadKey();
        }

        protected static Cube ReadCube()
        {
            Cube cube = null;

            Console.WriteLine("Enter the cube's position and size (x y z side). One decimal maximum: ");
            string input = Console.ReadLine();

            if (ValidateInput(input))
            {
                cube = Cube.Parse(input);
                Console.WriteLine("Cube successfully created.");
            }
            else
            {
                throw new ArgumentException("The string is not correctly formatted.");
            }

            return cube;
        }

        protected static bool ValidateInput(string text)
        {
            var regex = new Regex(@"((\d.)?(\d )){3}(\d.)?(\d)");
            return regex.IsMatch(text);
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
