using System;
using System.Text.RegularExpressions;
using System.Windows.Media.Media3D;

namespace Cubes
{
    public class InputParser
    {
        public static Cube ParseCube(string text)
        {
            var regex = new Regex(@"^((\d+)(\.\d+)? ){3}(\d+)(\.\d+)?$");

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
