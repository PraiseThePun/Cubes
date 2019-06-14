using System;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class CollisionCalculator
    {
        public static Prism CalculateCubesIntersection(Cube cube1, Cube cube2)
        {
            if (cube1 == null || cube2 == null)
                throw new ArgumentException("One of the cubes is null.");

            var rect1 = cube1.BoundingBox();
            var rect2 = cube2.BoundingBox();
            var intersection = Rect3D.Intersect(rect1, rect2);

            if (intersection.IsEmpty)
            {
                return null;
            }
            else
            {
                try
                {
                    return new Prism(intersection.Location, intersection.Size);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
