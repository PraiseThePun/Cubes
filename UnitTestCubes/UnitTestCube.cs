using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;
using Cubes;

namespace UnitTestCubes
{
    [TestClass]
    public class UnitTestCube
    {
        [TestMethod]
        public void TestCreateCubeSizeIsZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cube(new Point3D(0, 0, 0), 0));
        }

        [TestMethod]
        public void TestSize()
        {
            var size = 4;
            var cube = new Cube(new Point3D(0, 0, 0), size);

            Assert.AreEqual(size, cube.Size.X);
        }

        [TestMethod]
        public void TestCreateCubeSizeIsNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Cube(new Point3D(0, 0, 0), -1));
        }

        [TestMethod]
        public void TestLocation()
        {
            var location = new Point3D(0, 0, 0);
            var cube = new Cube(location, 4);

            Assert.AreEqual(location, cube.Position);
        }

        [TestMethod]
        public void TestCalculateVolume()
        {
            var cube = new Cube(new Point3D(0, 0, 0), 4);
            double expected = 64;

            Assert.AreEqual(expected, cube.CalculateVolume());
        }
    }
}
