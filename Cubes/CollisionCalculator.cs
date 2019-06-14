using System;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class CollisionCalculator
    {
        public double CalculateCubesIntersection(Cube cube1, Cube cube2)
        {
            if (cube1 == null || cube2 == null)
                throw new ArgumentException("One of the cubes is null or empty.");

            var rect1 = cube1.GetShape<Rect3D>();
            var rect2 = cube2.GetShape<Rect3D>();
            var intersection = Rect3D.Intersect(rect1, rect2);

            if (intersection.IsEmpty)
            {
                return 0;
            }
            else
            {
                var intersectionShape = new Prism(intersection.Location, intersection.Size);
                return intersectionShape.CalculateVolume();
            }
        }
    }
}
