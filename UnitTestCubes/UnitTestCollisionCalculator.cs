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
        }

        [TestMethod]
        public void TestCubesCollidePartially()
        {
        }

        [TestMethod]
        public void TestCubesFullyIntersecting()
        {
            var location = new Point3D(0, 0, 0);
            var cube1 = new Cube(location, 4);
            var cube2 = new Cube(location, 8);
            var collider = new CollisionCalculator();
            double expected = 64;

            double actual = collider.CalculateCubesIntersection(cube1, cube2);

            Assert.AreEqual(expected, actual);
        }
    }
}
