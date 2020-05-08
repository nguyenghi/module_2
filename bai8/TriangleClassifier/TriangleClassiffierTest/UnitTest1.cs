using NUnit.Framework;
using TriangleClassifier;
namespace TriangleClassiffierTest
{
    public class TriagleTests
    {
        private Triangle triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new Triangle();
        }

        [Test]
        public void TestTriangle()
        {
            var result = triangle.IsTriagle(1, 2, 1);
            var flag = false;
            Assert.AreEqual(flag, result);
        }

    }
}