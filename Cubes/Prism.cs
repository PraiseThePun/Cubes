using System;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class Prism : Shape
    {
        private Rect3D _rect;

        public Prism(Point3D location, Size3D size)
        {
            if (size.X < 0 || size.Y < 0 || size.Z < 0)
                throw new ArgumentException("The prism's size must be a positive number.");

            _rect = new Rect3D(location, size);
        }

        public override Point3D Position => _rect.Location;
        public override Size3D Size => _rect.Size;

        public override double CalculateVolume()
        {
            return _rect.SizeX * _rect.SizeY * _rect.SizeZ;
        }

        public override Rect3D BoundingBox()
        {
            return _rect;
        }
    }
}
