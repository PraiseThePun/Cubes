using System;
using System.Text.RegularExpressions;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class Cube : Shape
    {
        private Rect3D _rect;

        public Cube(Point3D location, double side)
        {
            var _side = side > 0 ? side : throw new ArgumentException("The cube's size must be a positive number.");
            _rect = new Rect3D(location.X, location.Y, location.Z, side, side, side);
        }

        public override Point3D Position => _rect.Location;
        public override Size3D Size => _rect.Size;

        public override double CalculateVolume()
        {
            return Math.Pow(Size.X, 3);
        }

        public override T GetShape<T>()
        {
            return (T)Convert.ChangeType(_rect, typeof(T));
        }

        public static Cube Parse(string text)
        {
            var regex = new Regex(@"((\d.)?(\d )){3}(\d.)?(\d)");

            if (regex.IsMatch(text))
            {
                var slicedText = text.Split(' ');
                var x = Convert.ToDouble(slicedText[0]);
                var y = Convert.ToDouble(slicedText[1]);
                var z = Convert.ToDouble(slicedText[2]);
                var side = Convert.ToDouble(slicedText[3]);
                var location = new Point3D(x, y, z);

                return new Cube(location, side);
            }
            else
            {
                throw new ArgumentException("The string is not properly formatted.");
            }
        }
    }
}
