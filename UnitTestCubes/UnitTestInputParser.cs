using System;
using Cubes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCubes
{
    [TestClass]
    public class UnitTestInputParser
    {
        [TestMethod]
        public void TestParseInvalidCubeString()
        {
            string pattern = "a 000";

            Assert.ThrowsException<ArgumentException>(() => InputParser.ParseCube(pattern));
        }
    }
}
