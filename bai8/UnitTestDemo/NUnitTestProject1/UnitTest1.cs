using NUnit.Framework;
using UnitTestDemo;

namespace NUnitTestProject1
{
    public class Tests
    {
        private Calculator cal;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(10, cal.Addition(8, 2));
        }
        public void Subtraction()
        {
            Assert.AreEqual(7, cal.Subtraction(9, 2));

        }

    }
}