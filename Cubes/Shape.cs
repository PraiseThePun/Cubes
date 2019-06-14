using System.Windows.Media.Media3D;

namespace Cubes
{
    public abstract class Shape
    {
        public abstract Point3D Position { get; }
        public abstract Size3D Size { get; }

        public abstract double CalculateVolume();
        public abstract T GetShape<T>();
    }
}