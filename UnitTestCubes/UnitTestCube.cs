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
            Cube cube;
            var location = new Point3D(0, 0, 0);

            Assert.ThrowsException<ArgumentException>(() => cube = new Cube(location, 0));
        }

        [TestMethod]
        public void TestParseInvalidCubeString()
        {
            string pattern = "a 000";

            Assert.ThrowsException<ArgumentException>(() => Cube.Parse(pattern));
        }
    }
}
