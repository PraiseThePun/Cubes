using System;
using System.Windows.Media.Media3D;

namespace Cubes
{
    class Prism : Shape
    {
        private Rect3D _rect;

        public Prism(Point3D location, Size3D size)
        {
            _rect = new Rect3D(location, size);
        }

        public override Point3D Position => _rect.Location;
        public override Size3D Size => _rect.Size;

        public override double CalculateVolume()
        {
            return _rect.SizeX * _rect.SizeY * _rect.SizeZ;
        }

        public override T GetShape<T>()
        {
            return (T)Convert.ChangeType(_rect, typeof(T));
        }
    }
}
