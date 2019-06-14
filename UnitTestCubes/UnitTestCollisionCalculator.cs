using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media.Media3D;
using Cubes;

namespace UnitTestCubes
{
    [TestClass]
    public class UnitTestCollisionCalculator
    {
        [TestMethod]
        public void TestCubesDoNotCollide()
        {
            var location1 = new Point3D(0, 0, 0);
            var location2 = new Point3D(8, 8, 8);
            var cube1 = new Cube(location1, 4);
            var cube2 = new Cube(location2, 8);

            var actual = CollisionCalculator.CalculateCubesIntersection(cube1, cube2);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void TestCubesCollidePartially()
        {
            var location1 = new Point3D(0, 0, 0);
            var location2 = new Point3D(2, 2, 2);
            var cube1 = new Cube(location1, 4);
            var cube2 = new Cube(location2, 8);
            double expected = 8;

            var actual = CollisionCalculator.CalculateCubesIntersection(cube1, cube2);

            Assert.AreEqual(expected, actual.CalculateVolume());
        }

        [TestMethod]
        public void TestCubesFullyIntersecting()
        {
            var location = new Point3D(0, 0, 0);
            var cube1 = new Cube(location, 4);
            var cube2 = new Cube(location, 8);
            var collider = new CollisionCalculator();
            double expected = 64;

            var actual = CollisionCalculator.CalculateCubesIntersection(cube1, cube2);

            Assert.AreEqual(expected, actual.CalculateVolume());
        }

        [TestMethod]
        public void TestCubesTouchButDoNotIntersect()
        {
            var location1 = new Point3D(0, 0, 0);
            var location2 = new Point3D(1, 1, 1);
            var cube1 = new Cube(location1, 1);
            var cube2 = new Cube(location2, 1);
            var collider = new CollisionCalculator();
            double expected = 0;

            var actual = CollisionCalculator.CalculateCubesIntersection(cube1, cube2);

            Assert.AreEqual(expected, actual.CalculateVolume());
        }
    }
}
