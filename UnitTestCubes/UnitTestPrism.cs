using Cubes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Media.Media3D;

namespace UnitTestCubes
{
    [TestClass]
    public class UnitTestPrism
    {
        [TestMethod]
        public void TestCreateCubeSizeIsZero()
        {
            var zeroSize = new Size3D(0, 0, 0);
            var prism = new Prism(new Point3D(0, 0, 0), zeroSize);

            Assert.AreEqual(zeroSize, prism.Size);
        }

        [TestMethod]
        public void TestSize()
        {
            var size = new Size3D(3, 5, 7);
            var cube = new Prism(new Point3D(0, 0, 0), size);

            Assert.AreEqual(size, cube.Size);
        }

        [TestMethod]
        public void TestCreateCubeSizeIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Prism(new Point3D(0, 0, 0), new Size3D(-2, -3, -5)));
        }

        [TestMethod]
        public void TestLocation()
        {
            var location = new Point3D(0, 0, 0);
            var cube = new Prism(location, new Size3D(3, 5, 7));

            Assert.AreEqual(location, cube.Position);
        }

        [TestMethod]
        public void TestCalculateVolume()
        {
            var cube = new Prism(new Point3D(0, 0, 0), new Size3D(2, 4, 6));
            double expected = 48;

            Assert.AreEqual(expected, cube.CalculateVolume());
        }
    }
}
