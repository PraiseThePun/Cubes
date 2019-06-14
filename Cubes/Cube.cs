using System;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class Cube : Shape
    {
        private Rect3D _rect;

        public Cube(Point3D location, double side)
        {
            if (side <= 0)
                throw new ArgumentException("The cube's size must be a positive number.");

            _rect = new Rect3D(location.X, location.Y, location.Z, side, side, side);
        }

        public override Point3D Position => _rect.Location;
        public override Size3D Size => _rect.Size;

        public override double CalculateVolume()
        {
            return Math.Pow(Size.X, 3);
        }

        public override Rect3D BoundingBox()
        {
            return _rect;
        }
    }
}
