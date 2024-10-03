using FindPath.App;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace FindPath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestFindShortestPath()
        {
            int[,] arr = new int[,]
            {
            { 0, 0, 4, 0 },
            { 5, 0, 5, 0 },
            { 0, 4, 0, 0 },
            { 0, 0, 0, 0 }
            };

            var path = FindPath.App.Program.FindShortestPath(arr);
            Assert.IsNotNull(path);
            Assert.AreEqual(path[0], new Point(0, 0));
            Assert.AreEqual(path[path.Length - 1], new Point(3, 3));
        }

        [Test]
        public void TestFindShortestPath_NoPath()
        {
            int[,] arr = new int[,]
            {
            { 0, 0, 4 },
            { 5, 5, 4 },
            { 4, 4, 4 }
            };

            var path = FindPath.App.Program.FindShortestPath(arr);
            Assert.IsNull(path);
        }

        [Test]
        public void TestFindShortestPath_TooManyTypes()
        {
            int[,] arr = new int[,]
            {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 }
            };

            var path = FindPath.App.Program.FindShortestPath(arr);
            Assert.IsNull(path);
        }
    }
}