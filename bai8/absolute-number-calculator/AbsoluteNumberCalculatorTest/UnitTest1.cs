using NUnit.Framework;
using absolute_number_calculator;

namespace AbsoluteNumberCalculatorTest
{
    public class Tests
    {
        private AbsoluteNumberCalculator number;
        [SetUp]
        public void Setup()
        {
            number = new AbsoluteNumberCalculator();
        }

        [Test]
        public void TestAbsolute()
        {

            Assert.AreEqual(4, number.FindAbsolute(-4));
            

        }
        public void TestAbsolute2()
        {

            Assert.AreEqual(0, number.FindAbsolute(0));


        }
    }
}